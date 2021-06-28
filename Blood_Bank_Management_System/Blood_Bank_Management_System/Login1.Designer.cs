namespace Blood_Bank_Management_System
{
    partial class frm_Login_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login_1));
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lnl_Show = new System.Windows.Forms.LinkLabel();
            this.lbl_Login1 = new System.Windows.Forms.Label();
            this.pnl_Login1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Login = new XanderUI.XUIButton();
            this.pnl_Login1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Username.Image")));
            this.lbl_Username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Username.Location = new System.Drawing.Point(57, 122);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(155, 41);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Password.Image")));
            this.lbl_Password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Password.Location = new System.Drawing.Point(57, 239);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(147, 41);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(62, 166);
            this.tb_Username.MaxLength = 10;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(369, 29);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(62, 283);
            this.tb_Password.MaxLength = 20;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(369, 29);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // lnl_Show
            // 
            this.lnl_Show.AutoSize = true;
            this.lnl_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnl_Show.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnl_Show.Location = new System.Drawing.Point(382, 259);
            this.lnl_Show.Name = "lnl_Show";
            this.lnl_Show.Size = new System.Drawing.Size(52, 21);
            this.lnl_Show.TabIndex = 3;
            this.lnl_Show.TabStop = true;
            this.lnl_Show.Text = "Show";
            this.lnl_Show.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnl_Show_LinkClicked);
            // 
            // lbl_Login1
            // 
            this.lbl_Login1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Login1.AutoSize = true;
            this.lbl_Login1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Login1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Login1.Location = new System.Drawing.Point(107, 7);
            this.lbl_Login1.Name = "lbl_Login1";
            this.lbl_Login1.Size = new System.Drawing.Size(272, 46);
            this.lbl_Login1.TabIndex = 2;
            this.lbl_Login1.Text = "Login Portal";
            this.lbl_Login1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Login1
            // 
            this.pnl_Login1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl_Login1.Controls.Add(this.button1);
            this.pnl_Login1.Controls.Add(this.lbl_Login1);
            this.pnl_Login1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Login1.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login1.Name = "pnl_Login1";
            this.pnl_Login1.Size = new System.Drawing.Size(492, 67);
            this.pnl_Login1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(460, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackgroundColor = System.Drawing.Color.White;
            this.btn_Login.ButtonImage = null;
            this.btn_Login.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.ClickBackColor = System.Drawing.Color.Black;
            this.btn_Login.ClickTextColor = System.Drawing.Color.Black;
            this.btn_Login.CornerRadius = 5;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Enabled = false;
            this.btn_Login.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Login.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btn_Login.HoverTextColor = System.Drawing.Color.White;
            this.btn_Login.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Login.Location = new System.Drawing.Point(164, 363);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(137, 50);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.TextColor = System.Drawing.Color.Black;
            this.btn_Login.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frm_Login_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(492, 479);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lnl_Show);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.pnl_Login1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Login_1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Login1.ResumeLayout(false);
            this.pnl_Login1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.LinkLabel lnl_Show;
        private System.Windows.Forms.Label lbl_Login1;
        private System.Windows.Forms.Panel pnl_Login1;
        private XanderUI.XUIButton btn_Login;
        private System.Windows.Forms.Button button1;
    }
}