namespace Blood_Bank_Management_System
{
    partial class frm_Blood_Stock_Requirement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Blood_Stock_Requirement));
            this.lbl_Blood_Stock_Requirement = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Hospital_Name = new System.Windows.Forms.Label();
            this.lbl_Hospital_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Blood_Group = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.gb_Hospital_Details = new System.Windows.Forms.GroupBox();
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmb_Blood_Group = new System.Windows.Forms.ComboBox();
            this.lbl_Stock_Required = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.gb_Hospital_Details.SuspendLayout();
            this.gb_Stock_Details.SuspendLayout();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Blood_Stock_Requirement
            // 
            this.lbl_Blood_Stock_Requirement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Blood_Stock_Requirement.AutoSize = true;
            this.lbl_Blood_Stock_Requirement.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Blood_Stock_Requirement.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Stock_Requirement.Location = new System.Drawing.Point(458, 9);
            this.lbl_Blood_Stock_Requirement.Name = "lbl_Blood_Stock_Requirement";
            this.lbl_Blood_Stock_Requirement.Size = new System.Drawing.Size(596, 50);
            this.lbl_Blood_Stock_Requirement.TabIndex = 1;
            this.lbl_Blood_Stock_Requirement.Text = "Blood Stock Requirement";
            this.lbl_Blood_Stock_Requirement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(313, 36);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(622, 96);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(368, 29);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Hospital_Name
            // 
            this.lbl_Hospital_Name.AutoSize = true;
            this.lbl_Hospital_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hospital_Name.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hospital_Name.Location = new System.Drawing.Point(40, 36);
            this.lbl_Hospital_Name.Name = "lbl_Hospital_Name";
            this.lbl_Hospital_Name.Size = new System.Drawing.Size(185, 27);
            this.lbl_Hospital_Name.TabIndex = 38;
            this.lbl_Hospital_Name.Text = "Hospital Name";
            // 
            // lbl_Hospital_ID
            // 
            this.lbl_Hospital_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hospital_ID.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hospital_ID.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Hospital_ID.Image")));
            this.lbl_Hospital_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Hospital_ID.Location = new System.Drawing.Point(378, 96);
            this.lbl_Hospital_ID.Name = "lbl_Hospital_ID";
            this.lbl_Hospital_ID.Size = new System.Drawing.Size(206, 27);
            this.lbl_Hospital_ID.TabIndex = 39;
            this.lbl_Hospital_ID.Text = "Hospital ID";
            this.lbl_Hospital_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Snow;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(1010, 88);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 40);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lbl_Blood_Group
            // 
            this.lbl_Blood_Group.AutoSize = true;
            this.lbl_Blood_Group.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Blood_Group.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Group.Location = new System.Drawing.Point(40, 35);
            this.lbl_Blood_Group.Name = "lbl_Blood_Group";
            this.lbl_Blood_Group.Size = new System.Drawing.Size(160, 27);
            this.lbl_Blood_Group.TabIndex = 38;
            this.lbl_Blood_Group.Text = "Blood Group";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1057, 34);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(403, 29);
            this.textBox2.TabIndex = 0;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.Color.Transparent;
            this.lbl_City.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(837, 34);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(60, 27);
            this.lbl_City.TabIndex = 44;
            this.lbl_City.Text = "City";
            // 
            // gb_Hospital_Details
            // 
            this.gb_Hospital_Details.Controls.Add(this.textBox2);
            this.gb_Hospital_Details.Controls.Add(this.lbl_Hospital_Name);
            this.gb_Hospital_Details.Controls.Add(this.lbl_City);
            this.gb_Hospital_Details.Controls.Add(this.textBox1);
            this.gb_Hospital_Details.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Hospital_Details.Location = new System.Drawing.Point(30, 179);
            this.gb_Hospital_Details.Name = "gb_Hospital_Details";
            this.gb_Hospital_Details.Size = new System.Drawing.Size(1505, 114);
            this.gb_Hospital_Details.TabIndex = 46;
            this.gb_Hospital_Details.TabStop = false;
            this.gb_Hospital_Details.Text = "Hospital Details";
            // 
            // gb_Stock_Details
            // 
            this.gb_Stock_Details.Controls.Add(this.textBox3);
            this.gb_Stock_Details.Controls.Add(this.cmb_Blood_Group);
            this.gb_Stock_Details.Controls.Add(this.lbl_Stock_Required);
            this.gb_Stock_Details.Controls.Add(this.lbl_Blood_Group);
            this.gb_Stock_Details.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Stock_Details.Location = new System.Drawing.Point(30, 425);
            this.gb_Stock_Details.Name = "gb_Stock_Details";
            this.gb_Stock_Details.Size = new System.Drawing.Size(1505, 103);
            this.gb_Stock_Details.TabIndex = 47;
            this.gb_Stock_Details.TabStop = false;
            this.gb_Stock_Details.Text = "Stock Details";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1057, 36);
            this.textBox3.MaxLength = 30;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(403, 29);
            this.textBox3.TabIndex = 4;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // cmb_Blood_Group
            // 
            this.cmb_Blood_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmb_Blood_Group.Location = new System.Drawing.Point(313, 35);
            this.cmb_Blood_Group.Name = "cmb_Blood_Group";
            this.cmb_Blood_Group.Size = new System.Drawing.Size(403, 30);
            this.cmb_Blood_Group.TabIndex = 3;
            // 
            // lbl_Stock_Required
            // 
            this.lbl_Stock_Required.AutoSize = true;
            this.lbl_Stock_Required.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock_Required.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Required.Location = new System.Drawing.Point(837, 36);
            this.lbl_Stock_Required.Name = "lbl_Stock_Required";
            this.lbl_Stock_Required.Size = new System.Drawing.Size(187, 27);
            this.lbl_Stock_Required.TabIndex = 38;
            this.lbl_Stock_Required.Text = "Stock Required";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Snow;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(914, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 44);
            this.btn_Close.TabIndex = 7;
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
            this.btn_Refresh.Location = new System.Drawing.Point(713, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(145, 44);
            this.btn_Refresh.TabIndex = 6;
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
            this.btn_Save.Location = new System.Drawing.Point(548, 16);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(109, 44);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Gold;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Brown;
            this.xuiGradientPanel1.Controls.Add(this.lbl_Blood_Stock_Requirement);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 49;
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
            this.xuiGradientPanel2.TabIndex = 66;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // frm_Blood_Stock_Requirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1566, 740);
            this.ControlBox = false;
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.gb_Stock_Details);
            this.Controls.Add(this.gb_Hospital_Details);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Hospital_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Blood_Stock_Requirement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gb_Hospital_Details.ResumeLayout(false);
            this.gb_Hospital_Details.PerformLayout();
            this.gb_Stock_Details.ResumeLayout(false);
            this.gb_Stock_Details.PerformLayout();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Blood_Stock_Requirement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Hospital_Name;
        private System.Windows.Forms.Label lbl_Hospital_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Blood_Group;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.GroupBox gb_Hospital_Details;
        private System.Windows.Forms.GroupBox gb_Stock_Details;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_Stock_Required;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private System.Windows.Forms.ComboBox cmb_Blood_Group;
    }
}