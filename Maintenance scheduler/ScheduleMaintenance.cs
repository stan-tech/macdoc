using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using macdoc;
using Timer = System.Timers.Timer;

namespace Maintenance_scheduler
{
    public partial class ScheduleMaintenance : ServiceBase
    {

        EventLog eventLog;
        public ScheduleMaintenance()
        {
            InitializeComponent();

            eventLog = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("localhost"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "localhost", "MaintainLog");
            }
            eventLog.Source = "localhost";
            eventLog.Log = "MaintainLog";
        }

        protected override void OnStart(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 15000;
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();


        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {

            LaunchMacDoc();

        }
        protected override void OnStop()
        {
        }
        public void onDebug()
        {
            OnStart(null);
        }

        public void LaunchMacDoc()
        {
            if (Process.GetProcessesByName("macdoc").Length == 0)
            {
                Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = macdoc.Home.AppPath + "\\macdoc.exe";
                p.StartInfo.Arguments = "silent";

                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
            }
        }

      
    }
}
