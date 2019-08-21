using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HTTPComm;
using System.Diagnostics;
using Microsoft.Win32;

namespace Project
{
    public partial class Form1 : Form
    {
        string path = Application.StartupPath + "\\nircmd\\nircmd.exe";

        /* 이전 과제와 동일하게 hooking 여부를 계속해서 판별할 수 있어야 하므로, Timer를
         * 이용하여 지속적으로 확인하도록 하였다. 또한, 예약 종료나 특정 시간 종료가 수행될 때,
         * 윈도우 종료를 감지하고 서버에 Log를 남길 수 있도록 구현하기 위하여 SessionEnding 이벤트에
         * EventHandler를 구현하여 윈도우 종료 전에 Log를 남길 수 있도록 하였다. 또한 대기 모드에서,
         * 해제되었을 때 발생하는 PowerModeChanged 이벤트 핸들러를 구현하여 서버에 WakeUp 기록을 남기도록
         * 하였다.*/
        public Form1()
        {
            InitializeComponent();
            hookingTimer.Start();
            SystemEvents.SessionEnding += SessionEndingEvtHandler;
            SystemEvents.PowerModeChanged += OnPowerModeChange;
            notifyIcon1.Visible = false;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        private void SessionEndingEvtHandler(object sender, SessionEndingEventArgs e)
        {
            Button_Handler(shutdownButton, e);
            e.Cancel = false;
        }

        private void OnPowerModeChange(object sender, PowerModeChangedEventArgs e)
        {
            if(e.Mode == PowerModes.Suspend)
            {
                HTTPWebComm comm = new HTTPWebComm();
                string url = "http://210.94.194.82:52131/log.asp?id=2014112089&cmd=write&action=wakeup";
                comm.SetURL(url);
                comm.setMessage("");
                comm.Reqeust();
                comm.Response();
            }
        }

        /* Form이 Load 되고, Close 될 때 각각, Hooking이 시작되고 종료되는 사항을
         * 반영 하였다. 또한 Load 될 때는, 초기 화면(dashboard)가 표시되도록 하였다.*/
        private void Form1_Load(object sender, EventArgs e)
        {
            mainBox_Click(null, e);
            KeyboardHooker.HookStart();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            KeyboardHooker.HookEnd();
        }

        /* Timer를 이용하여 Hooking을 확인하므로, KeyboardHooker.hotkey와
         * 동시에 눌린 두 개의 키가 같다면 시스템을 종료하도록 구현 하였다.*/

        private void hookingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!KeyboardHooker.input.Equals(""))
                {
                    if (KeyboardHooker.input.Equals(KeyboardHooker.hotkey))
                    {
                        Button_Handler(shutdownButton, e);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        /* Form을 구현하면서 BoarderStyle을 None으로 하였더니 마우스를 이용하여 위치를 조정할 수 없게 되었다.
         * 이를 해결하기 위해 새로 만들어준 panel(= topBar)을 마우스를 이용하여 끌면 위치가 조정되도록 하였다.*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /* 각각 설정 버튼과 이미지를 클릭하면 해당하는 Form이 contentsPanel에 채워지도록 하였다.*/

        private void settingButton_Click(object sender, EventArgs e)
        {
            FillContents(new Form2());
        }

        private void mainBox_Click(object sender, EventArgs e)
        {
            FillContents(new Form3());
        }

        private void FillContents(object contents)
        {
            if (this.contentsPanel.Controls.Count > 0) this.contentsPanel.Controls.RemoveAt(0);
            Form form = contents as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.contentsPanel.Controls.Add(form);
            this.contentsPanel.Tag = form;
            form.Show();
        }

        /* 좌측 하단과 우측 상단에 있는 pictureBox를 클릭하면 해당하는 행동을 하도록 구현하고,
         * trey icon 상태일 때 우측 클릭하면 나타나는 show와 exit에 대한 행동도 구현 하였다.*/
        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void disappearBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* 설정 버튼과 이미지를 제외한 나머지 버튼에 대한 Event Handler로,
         * nircmd를 이용하여 클릭된 버튼에 따라 해당 기능을 수행하도록 하였다.*/

        private void Button_Handler(object sender, EventArgs e)
        {
            string operation = "";
            string url = "http://210.94.194.82:52131/log.asp?id=2014112089&cmd=write&action=";
            Button button = sender as Button;
            switch (button.Name)
            {
                case "shutdownButton":
                    url += "shutdown";
                    operation = "exitwin poweroff";
                    break;
                case "sleepButton":
                    url += "sleep";
                    operation = "monitor off";
                    break;
                case "suspendButton":
                    url += "suspend";
                    operation = "standby force";
                    break;
                case "hibernateButton":
                    url += "hibernate";
                    operation = "hibernate force";
                    break;
            }
            HTTPWebComm comm = new HTTPWebComm();
            comm.SetURL(url);
            comm.setMessage("");
            comm.Reqeust();
            comm.Response();
            Process.Start(path, operation);
        }
    }
}
