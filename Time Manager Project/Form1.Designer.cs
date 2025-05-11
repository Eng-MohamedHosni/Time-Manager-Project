namespace Time_Manager_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnTimer = new Guna.UI2.WinForms.Guna2Button();
            this.btnStopWatch = new Guna.UI2.WinForms.Guna2Button();
            this.btnClock = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnTimer);
            this.panel1.Controls.Add(this.btnStopWatch);
            this.panel1.Controls.Add(this.btnClock);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 70);
            this.panel1.TabIndex = 0;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainpanel.Location = new System.Drawing.Point(0, 62);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(420, 378);
            this.mainpanel.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ClockBlue");
            this.imageList1.Images.SetKeyName(1, "StopWatchBlue");
            this.imageList1.Images.SetKeyName(2, "TimerBlue");
            this.imageList1.Images.SetKeyName(3, "ClockGray");
            this.imageList1.Images.SetKeyName(4, "StopWatchGray");
            this.imageList1.Images.SetKeyName(5, "TimerGray");
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // btnTimer
            // 
            this.btnTimer.BorderRadius = 10;
            this.btnTimer.CheckedState.Parent = this.btnTimer;
            this.btnTimer.CustomImages.Parent = this.btnTimer;
            this.btnTimer.FillColor = System.Drawing.Color.Transparent;
            this.btnTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimer.ForeColor = System.Drawing.Color.White;
            this.btnTimer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnTimer.HoverState.Parent = this.btnTimer;
            this.btnTimer.Image = global::Time_Manager_Project.Properties.Resources.icons8_sand_watch_48;
            this.btnTimer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTimer.Location = new System.Drawing.Point(58, 12);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.ShadowDecoration.Parent = this.btnTimer;
            this.btnTimer.Size = new System.Drawing.Size(78, 44);
            this.btnTimer.TabIndex = 0;
            this.btnTimer.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnStopWatch
            // 
            this.btnStopWatch.BorderRadius = 10;
            this.btnStopWatch.CheckedState.Parent = this.btnStopWatch;
            this.btnStopWatch.CustomImages.Parent = this.btnStopWatch;
            this.btnStopWatch.FillColor = System.Drawing.Color.Transparent;
            this.btnStopWatch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStopWatch.ForeColor = System.Drawing.Color.White;
            this.btnStopWatch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnStopWatch.HoverState.Parent = this.btnStopWatch;
            this.btnStopWatch.Image = global::Time_Manager_Project.Properties.Resources.icons8_stopwatch_48;
            this.btnStopWatch.ImageSize = new System.Drawing.Size(35, 35);
            this.btnStopWatch.Location = new System.Drawing.Point(159, 12);
            this.btnStopWatch.Name = "btnStopWatch";
            this.btnStopWatch.ShadowDecoration.Parent = this.btnStopWatch;
            this.btnStopWatch.Size = new System.Drawing.Size(78, 44);
            this.btnStopWatch.TabIndex = 0;
            this.btnStopWatch.Click += new System.EventHandler(this.btnStopWatch_Click);
            // 
            // btnClock
            // 
            this.btnClock.BorderRadius = 10;
            this.btnClock.CheckedState.Parent = this.btnClock;
            this.btnClock.CustomImages.Parent = this.btnClock;
            this.btnClock.FillColor = System.Drawing.Color.Transparent;
            this.btnClock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClock.ForeColor = System.Drawing.Color.White;
            this.btnClock.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClock.HoverState.Parent = this.btnClock;
            this.btnClock.Image = global::Time_Manager_Project.Properties.Resources.icons8_clock_64;
            this.btnClock.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClock.Location = new System.Drawing.Point(262, 12);
            this.btnClock.Name = "btnClock";
            this.btnClock.ShadowDecoration.Parent = this.btnClock;
            this.btnClock.Size = new System.Drawing.Size(78, 44);
            this.btnClock.TabIndex = 0;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Time_Manager_Project.Properties.Resources._CITYPNG_COM_Transparent_White_Square_Close_X_Button_Icon___1000x1000;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(378, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(36, 35);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 440);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnClock;
        private Guna.UI2.WinForms.Guna2Button btnTimer;
        private Guna.UI2.WinForms.Guna2Button btnStopWatch;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

