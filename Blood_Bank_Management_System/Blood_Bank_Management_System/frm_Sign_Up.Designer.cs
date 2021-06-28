namespace Blood_Bank_Management_System
{
    partial class frm_Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sign_Up));
            this.pnl_Login1 = new System.Windows.Forms.Panel();
            this.lbl_Sign_Up = new System.Windows.Forms.Label();
            this.btn_Save = new XanderUI.XUIButton();
            this.lnl_Show = new System.Windows.Forms.LinkLabel();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_Login1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Login1
            // 
            this.pnl_Login1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl_Login1.Controls.Add(this.button1);
            this.pnl_Login1.Controls.Add(this.lbl_Sign_Up);
            this.pnl_Login1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Login1.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login1.Name = "pnl_Login1";
            this.pnl_Login1.Size = new System.Drawing.Size(492, 67);
            this.pnl_Login1.TabIndex = 1;
            // 
            // lbl_Sign_Up
            // 
            this.lbl_Sign_Up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sign_Up.AutoSize = true;
            this.lbl_Sign_Up.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sign_Up.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sign_Up.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Sign_Up.Location = new System.Drawing.Point(149, 9);
            this.lbl_Sign_Up.Name = "lbl_Sign_Up";
            this.lbl_Sign_Up.Size = new System.Drawing.Size(180, 46);
            this.lbl_Sign_Up.TabIndex = 2;
            this.lbl_Sign_Up.Text = "Sign Up";
            this.lbl_Sign_Up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundColor = System.Drawing.Color.White;
            this.btn_Save.ButtonImage = null;
            this.btn_Save.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.ClickBackColor = System.Drawing.Color.Black;
            this.btn_Save.ClickTextColor = System.Drawing.Color.Black;
            this.btn_Save.CornerRadius = 5;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Save.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btn_Save.HoverTextColor = System.Drawing.Color.White;
            this.btn_Save.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Save.Location = new System.Drawing.Point(164, 363);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 50);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.TextColor = System.Drawing.Color.Black;
            this.btn_Save.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lnl_Show
            // 
            this.lnl_Show.AutoSize = true;
            this.lnl_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnl_Show.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnl_Show.Location = new System.Drawing.Point(381, 260);
            this.lnl_Show.Name = "lnl_Show";
            this.lnl_Show.Size = new System.Drawing.Size(52, 21);
            this.lnl_Show.TabIndex = 21;
            this.lnl_Show.TabStop = true;
            this.lnl_Show.Text = "Show";
            this.lnl_Show.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnl_Show_LinkClicked);
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
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Password.Image")));
            this.lbl_Password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Password.Location = new System.Drawing.Point(57, 239);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(255, 41);
            this.lbl_Password.TabIndex = 18;
            this.lbl_Password.Text = "Confirm Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lbl_Username.Size = new System.Drawing.Size(160, 41);
            this.lbl_Username.TabIndex = 19;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(460, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(492, 479);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lnl_Show);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.pnl_Login1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Sign_Up";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Login1.ResumeLayout(false);
            this.pnl_Login1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login1;
        private System.Windows.Forms.Label lbl_Sign_Up;
        private XanderUI.XUIButton btn_Save;
        private System.Windows.Forms.LinkLabel lnl_Show;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button button1;
    }
}