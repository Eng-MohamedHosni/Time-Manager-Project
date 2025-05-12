using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace Time_Manager_Project
{
    public partial class frmStopWatch : Form
    {
        public frmStopWatch()
        {
            InitializeComponent();
        }

        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();

        DateTime TargetTime;

        // Handle MouseWheel event for the form
        private void frmStopWatch_MouseWheel(object sender, MouseEventArgs e)
        {
            // Check if the mouse is over the lbH (Label)
            if (lbH.ClientRectangle.Contains(lbH.PointToClient(Control.MousePosition)))
            {
                // Only adjust if the text in the Label is a number
                if (int.TryParse(lbH.Text, out int currentValue))
                {
                    if (e.Delta > 0)  // Scroll up
                    {
                        currentValue++;  // Increase the value
                    }
                    else if (e.Delta < 0)  // Scroll down
                    {
                        if (currentValue > 0)
                            currentValue--; // Decrease the value
                    }

                    // Update the Label with the new value
                    lbH.Text = currentValue.ToString("D2");
                }
            }

            if (lbM.ClientRectangle.Contains(lbM.PointToClient(Control.MousePosition)))
            {
                // Only adjust if the text in the Label is a number
                if (int.TryParse(lbM.Text, out int currentValue))
                {
                    if (e.Delta > 0)  // Scroll up
                    {
                        currentValue++;  // Increase the value
                    }
                    else if (e.Delta < 0)  // Scroll down
                    {
                        if (currentValue > 0)
                            currentValue--;
                          // Decrease the value
                            
                    }

                    // Update the Label with the new value
                    lbM.Text = currentValue.ToString("D2");
                }
            }
            if (lbS.ClientRectangle.Contains(lbS.PointToClient(Control.MousePosition)))
            {
                // Only adjust if the text in the Label is a number
                if (int.TryParse(lbS.Text, out int currentValue))
                {
                    if (e.Delta > 0)  // Scroll up
                    {
                        currentValue++;  // Increase the value
                    }
                    else if (e.Delta < 0)  // Scroll down
                    {
                        if (currentValue > 0)
                            currentValue--;  // Decrease the value
                    }

                    // Update the Label with the new value
                    lbS.Text = currentValue.ToString("D2");
                }
            }
            
        }

        // Subscribe to the MouseWheel event for the Form
        private void frmStopWatch_Load(object sender, EventArgs e)
        {
           
            this.MouseWheel += frmStopWatch_MouseWheel;
            btnPause.Visible = false;
            btnAlarm.Visible = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lbH.Text == "00" && lbM.Text == "00" && lbS.Text == "00")
                return;

            if(timer1.Enabled)
            {
                btnPause.Visible = false;
                btnPlay.Visible = true;
                timer1.Stop();
                
            }
            else
            {
                btnPause.Visible = true;
                btnPlay.Visible = false;
                TimeSpan ts = new TimeSpan(int.Parse(lbH.Text), int.Parse(lbM.Text), int.Parse(lbS.Text));

                DateTime StartTime=DateTime.Now;
               
                TargetTime = StartTime.Add(ts);
               
                timer1.Start();

            }

          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TargetTime<DateTime.Now)
            {
                timer1.Stop();
                btnPause.Visible = false;
                btnPlay.Visible = true;
                Player.URL = @"H:\Mohamed Abo_Hadhod\Projects\Time Manager Project\Time Manager Project\mp3\alarm.mp3";
                Player.controls.play();
                btnAlarm.Visible = true;
                return;

            }
            

                
            TimeSpan ts = TargetTime - DateTime.Now;
            lbH.Text = ts.ToString(@"hh");
            lbM.Text = ts.ToString("mm");
            lbS.Text = ts.ToString("ss");


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lbH.Text=lbS.Text=lbM.Text = "00";

           
            if(timer1.Enabled)
            {
             timer1.Stop();
                btnPause.Visible=false;
                btnPlay.Visible=true;

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            lbH.Text = btn.Text.ToString().Substring(0, 2);
            lbM.Text = btn.Text.ToString().Substring(3, 2);
            lbS.Text = btn.Text.ToString().Substring(6, 2);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
            btnAlarm.Visible = false;
        }
    }
}
