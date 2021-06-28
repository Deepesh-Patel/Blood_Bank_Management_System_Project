namespace Blood_Bank_Management_System
{
    partial class frm_Update_Donor_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Update_Donor_Details));
            this.lbl_Update_Donor_Details = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_Dob = new System.Windows.Forms.DateTimePicker();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.tbp_Update_Search_Donor = new System.Windows.Forms.TabControl();
            this.tbp_Donor_Details_I = new System.Windows.Forms.TabPage();
            this.btn_Next = new System.Windows.Forms.Button();
            this.gb_Disease = new System.Windows.Forms.GroupBox();
            this.rd_btn_No = new System.Windows.Forms.RadioButton();
            this.rd_btn_Yes = new System.Windows.Forms.RadioButton();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rd_btn_Other = new System.Windows.Forms.RadioButton();
            this.rd_btn_Female = new System.Windows.Forms.RadioButton();
            this.rd_btn_Male = new System.Windows.Forms.RadioButton();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tb_Aadhar_Card = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Disease = new System.Windows.Forms.Label();
            this.lbl_Aadhar_Card = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Donor_ID = new System.Windows.Forms.TextBox();
            this.lbl_Donor_ID = new System.Windows.Forms.Label();
            this.tbp_Donor_Details_II = new System.Windows.Forms.TabPage();
            this.cmb_Blood_Group = new System.Windows.Forms.ComboBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lbl_Blood_Group = new System.Windows.Forms.Label();
            this.tb_Weight = new System.Windows.Forms.TextBox();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Blood_Donated = new System.Windows.Forms.TextBox();
            this.lbl_Blood_Quantity = new System.Windows.Forms.Label();
            this.rtb_Address = new System.Windows.Forms.RichTextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            this.tbp_Update_Search_Donor.SuspendLayout();
            this.tbp_Donor_Details_I.SuspendLayout();
            this.gb_Disease.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.tbp_Donor_Details_II.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Update_Donor_Details
            // 
            this.lbl_Update_Donor_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Update_Donor_Details.AutoSize = true;
            this.lbl_Update_Donor_Details.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Update_Donor_Details.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Donor_Details.Location = new System.Drawing.Point(540, 9);
            this.lbl_Update_Donor_Details.Name = "lbl_Update_Donor_Details";
            this.lbl_Update_Donor_Details.Size = new System.Drawing.Size(503, 50);
            this.lbl_Update_Donor_Details.TabIndex = 1;
            this.lbl_Update_Donor_Details.Text = "Update Donor Details";
            this.lbl_Update_Donor_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Snow;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(985, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 40);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_Dob
            // 
            this.dtp_Dob.Enabled = false;
            this.dtp_Dob.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Dob.Location = new System.Drawing.Point(279, 210);
            this.dtp_Dob.Name = "dtp_Dob";
            this.dtp_Dob.Size = new System.Drawing.Size(451, 29);
            this.dtp_Dob.TabIndex = 0;
            this.dtp_Dob.ValueChanged += new System.EventHandler(this.dtp_Dob_ValueChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Snow;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(902, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 44);
            this.btn_Close.TabIndex = 11;
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
            this.btn_Refresh.Location = new System.Drawing.Point(532, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(145, 44);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Snow;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(724, 16);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(133, 44);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Gold;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Brown;
            this.xuiGradientPanel1.Controls.Add(this.lbl_Update_Donor_Details);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 64;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Brown;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Gold;
            this.xuiGradientPanel2.Controls.Add(this.btn_Close);
            this.xuiGradientPanel2.Controls.Add(this.btn_Refresh);
            this.xuiGradientPanel2.Controls.Add(this.btn_Update);
            this.xuiGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiGradientPanel2.Location = new System.Drawing.Point(0, 708);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 66;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // tbp_Update_Search_Donor
            // 
            this.tbp_Update_Search_Donor.Controls.Add(this.tbp_Donor_Details_I);
            this.tbp_Update_Search_Donor.Controls.Add(this.tbp_Donor_Details_II);
            this.tbp_Update_Search_Donor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbp_Update_Search_Donor.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp_Update_Search_Donor.Location = new System.Drawing.Point(0, 72);
            this.tbp_Update_Search_Donor.Name = "tbp_Update_Search_Donor";
            this.tbp_Update_Search_Donor.SelectedIndex = 0;
            this.tbp_Update_Search_Donor.Size = new System.Drawing.Size(1566, 630);
            this.tbp_Update_Search_Donor.TabIndex = 67;
            // 
            // tbp_Donor_Details_I
            // 
            this.tbp_Donor_Details_I.BackColor = System.Drawing.Color.Bisque;
            this.tbp_Donor_Details_I.Controls.Add(this.btn_Next);
            this.tbp_Donor_Details_I.Controls.Add(this.gb_Disease);
            this.tbp_Donor_Details_I.Controls.Add(this.tb_Age);
            this.tbp_Donor_Details_I.Controls.Add(this.lbl_Age);
            this.tbp_Donor_Details_I.Controls.Add(this.btn_Search);
            this.tbp_Donor_Details_I.Controls.Add(this.gb_Gender);
            this.tbp_Donor_Details_I.Controls.Add(this.dtp_Dob);
            this.tbp_Donor_Details_I.Controls.Add(this.tb_Email);
            this.tbp_Donor_Details_I.Controls.Add(this.lbl_Email);
            this.tbp_Donor_Details_I.Controls.Add(this.tb_Aadhar_Card);
            this.tbp_Donor_Details_I.Controls.Add(this.tb_Mob_No);
            this.tbp_Donor_Details_I.Controls.Add(this.tb_Name);
            this.tbp_Donor_Details_I.Controls.Add(this.lbl_Disease);
            this.tbp_Donor_Details_I.Controls.Add(this.lbl_Aadhar_Card);
            this.tbp_Donor_Details_I.Controls.Add(this.lbl_Gender);
            this.tbp_Donor_Details_I.Controls.Add(this.lbl_Mob_No);
            this.tbp_Donor_Details_I.Controls.Add(this.lbl_DOB);
            this.tbp_Donor_Details_I.Controls.Add(this.lbl_Name);
            this.tbp_Donor_Details_I.Controls.Add(this.tb_Donor_ID);
            this.tbp_Donor_Details_I.Controls.Add(this.lbl_Donor_ID);
            this.tbp_Donor_Details_I.Location = new System.Drawing.Point(4, 31);
            this.tbp_Donor_Details_I.Name = "tbp_Donor_Details_I";
            this.tbp_Donor_Details_I.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Donor_Details_I.Size = new System.Drawing.Size(1558, 595);
            this.tbp_Donor_Details_I.TabIndex = 0;
            this.tbp_Donor_Details_I.Text = "Donor Details I";
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.BackColor = System.Drawing.Color.Snow;
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Next.Image")));
            this.btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Next.Location = new System.Drawing.Point(1442, 539);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(116, 53);
            this.btn_Next.TabIndex = 93;
            this.btn_Next.Text = "Next";
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // gb_Disease
            // 
            this.gb_Disease.Controls.Add(this.rd_btn_No);
            this.gb_Disease.Controls.Add(this.rd_btn_Yes);
            this.gb_Disease.Enabled = false;
            this.gb_Disease.Location = new System.Drawing.Point(1024, 439);
            this.gb_Disease.Name = "gb_Disease";
            this.gb_Disease.Size = new System.Drawing.Size(451, 64);
            this.gb_Disease.TabIndex = 92;
            this.gb_Disease.TabStop = false;
            // 
            // rd_btn_No
            // 
            this.rd_btn_No.AutoSize = true;
            this.rd_btn_No.Enabled = false;
            this.rd_btn_No.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_No.Location = new System.Drawing.Point(342, 27);
            this.rd_btn_No.Name = "rd_btn_No";
            this.rd_btn_No.Size = new System.Drawing.Size(52, 24);
            this.rd_btn_No.TabIndex = 5;
            this.rd_btn_No.TabStop = true;
            this.rd_btn_No.Text = "No";
            this.rd_btn_No.UseVisualStyleBackColor = true;
            // 
            // rd_btn_Yes
            // 
            this.rd_btn_Yes.AutoSize = true;
            this.rd_btn_Yes.Enabled = false;
            this.rd_btn_Yes.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Yes.Location = new System.Drawing.Point(54, 26);
            this.rd_btn_Yes.Name = "rd_btn_Yes";
            this.rd_btn_Yes.Size = new System.Drawing.Size(58, 24);
            this.rd_btn_Yes.TabIndex = 5;
            this.rd_btn_Yes.TabStop = true;
            this.rd_btn_Yes.Text = "Yes";
            this.rd_btn_Yes.UseVisualStyleBackColor = true;
            // 
            // tb_Age
            // 
            this.tb_Age.Enabled = false;
            this.tb_Age.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Age.Location = new System.Drawing.Point(1024, 337);
            this.tb_Age.MaxLength = 30;
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(451, 29);
            this.tb_Age.TabIndex = 72;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Age.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(830, 337);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(55, 27);
            this.lbl_Age.TabIndex = 91;
            this.lbl_Age.Text = "Age";
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rd_btn_Other);
            this.gb_Gender.Controls.Add(this.rd_btn_Female);
            this.gb_Gender.Controls.Add(this.rd_btn_Male);
            this.gb_Gender.Enabled = false;
            this.gb_Gender.Location = new System.Drawing.Point(279, 439);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(451, 64);
            this.gb_Gender.TabIndex = 68;
            this.gb_Gender.TabStop = false;
            // 
            // rd_btn_Other
            // 
            this.rd_btn_Other.AutoSize = true;
            this.rd_btn_Other.Enabled = false;
            this.rd_btn_Other.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Other.Location = new System.Drawing.Point(348, 21);
            this.rd_btn_Other.Name = "rd_btn_Other";
            this.rd_btn_Other.Size = new System.Drawing.Size(74, 24);
            this.rd_btn_Other.TabIndex = 43;
            this.rd_btn_Other.TabStop = true;
            this.rd_btn_Other.Text = "Other";
            this.rd_btn_Other.UseVisualStyleBackColor = true;
            // 
            // rd_btn_Female
            // 
            this.rd_btn_Female.AutoSize = true;
            this.rd_btn_Female.Enabled = false;
            this.rd_btn_Female.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Female.Location = new System.Drawing.Point(172, 21);
            this.rd_btn_Female.Name = "rd_btn_Female";
            this.rd_btn_Female.Size = new System.Drawing.Size(87, 24);
            this.rd_btn_Female.TabIndex = 41;
            this.rd_btn_Female.TabStop = true;
            this.rd_btn_Female.Text = "Female";
            this.rd_btn_Female.UseVisualStyleBackColor = true;
            // 
            // rd_btn_Male
            // 
            this.rd_btn_Male.AutoSize = true;
            this.rd_btn_Male.Enabled = false;
            this.rd_btn_Male.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Male.Location = new System.Drawing.Point(19, 21);
            this.rd_btn_Male.Name = "rd_btn_Male";
            this.rd_btn_Male.Size = new System.Drawing.Size(69, 24);
            this.rd_btn_Male.TabIndex = 40;
            this.rd_btn_Male.TabStop = true;
            this.rd_btn_Male.Text = "Male";
            this.rd_btn_Male.UseVisualStyleBackColor = true;
            // 
            // tb_Email
            // 
            this.tb_Email.Enabled = false;
            this.tb_Email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(1024, 225);
            this.tb_Email.MaxLength = 30;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(451, 29);
            this.tb_Email.TabIndex = 5;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(823, 226);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(81, 27);
            this.lbl_Email.TabIndex = 80;
            this.lbl_Email.Text = "Email";
            // 
            // tb_Aadhar_Card
            // 
            this.tb_Aadhar_Card.Enabled = false;
            this.tb_Aadhar_Card.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_Card.Location = new System.Drawing.Point(1024, 106);
            this.tb_Aadhar_Card.MaxLength = 15;
            this.tb_Aadhar_Card.Name = "tb_Aadhar_Card";
            this.tb_Aadhar_Card.Size = new System.Drawing.Size(451, 29);
            this.tb_Aadhar_Card.TabIndex = 4;
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Enabled = false;
            this.tb_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(279, 337);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(451, 29);
            this.tb_Mob_No.TabIndex = 3;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(279, 106);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(451, 29);
            this.tb_Name.TabIndex = 70;
            // 
            // lbl_Disease
            // 
            this.lbl_Disease.AutoSize = true;
            this.lbl_Disease.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Disease.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Disease.Location = new System.Drawing.Point(830, 463);
            this.lbl_Disease.Name = "lbl_Disease";
            this.lbl_Disease.Size = new System.Drawing.Size(99, 27);
            this.lbl_Disease.TabIndex = 83;
            this.lbl_Disease.Text = "Disease";
            // 
            // lbl_Aadhar_Card
            // 
            this.lbl_Aadhar_Card.AutoSize = true;
            this.lbl_Aadhar_Card.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Aadhar_Card.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_Card.Location = new System.Drawing.Point(823, 107);
            this.lbl_Aadhar_Card.Name = "lbl_Aadhar_Card";
            this.lbl_Aadhar_Card.Size = new System.Drawing.Size(165, 27);
            this.lbl_Aadhar_Card.TabIndex = 84;
            this.lbl_Aadhar_Card.Text = "Aadhar Card";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gender.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(78, 460);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(96, 27);
            this.lbl_Gender.TabIndex = 89;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.Location = new System.Drawing.Point(78, 342);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(108, 27);
            this.lbl_Mob_No.TabIndex = 86;
            this.lbl_Mob_No.Text = "Mob No.";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DOB.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(78, 212);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(165, 27);
            this.lbl_DOB.TabIndex = 85;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(78, 106);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(79, 27);
            this.lbl_Name.TabIndex = 87;
            this.lbl_Name.Text = "Name";
            // 
            // tb_Donor_ID
            // 
            this.tb_Donor_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Donor_ID.Location = new System.Drawing.Point(596, 17);
            this.tb_Donor_ID.MaxLength = 30;
            this.tb_Donor_ID.Name = "tb_Donor_ID";
            this.tb_Donor_ID.Size = new System.Drawing.Size(359, 29);
            this.tb_Donor_ID.TabIndex = 1;
            // 
            // lbl_Donor_ID
            // 
            this.lbl_Donor_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Donor_ID.Font = new System.Drawing.Font("Georgia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Donor_ID.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Donor_ID.Image")));
            this.lbl_Donor_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Donor_ID.Location = new System.Drawing.Point(369, 18);
            this.lbl_Donor_ID.Name = "lbl_Donor_ID";
            this.lbl_Donor_ID.Size = new System.Drawing.Size(177, 27);
            this.lbl_Donor_ID.TabIndex = 79;
            this.lbl_Donor_ID.Text = "Donor ID";
            this.lbl_Donor_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbp_Donor_Details_II
            // 
            this.tbp_Donor_Details_II.BackColor = System.Drawing.Color.Bisque;
            this.tbp_Donor_Details_II.Controls.Add(this.cmb_Blood_Group);
            this.tbp_Donor_Details_II.Controls.Add(this.lbl_Weight);
            this.tbp_Donor_Details_II.Controls.Add(this.lbl_Blood_Group);
            this.tbp_Donor_Details_II.Controls.Add(this.tb_Weight);
            this.tbp_Donor_Details_II.Controls.Add(this.btn_Previous);
            this.tbp_Donor_Details_II.Controls.Add(this.dtp_Date);
            this.tbp_Donor_Details_II.Controls.Add(this.lbl_Date);
            this.tbp_Donor_Details_II.Controls.Add(this.tb_Blood_Donated);
            this.tbp_Donor_Details_II.Controls.Add(this.lbl_Blood_Quantity);
            this.tbp_Donor_Details_II.Controls.Add(this.rtb_Address);
            this.tbp_Donor_Details_II.Controls.Add(this.tb_City);
            this.tbp_Donor_Details_II.Controls.Add(this.lbl_Address);
            this.tbp_Donor_Details_II.Controls.Add(this.lbl_City);
            this.tbp_Donor_Details_II.Location = new System.Drawing.Point(4, 31);
            this.tbp_Donor_Details_II.Name = "tbp_Donor_Details_II";
            this.tbp_Donor_Details_II.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Donor_Details_II.Size = new System.Drawing.Size(1558, 595);
            this.tbp_Donor_Details_II.TabIndex = 1;
            this.tbp_Donor_Details_II.Text = "Donor Details II";
            // 
            // cmb_Blood_Group
            // 
            this.cmb_Blood_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Blood_Group.Enabled = false;
            this.cmb_Blood_Group.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Blood_Group.FormattingEnabled = true;
            this.cmb_Blood_Group.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.cmb_Blood_Group.Location = new System.Drawing.Point(1030, 93);
            this.cmb_Blood_Group.Name = "cmb_Blood_Group";
            this.cmb_Blood_Group.Size = new System.Drawing.Size(451, 30);
            this.cmb_Blood_Group.TabIndex = 101;
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Weight.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weight.Location = new System.Drawing.Point(79, 96);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(95, 27);
            this.lbl_Weight.TabIndex = 104;
            this.lbl_Weight.Text = "Weight";
            // 
            // lbl_Blood_Group
            // 
            this.lbl_Blood_Group.AutoSize = true;
            this.lbl_Blood_Group.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Blood_Group.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Group.Location = new System.Drawing.Point(846, 93);
            this.lbl_Blood_Group.Name = "lbl_Blood_Group";
            this.lbl_Blood_Group.Size = new System.Drawing.Size(160, 27);
            this.lbl_Blood_Group.TabIndex = 103;
            this.lbl_Blood_Group.Text = "Blood Group";
            // 
            // tb_Weight
            // 
            this.tb_Weight.Enabled = false;
            this.tb_Weight.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Weight.Location = new System.Drawing.Point(348, 96);
            this.tb_Weight.MaxLength = 10;
            this.tb_Weight.Name = "tb_Weight";
            this.tb_Weight.Size = new System.Drawing.Size(354, 29);
            this.tb_Weight.TabIndex = 6;
            // 
            // btn_Previous
            // 
            this.btn_Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Previous.BackColor = System.Drawing.Color.Snow;
            this.btn_Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Previous.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_Previous.Image")));
            this.btn_Previous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Previous.Location = new System.Drawing.Point(28, 526);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(167, 53);
            this.btn_Previous.TabIndex = 99;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1030, 387);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(451, 29);
            this.dtp_Date.TabIndex = 96;
            this.dtp_Date.Visible = false;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(846, 385);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(72, 27);
            this.lbl_Date.TabIndex = 98;
            this.lbl_Date.Text = "Date ";
            this.lbl_Date.Visible = false;
            // 
            // tb_Blood_Donated
            // 
            this.tb_Blood_Donated.Enabled = false;
            this.tb_Blood_Donated.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Blood_Donated.Location = new System.Drawing.Point(348, 389);
            this.tb_Blood_Donated.MaxLength = 10;
            this.tb_Blood_Donated.Name = "tb_Blood_Donated";
            this.tb_Blood_Donated.Size = new System.Drawing.Size(354, 29);
            this.tb_Blood_Donated.TabIndex = 95;
            this.tb_Blood_Donated.Visible = false;
            // 
            // lbl_Blood_Quantity
            // 
            this.lbl_Blood_Quantity.AutoSize = true;
            this.lbl_Blood_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Blood_Quantity.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Quantity.Location = new System.Drawing.Point(79, 385);
            this.lbl_Blood_Quantity.Name = "lbl_Blood_Quantity";
            this.lbl_Blood_Quantity.Size = new System.Drawing.Size(234, 54);
            this.lbl_Blood_Quantity.TabIndex = 97;
            this.lbl_Blood_Quantity.Text = "Blood Donated\r\n(Quantity In Units)";
            this.lbl_Blood_Quantity.Visible = false;
            // 
            // rtb_Address
            // 
            this.rtb_Address.Enabled = false;
            this.rtb_Address.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Address.Location = new System.Drawing.Point(1030, 210);
            this.rtb_Address.MaxLength = 30;
            this.rtb_Address.Name = "rtb_Address";
            this.rtb_Address.Size = new System.Drawing.Size(451, 93);
            this.rtb_Address.TabIndex = 8;
            this.rtb_Address.Text = "";
            // 
            // tb_City
            // 
            this.tb_City.Enabled = false;
            this.tb_City.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_City.Location = new System.Drawing.Point(348, 214);
            this.tb_City.MaxLength = 20;
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(354, 29);
            this.tb_City.TabIndex = 7;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(846, 210);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(105, 27);
            this.lbl_Address.TabIndex = 94;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.Color.Transparent;
            this.lbl_City.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(79, 214);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(60, 27);
            this.lbl_City.TabIndex = 93;
            this.lbl_City.Text = "City";
            // 
            // frm_Update_Donor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1566, 780);
            this.ControlBox = false;
            this.Controls.Add(this.tbp_Update_Search_Donor);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Update_Donor_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Update_Donor_Details_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.tbp_Update_Search_Donor.ResumeLayout(false);
            this.tbp_Donor_Details_I.ResumeLayout(false);
            this.tbp_Donor_Details_I.PerformLayout();
            this.gb_Disease.ResumeLayout(false);
            this.gb_Disease.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.tbp_Donor_Details_II.ResumeLayout(false);
            this.tbp_Donor_Details_II.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Update_Donor_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_Dob;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private System.Windows.Forms.TabControl tbp_Update_Search_Donor;
        private System.Windows.Forms.TabPage tbp_Donor_Details_I;
        private System.Windows.Forms.TabPage tbp_Donor_Details_II;
        private System.Windows.Forms.GroupBox gb_Disease;
        private System.Windows.Forms.RadioButton rd_btn_No;
        private System.Windows.Forms.RadioButton rd_btn_Yes;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rd_btn_Other;
        private System.Windows.Forms.RadioButton rd_btn_Female;
        private System.Windows.Forms.RadioButton rd_btn_Male;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tb_Aadhar_Card;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Disease;
        private System.Windows.Forms.Label lbl_Aadhar_Card;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Donor_ID;
        private System.Windows.Forms.Label lbl_Donor_ID;
        private System.Windows.Forms.RichTextBox rtb_Address;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Blood_Donated;
        private System.Windows.Forms.Label lbl_Blood_Quantity;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.ComboBox cmb_Blood_Group;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lbl_Blood_Group;
        private System.Windows.Forms.TextBox tb_Weight;
    }
}