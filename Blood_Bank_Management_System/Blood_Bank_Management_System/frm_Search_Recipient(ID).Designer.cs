namespace Blood_Bank_Management_System
{
    partial class frm_Search_Recipient_ID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Search_Recipient_ID));
            this.lbl_Search_Recipient = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.rtb_Address = new System.Windows.Forms.RichTextBox();
            this.cmb_Blood_Group = new System.Windows.Forms.ComboBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lbl_Blood_Group = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.dtp_Dob = new System.Windows.Forms.DateTimePicker();
            this.tb_Weight = new System.Windows.Forms.TextBox();
            this.tb_Aadhar_Card = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Recipient_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Aadhar_Card = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Recipient_Name = new System.Windows.Forms.Label();
            this.lbl_Recipient_ID = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rd_btn_Other = new System.Windows.Forms.RadioButton();
            this.rd_btn_Female = new System.Windows.Forms.RadioButton();
            this.rd_btn_Male = new System.Windows.Forms.RadioButton();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.gb_Gender.SuspendLayout();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Search_Recipient
            // 
            this.lbl_Search_Recipient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Search_Recipient.AutoSize = true;
            this.lbl_Search_Recipient.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Search_Recipient.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Recipient.Location = new System.Drawing.Point(553, 9);
            this.lbl_Search_Recipient.Name = "lbl_Search_Recipient";
            this.lbl_Search_Recipient.Size = new System.Drawing.Size(400, 50);
            this.lbl_Search_Recipient.TabIndex = 1;
            this.lbl_Search_Recipient.Text = "Search Recipient";
            this.lbl_Search_Recipient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Snow;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(1052, 90);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 40);
            this.btn_Search.TabIndex = 76;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // rtb_Address
            // 
            this.rtb_Address.Enabled = false;
            this.rtb_Address.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Address.Location = new System.Drawing.Point(1052, 424);
            this.rtb_Address.MaxLength = 30;
            this.rtb_Address.Name = "rtb_Address";
            this.rtb_Address.Size = new System.Drawing.Size(475, 109);
            this.rtb_Address.TabIndex = 64;
            this.rtb_Address.Text = "";
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
            this.cmb_Blood_Group.Location = new System.Drawing.Point(1052, 171);
            this.cmb_Blood_Group.Name = "cmb_Blood_Group";
            this.cmb_Blood_Group.Size = new System.Drawing.Size(475, 30);
            this.cmb_Blood_Group.TabIndex = 61;
            // 
            // tb_City
            // 
            this.tb_City.Enabled = false;
            this.tb_City.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_City.Location = new System.Drawing.Point(1052, 333);
            this.tb_City.MaxLength = 20;
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(475, 29);
            this.tb_City.TabIndex = 63;
            // 
            // tb_Email
            // 
            this.tb_Email.Enabled = false;
            this.tb_Email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(1052, 586);
            this.tb_Email.MaxLength = 30;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(475, 29);
            this.tb_Email.TabIndex = 60;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(826, 424);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(105, 27);
            this.lbl_Address.TabIndex = 75;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.Color.Transparent;
            this.lbl_City.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(826, 335);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(60, 27);
            this.lbl_City.TabIndex = 73;
            this.lbl_City.Text = "City";
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Weight.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weight.Location = new System.Drawing.Point(826, 254);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(95, 27);
            this.lbl_Weight.TabIndex = 67;
            this.lbl_Weight.Text = "Weight";
            // 
            // lbl_Blood_Group
            // 
            this.lbl_Blood_Group.AutoSize = true;
            this.lbl_Blood_Group.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Blood_Group.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Group.Location = new System.Drawing.Point(826, 174);
            this.lbl_Blood_Group.Name = "lbl_Blood_Group";
            this.lbl_Blood_Group.Size = new System.Drawing.Size(160, 27);
            this.lbl_Blood_Group.TabIndex = 66;
            this.lbl_Blood_Group.Text = "Blood Group";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(826, 586);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(81, 27);
            this.lbl_Email.TabIndex = 65;
            this.lbl_Email.Text = "Email";
            // 
            // dtp_Dob
            // 
            this.dtp_Dob.Enabled = false;
            this.dtp_Dob.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Dob.Location = new System.Drawing.Point(260, 254);
            this.dtp_Dob.Name = "dtp_Dob";
            this.dtp_Dob.Size = new System.Drawing.Size(475, 29);
            this.dtp_Dob.TabIndex = 56;
            // 
            // tb_Weight
            // 
            this.tb_Weight.Enabled = false;
            this.tb_Weight.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Weight.Location = new System.Drawing.Point(1052, 252);
            this.tb_Weight.MaxLength = 10;
            this.tb_Weight.Name = "tb_Weight";
            this.tb_Weight.Size = new System.Drawing.Size(475, 29);
            this.tb_Weight.TabIndex = 62;
            // 
            // tb_Aadhar_Card
            // 
            this.tb_Aadhar_Card.Enabled = false;
            this.tb_Aadhar_Card.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_Card.Location = new System.Drawing.Point(260, 506);
            this.tb_Aadhar_Card.MaxLength = 15;
            this.tb_Aadhar_Card.Name = "tb_Aadhar_Card";
            this.tb_Aadhar_Card.Size = new System.Drawing.Size(475, 29);
            this.tb_Aadhar_Card.TabIndex = 59;
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Enabled = false;
            this.tb_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(260, 337);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(475, 29);
            this.tb_Mob_No.TabIndex = 57;
            // 
            // tb_Recipient_ID
            // 
            this.tb_Recipient_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Recipient_ID.Location = new System.Drawing.Point(531, 101);
            this.tb_Recipient_ID.MaxLength = 30;
            this.tb_Recipient_ID.Name = "tb_Recipient_ID";
            this.tb_Recipient_ID.Size = new System.Drawing.Size(475, 29);
            this.tb_Recipient_ID.TabIndex = 54;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(260, 176);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(475, 29);
            this.tb_Name.TabIndex = 55;
            // 
            // lbl_Aadhar_Card
            // 
            this.lbl_Aadhar_Card.AutoSize = true;
            this.lbl_Aadhar_Card.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Aadhar_Card.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_Card.Location = new System.Drawing.Point(35, 506);
            this.lbl_Aadhar_Card.Name = "lbl_Aadhar_Card";
            this.lbl_Aadhar_Card.Size = new System.Drawing.Size(165, 27);
            this.lbl_Aadhar_Card.TabIndex = 68;
            this.lbl_Aadhar_Card.Text = "Aadhar Card";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gender.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(35, 426);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(96, 27);
            this.lbl_Gender.TabIndex = 74;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.Location = new System.Drawing.Point(35, 337);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(108, 27);
            this.lbl_Mob_No.TabIndex = 70;
            this.lbl_Mob_No.Text = "Mob No.";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DOB.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(35, 256);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(165, 27);
            this.lbl_DOB.TabIndex = 69;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Recipient_Name
            // 
            this.lbl_Recipient_Name.AutoSize = true;
            this.lbl_Recipient_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Recipient_Name.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recipient_Name.Location = new System.Drawing.Point(35, 176);
            this.lbl_Recipient_Name.Name = "lbl_Recipient_Name";
            this.lbl_Recipient_Name.Size = new System.Drawing.Size(79, 27);
            this.lbl_Recipient_Name.TabIndex = 72;
            this.lbl_Recipient_Name.Text = "Name";
            // 
            // lbl_Recipient_ID
            // 
            this.lbl_Recipient_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Recipient_ID.Font = new System.Drawing.Font("Georgia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recipient_ID.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Recipient_ID.Image")));
            this.lbl_Recipient_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Recipient_ID.Location = new System.Drawing.Point(279, 101);
            this.lbl_Recipient_ID.Name = "lbl_Recipient_ID";
            this.lbl_Recipient_ID.Size = new System.Drawing.Size(214, 27);
            this.lbl_Recipient_ID.TabIndex = 71;
            this.lbl_Recipient_ID.Text = "Recipient ID";
            this.lbl_Recipient_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Snow;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(901, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 44);
            this.btn_Close.TabIndex = 14;
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
            this.btn_Refresh.Location = new System.Drawing.Point(700, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(145, 44);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Snow;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(535, 16);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(109, 44);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rd_btn_Other);
            this.gb_Gender.Controls.Add(this.rd_btn_Female);
            this.gb_Gender.Controls.Add(this.rd_btn_Male);
            this.gb_Gender.Location = new System.Drawing.Point(260, 405);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(475, 64);
            this.gb_Gender.TabIndex = 78;
            this.gb_Gender.TabStop = false;
            // 
            // rd_btn_Other
            // 
            this.rd_btn_Other.AutoSize = true;
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
            this.rd_btn_Male.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Male.Location = new System.Drawing.Point(19, 21);
            this.rd_btn_Male.Name = "rd_btn_Male";
            this.rd_btn_Male.Size = new System.Drawing.Size(69, 24);
            this.rd_btn_Male.TabIndex = 40;
            this.rd_btn_Male.TabStop = true;
            this.rd_btn_Male.Text = "Male";
            this.rd_btn_Male.UseVisualStyleBackColor = true;
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Gold;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Brown;
            this.xuiGradientPanel1.Controls.Add(this.lbl_Search_Recipient);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 79;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Brown;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Gold;
            this.xuiGradientPanel2.Controls.Add(this.btn_Close);
            this.xuiGradientPanel2.Controls.Add(this.btn_Refresh);
            this.xuiGradientPanel2.Controls.Add(this.btn_Save);
            this.xuiGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiGradientPanel2.Location = new System.Drawing.Point(0, 668);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 80;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // frm_Search_Recipient_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1566, 740);
            this.ControlBox = false;
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.rtb_Address);
            this.Controls.Add(this.cmb_Blood_Group);
            this.Controls.Add(this.tb_Recipient_ID);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.lbl_Recipient_ID);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lbl_Recipient_Name);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Weight);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Blood_Group);
            this.Controls.Add(this.lbl_Aadhar_Card);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.dtp_Dob);
            this.Controls.Add(this.tb_Aadhar_Card);
            this.Controls.Add(this.tb_Weight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Search_Recipient_ID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search_Recipient;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RichTextBox rtb_Address;
        private System.Windows.Forms.ComboBox cmb_Blood_Group;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lbl_Blood_Group;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.DateTimePicker dtp_Dob;
        private System.Windows.Forms.TextBox tb_Weight;
        private System.Windows.Forms.TextBox tb_Aadhar_Card;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Recipient_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Aadhar_Card;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Recipient_Name;
        private System.Windows.Forms.Label lbl_Recipient_ID;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rd_btn_Other;
        private System.Windows.Forms.RadioButton rd_btn_Female;
        private System.Windows.Forms.RadioButton rd_btn_Male;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
    }
}