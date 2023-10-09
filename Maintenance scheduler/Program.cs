using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance_scheduler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new ScheduleMaintenance()
            //};
            //ServiceBase.Run(ServicesToRun);

#if DEBUG
            //While debugging this section is used.
            ScheduleMaintenance myService = new ScheduleMaintenance();
            myService.onDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);

#else
                            //In Release this section is used. This is the "normal" way.
                            ServiceBase[] ServicesToRun;
                            ServicesToRun = new ServiceBase[] 
                            { 
                                new ScheduleMaintenance() 
                            };
                            ServiceBase.Run(ServicesToRun);
#endif

        }
    }
}
