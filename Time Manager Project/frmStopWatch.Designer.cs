namespace Time_Manager_Project
{
    partial class frmStopWatch
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
            this.lbH = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.btnPause = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlay = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn30 = new Guna.UI2.WinForms.Guna2Button();
            this.btn1h = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH.ForeColor = System.Drawing.Color.White;
            this.lbH.Location = new System.Drawing.Point(25, 80);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(109, 86);
            this.lbH.TabIndex = 2;
            this.lbH.Text = "00";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM.ForeColor = System.Drawing.Color.White;
            this.lbM.Location = new System.Drawing.Point(150, 80);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(109, 86);
            this.lbM.TabIndex = 3;
            this.lbM.Text = "00";
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.ForeColor = System.Drawing.Color.White;
            this.lbS.Location = new System.Drawing.Point(282, 80);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(109, 86);
            this.lbS.TabIndex = 4;
            this.lbS.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 86);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(245, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 86);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
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
            this.btnStop.Location = new System.Drawing.Point(218, 250);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(79, 74);
            this.btnStop.TabIndex = 7;
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
            this.btnPause.Location = new System.Drawing.Point(96, 250);
            this.btnPause.Name = "btnPause";
            this.btnPause.ShadowDecoration.Parent = this.btnPause;
            this.btnPause.Size = new System.Drawing.Size(79, 74);
            this.btnPause.TabIndex = 8;
            this.btnPause.Click += new System.EventHandler(this.btnPlay_Click);
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
            this.btnPlay.Location = new System.Drawing.Point(96, 250);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShadowDecoration.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(79, 74);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn5
            // 
            this.btn5.BorderRadius = 10;
            this.btn5.CheckedState.Parent = this.btn5;
            this.btn5.CustomImages.Parent = this.btn5;
            this.btn5.FillColor = System.Drawing.Color.Transparent;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn5.HoverState.Parent = this.btn5;
            this.btn5.ImageSize = new System.Drawing.Size(80, 80);
            this.btn5.Location = new System.Drawing.Point(253, 186);
            this.btn5.Name = "btn5";
            this.btn5.ShadowDecoration.Parent = this.btn5;
            this.btn5.Size = new System.Drawing.Size(82, 51);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "00:05:00";
            this.btn5.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btn30
            // 
            this.btn30.BorderRadius = 10;
            this.btn30.CheckedState.Parent = this.btn30;
            this.btn30.CustomImages.Parent = this.btn30;
            this.btn30.FillColor = System.Drawing.Color.Transparent;
            this.btn30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30.ForeColor = System.Drawing.Color.White;
            this.btn30.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn30.HoverState.Parent = this.btn30;
            this.btn30.ImageSize = new System.Drawing.Size(80, 80);
            this.btn30.Location = new System.Drawing.Point(165, 186);
            this.btn30.Name = "btn30";
            this.btn30.ShadowDecoration.Parent = this.btn30;
            this.btn30.Size = new System.Drawing.Size(82, 51);
            this.btn30.TabIndex = 10;
            this.btn30.Text = "00:30:00";
            this.btn30.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btn1h
            // 
            this.btn1h.BorderRadius = 10;
            this.btn1h.CheckedState.Parent = this.btn1h;
            this.btn1h.CustomImages.Parent = this.btn1h;
            this.btn1h.FillColor = System.Drawing.Color.Transparent;
            this.btn1h.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1h.ForeColor = System.Drawing.Color.White;
            this.btn1h.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn1h.HoverState.Parent = this.btn1h;
            this.btn1h.ImageSize = new System.Drawing.Size(80, 80);
            this.btn1h.Location = new System.Drawing.Point(67, 186);
            this.btn1h.Name = "btn1h";
            this.btn1h.ShadowDecoration.Parent = this.btn1h;
            this.btn1h.Size = new System.Drawing.Size(82, 51);
            this.btn1h.TabIndex = 10;
            this.btn1h.Text = "01:00:00";
            this.btn1h.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // frmStopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(420, 378);
            this.Controls.Add(this.btn1h);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.lbH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStopWatch";
            this.Text = "frmStopWatch";
            this.Load += new System.EventHandler(this.frmStopWatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbH;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private Guna.UI2.WinForms.Guna2Button btnPause;
        private Guna.UI2.WinForms.Guna2Button btnPlay;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btn5;
        private Guna.UI2.WinForms.Guna2Button btn30;
        private Guna.UI2.WinForms.Guna2Button btn1h;
    }
}