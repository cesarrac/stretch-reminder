using System;
using System.Diagnostics;
using System.Windows.Forms;
using StrechAlarm.Properties;

namespace StrechAlarm
{
    class ProcessIcon : IDisposable
    {

        NotifyIcon ni;

        public ProcessIcon()
        {
            ni = new NotifyIcon();
        }

        public void Display()
        { 
            // Place the app icon on the System tray and listen for mouse clicks
            ni.MouseClick += new MouseEventHandler (ni_MouseClick);
            ni.Icon = Resources.SystemTrayApp;
            ni.Text = "Strech Reminder App";
            ni.Visible = true;
        
            // Attach a Context Menu
            ni.ContextMenuStrip = new ContextMenus().Create();
        
        }

        public void PopUpBaloon()
        {
            MessageBox.Show("Time to stretch!"); 

        }

        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string url = "http://www.mayoclinic.org/healthy-lifestyle/adult-health/multimedia/back-pain/sls-20076265";
                Process.Start("Firefox", url);
            }

            
        }

       
        public void Dispose()
        { 
            // When app exits the icon in the tray will be disposed immediately
            ni.Dispose();
        }
    }

}
