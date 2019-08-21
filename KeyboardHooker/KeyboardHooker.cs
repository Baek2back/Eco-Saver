using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms; 
using System.Diagnostics;

public class KeyboardHooker
{
    /* 먼저, 후킹이란 운영체제에서 응용 프로그램으로 전달되는
     * 윈도우즈 메시지(WM)을 잡아채는 것을 말한다. 사용자가 키보드를 이용하여 키를 누르게 되면,
     * 운영체제에서 확인하고, WM를 생성하게 된다. 그 후 운영체제는
     * WM을 현재 활성화 된 프로그램에 전달하게 되고, 프로그램은 입력된 키에 해당하는 행동을 수행한다.
     * 앞서 언급한 과정 중에서 운영체제가 활성화 된 프로그램에게 WM을 전달하기 전에 Hook Process를 
     * 설치하여, 운영체제가 프로그램에게 전달하는 WM을 확인하고 이용할 수 있는 것이다.
     * 이때, Hook Process는 발생하는 모든 WM을 응용 프로그램에게 전달하면서, 자신이 희망하는 WM이 
     * 발생되면 처리 후 응용 프로그램에게 전달할지 여부를 결정할 수 있게 된다.*/
    public enum SpecialKey
    {
        Alt = Keys.Alt,
        LShift = Keys.LShiftKey,
        RShift = Keys.RShiftKey,
        LCtrl = Keys.LControlKey,
        RCtrl = Keys.RControlKey
    }
    public enum FnumberKey
    {
        F1 = Keys.F1,
        F2 = Keys.F2,
        F3 = Keys.F3,
        F4 = Keys.F4,
        F5 = Keys.F5,
        F6 = Keys.F6,
        F7 = Keys.F7,
        F8 = Keys.F8,
        F9 = Keys.F9,
        F10 = Keys.F10,
        F11 = Keys.F11,
        F12 = Keys.F12
    }
    public static SpecialKey specialkey = SpecialKey.Alt | SpecialKey.LShift | SpecialKey.RShift | SpecialKey.LCtrl | SpecialKey.RCtrl;
    public static FnumberKey fnumberkey = FnumberKey.F1 | FnumberKey.F2 | FnumberKey.F3 | FnumberKey.F4 | FnumberKey.F5 | FnumberKey.F6 | FnumberKey.F7 | FnumberKey.F8 | FnumberKey.F9 | FnumberKey.F10 | FnumberKey.F11 | FnumberKey.F12;
    public static SpecialKey special;
    public static FnumberKey fnumber;
    public static string input = "";
    public static string hotkey = "LShift+F1";
    public static bool checkspecialkey = false;
    public static bool checkfnumberkey = false;

    /* Monitor Off, Shutdown을 수행할 키 입력을 Shift + F1, Shift + F2로 할 것이지만, 추후에 확장에 용이하도록
     * enum 을 이용하여 자주 사용되는 키를 미리 선언해 두었다. 또한 동시에 두 개의 키가 입력되었을 때 처리하기 위해
     * bool 변수를 미리 선언하여 동시에 키가 눌렸는 지 여부를 판별할 수 있도록 하였다. 최종적으로는 사용자가 
     * HotKey를 변경할 수도 있으므로 동시에 두 개의 키가 눌렸을 때 input에 넣어두고 hotkey와 같으면 기능을 수행하도록
     * 하였다. */

    [DllImport("user32.dll")]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll")]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll")]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll")]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    /* Hook Process는 시스템에서 호출하는 함수(CallBack)이므로, 미리 정의된 형식에 맞춰야 한다.
     * 이때, SetWindowsHookEx 함수는 타겟 프로그램의 WM 처리 프로시저를, 본인이 정의한 WM 처리 프로시저로 변경하는 함수이다.
     * 위 함수를 이용하게 되면 메모리에 올라간 프로세스에 적재되는 것이므로 작업이 모두 끝나면 UnhookWindowsHookEx 함수를 호출하여
     * 메모리를 반환하고 Hooking을 해제해주게 된다. 또한, CallNextHookEx 함수를 사용하지 않으면 키보드 메시지를 후킹하였다 하더라도 
     * 해당 메시지를 사용하는 다른 Hook 프로시저에게 제어를 넘겨주지 않으면 후킹했다는 사실이 알려지게 될 것이다.
     * 마지막으로 GetModuleHandle 함수는 dll 파일이나 exe 파일에 대한 handle을 가져오는 함수로 현재 실행중인 프로그램의 handle 값을
     * 얻어와야 Hooking이 가능하므로 그때 사용하게 된다. */

    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;
    private const int WM_KEYUP = 0x101;

    private static LowLevelKeyboardProc _proc = HookCallback;
    private static IntPtr _hookID = IntPtr.Zero;

    /* 실질적으로 Hooking을 수행하는 함수로, wParam를 이용하여 처리하고자 하는 메시지를 확인한다.
     * 이때, Shift + F1 처럼 두 키가 동시에 눌렸을 때 입력을 받고자 하였으므로 키보드가 눌렸을 때
     * 혹은 떼어질 때 입력된 키 값을 이용하여 Shift 같은 특수 키인지 Fnumber 꼴의 키가 눌렸는 지
     * bool Type의 변수를 이용하여 확인할 수 있도록 하였다. 최종적으로 두 종류의 키가 모두 눌렸을 때,
     * bool 변수를 다시 초기화하고, 동시에 눌린 키의 입력을 확인하고, 다음 Hook Procedure에게 제어를 넘기게 된다.*/

    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
    private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && (wParam == (IntPtr)WM_KEYDOWN) | (wParam == (IntPtr)WM_KEYUP))
        {
            int vkCode = Marshal.ReadInt32(lParam);
            if (specialkey.HasFlag((SpecialKey)vkCode))
            {
                checkspecialkey = true;
                special = (SpecialKey)vkCode;
            }
            else if (fnumberkey.HasFlag((FnumberKey)vkCode))
            {
                checkfnumberkey = true;
                fnumber = (FnumberKey)vkCode;
            }

            if (checkspecialkey && checkfnumberkey)
            {
                input = special.ToString() +"+"+ fnumber.ToString();
                checkspecialkey = false;
                checkfnumberkey = false;
            }
        }
        return CallNextHookEx(_hookID, nCode, wParam, lParam);
    }

    /* SetWindowsHookEx 함수를 호출하여 Hook Process를 등록하게 되고, 이 함수는 HookID를 Return 하는데,
     * 이 HookID를 이용하여 Hook Process를 종료하게 된다. Hook Process는 응용 프로그램이 종료될 때, 종료시키지
     * 않으므로 UnhookWindowsHookEx 를 이용하여 명시적으로 해제해 주어야 한다.*/
    public static void HookStart()
    {
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            _hookID = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, GetModuleHandle(curModule.ModuleName), 0);
        }
    }

    public static void HookEnd()
    {
        UnhookWindowsHookEx(_hookID);
    }
}

