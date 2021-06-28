namespace Blood_Bank_Management_System
{
    partial class frm_Add_New_Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Hospital));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Hospital_ID = new System.Windows.Forms.Label();
            this.lbl_Hospital_Name = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.rtb_Address = new System.Windows.Forms.RichTextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Contact_No_I = new System.Windows.Forms.Label();
            this.tb_Contact_No_I = new System.Windows.Forms.TextBox();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.btn_Refresh1 = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_Contact_No_II = new System.Windows.Forms.TextBox();
            this.lbl_Contact_No_II = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(526, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(430, 50);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Add New Hospital";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Hospital_ID
            // 
            this.lbl_Hospital_ID.AutoSize = true;
            this.lbl_Hospital_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hospital_ID.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hospital_ID.Location = new System.Drawing.Point(44, 117);
            this.lbl_Hospital_ID.Name = "lbl_Hospital_ID";
            this.lbl_Hospital_ID.Size = new System.Drawing.Size(146, 27);
            this.lbl_Hospital_ID.TabIndex = 23;
            this.lbl_Hospital_ID.Text = "Hospital ID";
            // 
            // lbl_Hospital_Name
            // 
            this.lbl_Hospital_Name.AutoSize = true;
            this.lbl_Hospital_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hospital_Name.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hospital_Name.Location = new System.Drawing.Point(823, 117);
            this.lbl_Hospital_Name.Name = "lbl_Hospital_Name";
            this.lbl_Hospital_Name.Size = new System.Drawing.Size(185, 27);
            this.lbl_Hospital_Name.TabIndex = 23;
            this.lbl_Hospital_Name.Text = "Hospital Name";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.Color.Transparent;
            this.lbl_City.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(44, 439);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(60, 27);
            this.lbl_City.TabIndex = 23;
            this.lbl_City.Text = "City";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(823, 439);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(105, 27);
            this.lbl_Address.TabIndex = 23;
            this.lbl_Address.Text = "Address";
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(1096, 117);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(422, 29);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_City
            // 
            this.tb_City.Enabled = false;
            this.tb_City.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_City.Location = new System.Drawing.Point(317, 439);
            this.tb_City.MaxLength = 20;
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(422, 29);
            this.tb_City.TabIndex = 4;
            this.tb_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // rtb_Address
            // 
            this.rtb_Address.Enabled = false;
            this.rtb_Address.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Address.Location = new System.Drawing.Point(1096, 439);
            this.rtb_Address.MaxLength = 90;
            this.rtb_Address.Name = "rtb_Address";
            this.rtb_Address.Size = new System.Drawing.Size(422, 163);
            this.rtb_Address.TabIndex = 5;
            this.rtb_Address.Text = "";
            this.rtb_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char_Special_character);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Snow;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(924, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 44);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Close";
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Snow;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.Location = new System.Drawing.Point(733, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(145, 44);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Visible = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Snow;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(558, 16);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(109, 44);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Contact_No_I
            // 
            this.lbl_Contact_No_I.AutoSize = true;
            this.lbl_Contact_No_I.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Contact_No_I.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact_No_I.Location = new System.Drawing.Point(44, 303);
            this.lbl_Contact_No_I.Name = "lbl_Contact_No_I";
            this.lbl_Contact_No_I.Size = new System.Drawing.Size(163, 27);
            this.lbl_Contact_No_I.TabIndex = 23;
            this.lbl_Contact_No_I.Text = "Contact No. I";
            // 
            // tb_Contact_No_I
            // 
            this.tb_Contact_No_I.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contact_No_I.Location = new System.Drawing.Point(317, 303);
            this.tb_Contact_No_I.MaxLength = 10;
            this.tb_Contact_No_I.Name = "tb_Contact_No_I";
            this.tb_Contact_No_I.Size = new System.Drawing.Size(422, 29);
            this.tb_Contact_No_I.TabIndex = 2;
            this.tb_Contact_No_I.TextChanged += new System.EventHandler(this.tb_Contact_No_I_TextChanged);
            this.tb_Contact_No_I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Gold;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Brown;
            this.xuiGradientPanel1.Controls.Add(this.lbl_Header);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 44;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Brown;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Gold;
            this.xuiGradientPanel2.Controls.Add(this.btn_Refresh1);
            this.xuiGradientPanel2.Controls.Add(this.btn_Update);
            this.xuiGradientPanel2.Controls.Add(this.btn_Close);
            this.xuiGradientPanel2.Controls.Add(this.btn_Refresh);
            this.xuiGradientPanel2.Controls.Add(this.btn_Save);
            this.xuiGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiGradientPanel2.Location = new System.Drawing.Point(0, 668);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 66;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // btn_Refresh1
            // 
            this.btn_Refresh1.BackColor = System.Drawing.Color.Snow;
            this.btn_Refresh1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh1.Image")));
            this.btn_Refresh1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh1.Location = new System.Drawing.Point(733, 16);
            this.btn_Refresh1.Name = "btn_Refresh1";
            this.btn_Refresh1.Size = new System.Drawing.Size(145, 44);
            this.btn_Refresh1.TabIndex = 7;
            this.btn_Refresh1.Text = "Refresh";
            this.btn_Refresh1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh1.UseVisualStyleBackColor = false;
            this.btn_Refresh1.Visible = false;
            this.btn_Refresh1.Click += new System.EventHandler(this.btn_Refresh1_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Snow;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(546, 16);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(133, 44);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_Contact_No_II
            // 
            this.tb_Contact_No_II.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contact_No_II.Location = new System.Drawing.Point(1096, 301);
            this.tb_Contact_No_II.MaxLength = 10;
            this.tb_Contact_No_II.Name = "tb_Contact_No_II";
            this.tb_Contact_No_II.Size = new System.Drawing.Size(422, 29);
            this.tb_Contact_No_II.TabIndex = 3;
            this.tb_Contact_No_II.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric1);
            // 
            // lbl_Contact_No_II
            // 
            this.lbl_Contact_No_II.AutoSize = true;
            this.lbl_Contact_No_II.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Contact_No_II.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact_No_II.Location = new System.Drawing.Point(823, 301);
            this.lbl_Contact_No_II.Name = "lbl_Contact_No_II";
            this.lbl_Contact_No_II.Size = new System.Drawing.Size(173, 27);
            this.lbl_Contact_No_II.TabIndex = 23;
            this.lbl_Contact_No_II.Text = "Contact No. II";
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(317, 117);
            this.tb_ID.MaxLength = 10;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(254, 29);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_Contact_No_I_TextChanged);
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Snow;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(611, 109);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 40);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(321, 573);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(418, 29);
            this.dtp_Date.TabIndex = 68;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(44, 575);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(72, 27);
            this.lbl_Date.TabIndex = 69;
            this.lbl_Date.Text = "Date ";
            // 
            // frm_Add_New_Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1566, 740);
            this.ControlBox = false;
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.rtb_Address);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.tb_Contact_No_II);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_Contact_No_I);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Contact_No_II);
            this.Controls.Add(this.lbl_Contact_No_I);
            this.Controls.Add(this.lbl_Hospital_Name);
            this.Controls.Add(this.lbl_Hospital_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Add_New_Hospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Add_New_Hospital_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Hospital_ID;
        private System.Windows.Forms.Label lbl_Hospital_Name;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.RichTextBox rtb_Address;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Contact_No_I;
        private System.Windows.Forms.TextBox tb_Contact_No_I;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private System.Windows.Forms.TextBox tb_Contact_No_II;
        private System.Windows.Forms.Label lbl_Contact_No_II;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh1;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
    }
}