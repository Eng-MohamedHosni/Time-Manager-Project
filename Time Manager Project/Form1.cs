using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Manager_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            btnTimer.Image = imageList1.Images[2];
            btnClock.Image = imageList1.Images[3];
            btnStopWatch.Image = imageList1.Images[4];
            loadform(new frmStopWatch());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStopWatch_Click(object sender, EventArgs e)
        {
            btnTimer.Image = imageList1.Images[5];
            btnClock.Image = imageList1.Images[3];
            btnStopWatch.Image = imageList1.Images[1];

            loadform(new frmTimer());

        }
         
        public void loadform(object form)
        {
            if(this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock= DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void btnClock_Click(object sender, EventArgs e)
        {
            btnClock.Image = imageList1.Images["ClockBlue"];
            btnTimer.Image= imageList1.Images["TimerGray"];
            btnStopWatch.Image = imageList1.Images["StopWatchGray"];
            loadform(new frmClock());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadform(new frmClock());
            btnTimer.Image= imageList1.Images[5];
            btnStopWatch.Image= imageList1.Images[4];
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}