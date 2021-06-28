namespace Blood_Bank_Management_System
{
    partial class frm_splash_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_splash_form));
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.pbar_splash = new System.Windows.Forms.ProgressBar();
            this.pb_Header = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbl_per = new System.Windows.Forms.Label();
            this.xuiGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Header)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Bisque;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Orange;
            this.xuiGradientPanel1.Controls.Add(this.lbl_per);
            this.xuiGradientPanel1.Controls.Add(this.panel1);
            this.xuiGradientPanel1.Controls.Add(this.lbl_note);
            this.xuiGradientPanel1.Controls.Add(this.pbar_splash);
            this.xuiGradientPanel1.Controls.Add(this.pb_Header);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(630, 526);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 0;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 44);
            this.panel1.TabIndex = 6;
            // 
            // lbl_Header
            // 
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Header.Location = new System.Drawing.Point(64, 4);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(554, 43);
            this.lbl_Header.TabIndex = 7;
            this.lbl_Header.Text = "Blood Bank Management System";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_note.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_note.Location = new System.Drawing.Point(155, 415);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(300, 22);
            this.lbl_note.TabIndex = 5;
            this.lbl_note.Text = "Loading Application Please Wait......";
            // 
            // pbar_splash
            // 
            this.pbar_splash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbar_splash.Location = new System.Drawing.Point(82, 440);
            this.pbar_splash.Name = "pbar_splash";
            this.pbar_splash.Size = new System.Drawing.Size(467, 23);
            this.pbar_splash.TabIndex = 4;
            // 
            // pb_Header
            // 
            this.pb_Header.Image = ((System.Drawing.Image)(resources.GetObject("pb_Header.Image")));
            this.pb_Header.Location = new System.Drawing.Point(82, 66);
            this.pb_Header.Name = "pb_Header";
            this.pb_Header.Size = new System.Drawing.Size(467, 309);
            this.pb_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Header.TabIndex = 3;
            this.pb_Header.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 50;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbl_per
            // 
            this.lbl_per.AutoSize = true;
            this.lbl_per.BackColor = System.Drawing.Color.Transparent;
            this.lbl_per.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_per.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_per.Location = new System.Drawing.Point(555, 440);
            this.lbl_per.Name = "lbl_per";
            this.lbl_per.Size = new System.Drawing.Size(20, 22);
            this.lbl_per.TabIndex = 7;
            this.lbl_per.Text = "0";
            // 
            // frm_splash_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 526);
            this.ControlBox = false;
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_splash_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Header)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.ProgressBar pbar_splash;
        private System.Windows.Forms.PictureBox pb_Header;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_per;
    }
}