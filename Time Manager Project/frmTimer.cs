using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Time_Manager_Project
{
    public partial class frmTimer : Form
    {

        
        private Stopwatch stopwatch = new Stopwatch();

        public frmTimer()
        {
            InitializeComponent();
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {

            if(stopwatch.IsRunning)
            {
                timer3.Stop();
                stopwatch.Stop();
               btnPause.Visible = false;
                btnPlay.Visible = true;
            }
            else
            {
                timer3.Start();
                stopwatch.Start();
                //btnPlayPause.Image = imageList1.Images[0];
                 btnPlay.Visible = false;
                btnPause.Visible = true;
            }
            

        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            timer3.Interval = 10;  // Update the ui every 10 milliseconds;
            lbTimer.Text = "00:00:00:00";
            btnPause.Visible = false;
            btnPlay.Visible = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lbTimer.Text = "00:00:00:00";
            stopwatch.Reset();
        }

        private void lbTimer_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;
            lbTimer.Text = ts.ToString(@"hh\:mm\:ss\:ff");
        }

       
    }
}
