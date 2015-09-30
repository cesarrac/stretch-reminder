using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrechAlarm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the System tray icon
            using (ProcessIcon pi = new ProcessIcon())
            {
                pi.Display();
                
                // Make sure application runs
                Application.Run();

                
            }


        }

   

    }
}
