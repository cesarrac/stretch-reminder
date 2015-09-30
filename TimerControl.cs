using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace StrechAlarm
{
    class TimerControl
    {
       
        private System.Timers.Timer timerClock = new System.Timers.Timer();

        private int clockTime = 0;
        private int alarmTime = 900; // in seconds

        private bool isPaused;

        public TimerControl()
        {
            InitializeTimer();
        }

        void InitializeTimer()
        {
            timerClock.Elapsed += new ElapsedEventHandler(OnTimer);
            timerClock.Interval = 1000;
            timerClock.Enabled = true;
        }


        /// <summary>
        /// Handles the Timer and calls pop-up Message Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTimer(object sender, ElapsedEventArgs e)
        {
            if (!isPaused)
            {
                // Start the timer
                try
                {
                    this.clockTime++;

                    //Pop up
                    if (this.clockTime == this.alarmTime)
                    {
                        // When Timer is done display a pop up baloon message
                        using (ProcessIcon pi = new ProcessIcon())
                        {
                            pi.PopUpBaloon();
                            //Reset the timer so it will call again
                            // WARNING! This will cause it to create a bunch of message boxes if I don't stop it
                            ResetTimer();
                        }
                    }
                      
                }
                catch (Exception ex)
                {
                    MessageBox.Show("OnTimer(): " + ex.Message);
                }
            }
           
              

        }

        public void ResetTimer()
        {
            clockTime = 0;
            alarmTime = 900;

            // In case user clicks on Reset Timer when isPaused is true, set isPaused to false here to start timer again
            isPaused = false;

        }

        public void PauseTimer()
        {
            if (!isPaused)
            {
                isPaused = true;
                // Display message announcing timer has been paused
                MessageBox.Show("See you when you get back.");
            }
            else 
            {
                isPaused = false;
            }
        }

    }
}
