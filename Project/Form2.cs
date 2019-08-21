using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using HTTPComm;

namespace Project
{
    public partial class Form2 : Form
    {
        private string applicationName = Process.GetCurrentProcess().ProcessName;

        private RegistryKey registrykey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

        /* 설정 버튼이 클릭되었을 때 보여지는 Form으로, 현재 실행중인 프로그램이 시작 프로그램으로 등록되어 있으면,
         * CheckBox를 Check 된 상태로 만들어 주고, 현재 지정된 hotkey를 보여줄 수 있도록 구현 하였다.*/

        public Form2()
        {
            InitializeComponent();
            if(IsAutoStartApplication(applicationName)) autorunCheckBox.Checked = true;
            hotkeyLabel.Text = KeyboardHooker.hotkey;
        }

        /* 각 버튼이 클릭되었을 때의 행동에 큰 차이가 없으므로 하나의 Handler로 묶어서 처리 하였다.
         * 예약 종료의 경우는 현재 시간을 기준으로 몇 분 뒤 인지 설정되면 설정된 시간을 초로 변환하여
         * shutdown 명령어를 이용하여 실행하도록 하였고, 취소 버튼을 누르면 해당 사항을 취소하도록 하였다.
         * 다만, 지정 시간에 자동 종료는 단순히 shutdown 명령어 만을 이용하여 처리할 수 없기 때문에
         * 작업 스케줄러에 schtasks 명령어를 사용하여 등록하고, 취소하는 방식으로 구현 하였다.
         * hotkey의 경우에는 KeyBoardHooker.hotkey에 사용자가 변경한 hotkey를 등록하게 된다.*/

        private void Button_Handler(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string file = "schtasks";
            string command;

            switch (button.Name)
            {
                case "reservationSettingButton":
                    reservationCancelButton.Enabled = true;
                    reservationSettingButton.Enabled = false;
                    Process.Start("shutdown", "-s -t " + (Convert.ToInt32(reservationComboBox.Text) * 60).ToString());
                    break;
                case "autoshutdownSettingButton":
                    command = "/create /sc daily /tn \"Daily Shutdown\" /tr \"shutdown - s\" /st " + autoshutdownCheckBox.Text +":00";
                    autoshutdownCancelButton.Enabled = true;
                    autoshutdownSettingButton.Enabled = false;
                    Process.Start(file, command);
                    break;
                case "hotkeySettingButton":
                    if (!hotkeySettingCheckBox.Text.Equals("")) KeyboardHooker.hotkey = "LShift+" + hotkeySettingCheckBox.Text;
                    hotkeyLabel.Text = KeyboardHooker.hotkey;
                    break;
                case "reservationCancelButton":
                    reservationSettingButton.Enabled = true;
                    reservationCancelButton.Enabled = false;
                    Process.Start("shutdown", "-a");
                    break;
                case "autoshutdownCancelButton":
                    autoshutdownSettingButton.Enabled = true;
                    autoshutdownCancelButton.Enabled = false;
                    command = "/delete /tn \"Daily Shutdown\" /f";
                    Process.Start(file, command);
                    break;
            }
        }

        /* 윈도우 시작 시 자동 실행 체크박스가 체크되거나 해제될 때마다의 동작을
         * 수행하는 Event Handler이다.*/

        private void autorunCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.autorunCheckBox.Checked)
            {
                SetAutoStartApplication(applicationName);
            }
            else
            {
                ResetAutoStartApplication(applicationName);
            }
        }

        /* 현재 실행중인 프로그램을 시작 프로세스에 등록하게 된다.*/

        private void SetAutoStartApplication(string applicationname, string applicationfilepath)
        {
            if (registrykey.GetValue(applicationname) == null)
            {
                registrykey.SetValue(applicationname, applicationfilepath);
            }
        }
        private void SetAutoStartApplication(string applicationname)
        {
            SetAutoStartApplication(applicationname, Application.ExecutablePath);
        }

        /* 체크박스가 해제되었을 때, 현재 실행중인 프로그램을 시작 프로세스 목록에서
         * 없애게 된다.*/

        private void ResetAutoStartApplication(string applicationname)
        {
            if (registrykey.GetValue(applicationname) != null)
            {
                registrykey.DeleteValue(applicationname, false);
            }
        }

        /* 현재 프로그램이 시작 프로세스에 등록되어 있는지 여부를 반환한다.*/

        private bool IsAutoStartApplication(string applicationname)
        {
            return (registrykey.GetValue(applicationname) != null);
        }
    }
}
