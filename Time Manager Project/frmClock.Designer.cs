namespace Time_Manager_Project
{
    partial class frmClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClock));
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn12 = new Guna.UI2.WinForms.Guna2Button();
            this.btn24 = new Guna.UI2.WinForms.Guna2Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbAMPM = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(68, 76);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(283, 86);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "00:00:00";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(116, 211);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(188, 47);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "dd-mm-yy";
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn12
            // 
            this.btn12.BorderRadius = 10;
            this.btn12.CheckedState.Parent = this.btn12;
            this.btn12.CustomImages.Parent = this.btn12;
            this.btn12.FillColor = System.Drawing.Color.Transparent;
            this.btn12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn12.ForeColor = System.Drawing.Color.White;
            this.btn12.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn12.HoverState.Parent = this.btn12;
            this.btn12.Image = global::Time_Manager_Project.Properties.Resources.icons8_12_00_50;
            this.btn12.ImageSize = new System.Drawing.Size(50, 50);
            this.btn12.Location = new System.Drawing.Point(121, 280);
            this.btn12.Name = "btn12";
            this.btn12.ShadowDecoration.Parent = this.btn12;
            this.btn12.Size = new System.Drawing.Size(78, 44);
            this.btn12.TabIndex = 1;
            this.btn12.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn24
            // 
            this.btn24.BorderRadius = 10;
            this.btn24.CheckedState.Parent = this.btn24;
            this.btn24.CustomImages.Parent = this.btn24;
            this.btn24.FillColor = System.Drawing.Color.Transparent;
            this.btn24.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn24.ForeColor = System.Drawing.Color.White;
            this.btn24.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn24.HoverState.Parent = this.btn24;
            this.btn24.Image = global::Time_Manager_Project.Properties.Resources.icons8_24_00_50__1_;
            this.btn24.ImageSize = new System.Drawing.Size(50, 50);
            this.btn24.Location = new System.Drawing.Point(205, 280);
            this.btn24.Name = "btn24";
            this.btn24.ShadowDecoration.Parent = this.btn24;
            this.btn24.Size = new System.Drawing.Size(78, 44);
            this.btn24.TabIndex = 1;
            this.btn24.Click += new System.EventHandler(this.btn24_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-12_00-50 (1).png");
            this.imageList1.Images.SetKeyName(1, "icons8-24_00-50 (1).png");
            this.imageList1.Images.SetKeyName(2, "icons8-12_00-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-24_00-50.png");
            // 
            // lbAMPM
            // 
            this.lbAMPM.AutoSize = true;
            this.lbAMPM.BackColor = System.Drawing.Color.Transparent;
            this.lbAMPM.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAMPM.Location = new System.Drawing.Point(344, 119);
            this.lbAMPM.Name = "lbAMPM";
            this.lbAMPM.Size = new System.Drawing.Size(50, 32);
            this.lbAMPM.TabIndex = 2;
            this.lbAMPM.Text = "PM";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(177, 169);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(58, 40);
            this.lbDay.TabIndex = 3;
            this.lbDay.Text = "Sat";
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(420, 378);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbAMPM);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn24);
            this.Controls.Add(this.lbDate);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClock";
            this.Text = "frmClock";
            this.Load += new System.EventHandler(this.frmClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btn24;
        private Guna.UI2.WinForms.Guna2Button btn12;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbAMPM;
        private System.Windows.Forms.Label lbDay;
    }
}