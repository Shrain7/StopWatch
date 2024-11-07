using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class StopWatch : Form
    {
        private DateTime startTime; 
        private TimeSpan accumulatedTime = TimeSpan.Zero;
        public StopWatch()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            // Set a value to start time
            startTime = DateTime.Now - accumulatedTime;

            //Start the timer
            formTimer.Start();
        }

        private void pausebutton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
            accumulatedTime = DateTime.Now - startTime;
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
            accumulatedTime = TimeSpan.Zero;
            WatchLabel.Text = "00:00:00";
        }

        private void formtimer_Tick(object sender, EventArgs e)
        {
            //calculate how long it's been since start
            TimeSpan span = DateTime.Now - startTime;
            WatchLabel.Text = span.ToString(@"mm\:ss\.ff");
        }
    }
}
