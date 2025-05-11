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
    public partial class frmClock : Form
    {

        enum enTimeMode {  e12,e24} ;
        enTimeMode TimeMode= enTimeMode.e12;

        public frmClock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeMode == enTimeMode.e12)
            {
                lbTime.Text = DateTime.Now.ToString("hh:mm:ss");
                lbAMPM.Text = DateTime.Now.ToString("tt");
            }
            else
            {
                lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
                lbAMPM.Text = "";
            }

        }

        private void frmClock_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            
             lbDay.Text = DateTime.Now.ToString("ddd");

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TimeMode = enTimeMode.e12;
            btn12.Image = imageList1.Images[2];
            btn24.Image = imageList1.Images[1];

        }

        private void btn24_Click(object sender, EventArgs e)
        {
            TimeMode= enTimeMode.e24;
            btn12.Image = imageList1.Images[0];
            btn24.Image = imageList1.Images[3];
        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }
    }
}
