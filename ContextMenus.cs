using System;
using System.Diagnostics;
using System.Windows.Forms;
using StrechAlarm.Properties;
using System.Drawing;

namespace StrechAlarm
{
    class ContextMenus
    {
        TimerControl timer = new TimerControl();

        public ContextMenuStrip Create()
        {
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;
            

            // Open Firefox
            item = new ToolStripMenuItem();
            item.Text = "Search new Exercise";
            item.Click += new EventHandler(Firefox_Click);
            item.Image = Resources.Firefox;
            menu.Items.Add(item);

            //Start Timer
            item = new ToolStripMenuItem();
            item.Text = "Reset Timer";
            item.Click += new EventHandler(ResetTimer_Click);
            item.Image = Resources.Timer;
            menu.Items.Add(item);

            //Pause Timer
            item = new ToolStripMenuItem();
            item.Text = "Pause Timer";
            item.Click += new EventHandler(PauseTimer_Click);
            item.Image = Resources.Timer;
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // Exit.
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new System.EventHandler(Exit_Click);
            item.Image = Resources.Exit;
            menu.Items.Add(item);

            return menu;
        }

        void Firefox_Click(object sender, EventArgs e)
        {
            string url = "http://www.mayoclinic.org/healthy-lifestyle/adult-health/multimedia/back-pain/sls-20076265";
            Process.Start("Firefox", url);
        }

        void ResetTimer_Click(object sender, EventArgs e)
        {
            timer.ResetTimer();
        }

        void PauseTimer_Click(object sender, EventArgs e)
        {
            timer.PauseTimer();
        }


        // Exit Application
        void Exit_Click(object sender, EventArgs e)
        {
            // Quit without further ado.
            Application.Exit();
        }

       


    }
}
