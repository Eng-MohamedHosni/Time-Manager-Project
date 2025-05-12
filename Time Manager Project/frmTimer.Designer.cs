namespace Time_Manager_Project
{
    partial class frmTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimer));
            this.lbTimer = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.btnPause = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlay = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(25, 86);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(370, 86);
            this.lbTimer.TabIndex = 1;
            this.lbTimer.Text = "00:00:00:00";
            this.lbTimer.Click += new System.EventHandler(this.lbTimer_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pause (3).png");
            this.imageList1.Images.SetKeyName(1, "play-button (3).png");
            // 
            // btnStop
            // 
            this.btnStop.BorderRadius = 10;
            this.btnStop.CheckedState.Parent = this.btnStop;
            this.btnStop.CustomImages.Parent = this.btnStop;
            this.btnStop.FillColor = System.Drawing.Color.Transparent;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnStop.HoverState.Parent = this.btnStop;
            this.btnStop.Image = global::Time_Manager_Project.Properties.Resources.stop;
            this.btnStop.ImageSize = new System.Drawing.Size(80, 80);
            this.btnStop.Location = new System.Drawing.Point(224, 218);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(85, 77);
            this.btnStop.TabIndex = 3;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BorderRadius = 10;
            this.btnPause.CheckedState.Parent = this.btnPause;
            this.btnPause.CustomImages.Parent = this.btnPause;
            this.btnPause.FillColor = System.Drawing.Color.Transparent;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPause.HoverState.Parent = this.btnPause;
            this.btnPause.Image = global::Time_Manager_Project.Properties.Resources.pause__3_1;
            this.btnPause.ImageSize = new System.Drawing.Size(80, 80);
            this.btnPause.Location = new System.Drawing.Point(90, 218);
            this.btnPause.Name = "btnPause";
            this.btnPause.ShadowDecoration.Parent = this.btnPause;
            this.btnPause.Size = new System.Drawing.Size(85, 77);
            this.btnPause.TabIndex = 3;
            this.btnPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BorderRadius = 10;
            this.btnPlay.CheckedState.Parent = this.btnPlay;
            this.btnPlay.CustomImages.Parent = this.btnPlay;
            this.btnPlay.FillColor = System.Drawing.Color.Transparent;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPlay.HoverState.Parent = this.btnPlay;
            this.btnPlay.Image = global::Time_Manager_Project.Properties.Resources.play_button__3_;
            this.btnPlay.ImageSize = new System.Drawing.Size(70, 70);
            this.btnPlay.Location = new System.Drawing.Point(90, 218);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShadowDecoration.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(85, 77);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPlayPause_Click);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(420, 378);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbTimer);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimer";
            this.Text = "frmTimer";
            this.Load += new System.EventHandler(this.frmTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer3;
        private Guna.UI2.WinForms.Guna2Button btnPlay;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2Button btnPause;
    }
}