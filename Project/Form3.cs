using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTTPComm;

namespace Project
{
    public partial class Form3 : Form
    {
        HTTPWebComm comm = new HTTPWebComm();
        string[] readAction = { "shutdown", "sleep", "suspend", "hibernate" };
        DateTime[] readActionTime = new DateTime[4];
        TimeSpan[] diff = new TimeSpan[4];
        DateTime bootingTime = DateTime.Now.AddMilliseconds(-Environment.TickCount);
        TimeSpan bootingDiff = new TimeSpan();

        /* 프로그램을 처음 실행했을 때 보여지는 기본 화면으로, 서버로부터 Log를 읽어와
         * 각 Action이 기록된 시간과 현재 시간과의 차이를 직관적으로 보여줄 수 있도록 .
         * ProgressBar를 이용하여 구현하였다. 기본적으로 제공하는 ProgressBar 보다는
         * .NET Framework의 Open Source Package인 NuGet에서 circularProgressBar를
         * import하여 사용 하였다. 또한 부팅 이후 경과한 시간을 표현 하여 사용 시간을
         * 측정할 수 있도록 하였다.*/

        public Form3()
        {
            InitializeComponent();
            dashboardTimer.Interval = 1000;
            this.dashboardTimer.Start();
        }

        /* 서버로부터 각 Action에 대한 Log를 읽어오는 메소드로, 해당 Action 및 UnixTime을 
         * 읽어오게 되므로, 받아온 값을 Parsing 하여 UnixTime만 분리하여 DateTime으로 변환하여
         * Return 하게 된다. */

        private DateTime ReadActionLog(string action)
        {
            string url = "http://210.94.194.82:52131/log.asp?id=2014112089&cmd=read&action=";
            url += action;
            char split = ':';
            double time;
            comm.SetURL(url);
            comm.setMessage("");
            comm.Reqeust();
            string result = comm.Response();
            time = double.Parse(result.Substring(result.IndexOf(split) + 1, 10));
            return UnixTimeToDateTime(time);
        }

        /* UnixTime을 DateTime으로 변환하는 메소드이다.*/
        private static DateTime UnixTimeToDateTime(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0);
            origin = origin.AddHours(9);
            origin = origin.AddMinutes(3);
            origin = origin.AddSeconds(2);
            return origin.AddSeconds(timestamp);
        }

        /* 1초 경과할 때마다, 현재 시간과 Action이 수행된 시간과의 차이가 1초 씩 증가하고,
         * 이를 ProgressBar에 반영할 수 있어야 하므로 Timer가 1초 씩 지날 때마다 현재 시간과의
         * 차이를 반영할 수 있도록 구현 하였다.*/

        private void dashboardTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                bootingDiff = DateTime.Now - bootingTime;
                for (int i = 0; i < readAction.Length; i++)
                {
                    readActionTime[i] = ReadActionLog(readAction[i]);
                    diff[i] = DateTime.Now - readActionTime[i];
                }

                FirstTimerLabel1.Text = diff[0].Seconds.ToString();
                shutdownProgressBar.Text = diff[0].Hours + ":" + diff[0].Minutes;
                FirstTimerLabel2.Text = "시간 : 분";
                FirstTimerLabel3.Text = diff[0].Days + "일 경과";
                shutdownProgressBar.Value = Convert.ToInt32(FirstTimerLabel1.Text);

                SecondTimerLabel1.Text = diff[1].Seconds.ToString();
                sleepProgressBar.Text = diff[1].Hours + ":" + diff[1].Minutes;
                SecondTimerLabel2.Text = "시간 : 분";
                SecondTimerLabel3.Text = diff[1].Days + "일 경과";
                sleepProgressBar.Value = Convert.ToInt32(SecondTimerLabel1.Text);

                ThirdTimerLabel1.Text = diff[2].Seconds.ToString();
                suspendProgressBar.Text = diff[2].Hours + ":" + diff[2].Minutes;
                ThirdTimerLabel2.Text = "시간 : 분";
                ThirdTimerLabel3.Text = diff[2].Days + "일 경과";
                suspendProgressBar.Value = Convert.ToInt32(ThirdTimerLabel1.Text);

                FourthTimerLabel1.Text = diff[3].Seconds.ToString();
                hibernateProgressBar.Text = diff[3].Hours + ":" + diff[3].Minutes;
                FourthTimerLabel2.Text = "시간 : 분";
                FourthTimerLabel3.Text = diff[3].Days + "일 경과";
                hibernateProgressBar.Value = Convert.ToInt32(FourthTimerLabel1.Text);

                FifthTimerLabel.Text = bootingDiff.Seconds.ToString();
                bootingTimeProgressBar.Value = Convert.ToInt32(FifthTimerLabel.Text);
                bootingTimeLabel.Text = bootingDiff.Days + "일 " + bootingDiff.Hours + "시간 " + bootingDiff.Minutes + "분 경과";

            }catch(Exception)
            {
                return;
            }
        }
    }
}
