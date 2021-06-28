namespace Blood_Bank_Management_System
{
    partial class frm_Update_Recipient_Blood_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Update_Recipient_Blood_Stock));
            this.lbl_Blood_Stock_For_Recipient = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Recipient_Name = new System.Windows.Forms.Label();
            this.cmb_Blood_Group = new System.Windows.Forms.ComboBox();
            this.lbl_Blood_Group = new System.Windows.Forms.Label();
            this.tb_Blood_Required = new System.Windows.Forms.TextBox();
            this.lbl_Stock_Required = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update_Stock = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Recipient_ID = new System.Windows.Forms.Label();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Blood_Stock_For_Recipient
            // 
            this.lbl_Blood_Stock_For_Recipient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Blood_Stock_For_Recipient.AutoSize = true;
            this.lbl_Blood_Stock_For_Recipient.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Blood_Stock_For_Recipient.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Stock_For_Recipient.Location = new System.Drawing.Point(391, 9);
            this.lbl_Blood_Stock_For_Recipient.Name = "lbl_Blood_Stock_For_Recipient";
            this.lbl_Blood_Stock_For_Recipient.Size = new System.Drawing.Size(725, 50);
            this.lbl_Blood_Stock_For_Recipient.TabIndex = 1;
            this.lbl_Blood_Stock_For_Recipient.Text = "Blood Requirement (Recipient)";
            this.lbl_Blood_Stock_For_Recipient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(226, 190);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(475, 29);
            this.tb_Name.TabIndex = 0;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // lbl_Recipient_Name
            // 
            this.lbl_Recipient_Name.AutoSize = true;
            this.lbl_Recipient_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Recipient_Name.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recipient_Name.Location = new System.Drawing.Point(45, 190);
            this.lbl_Recipient_Name.Name = "lbl_Recipient_Name";
            this.lbl_Recipient_Name.Size = new System.Drawing.Size(79, 27);
            this.lbl_Recipient_Name.TabIndex = 40;
            this.lbl_Recipient_Name.Text = "Name";
            // 
            // cmb_Blood_Group
            // 
            this.cmb_Blood_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Blood_Group.Enabled = false;
            this.cmb_Blood_Group.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Blood_Group.FormattingEnabled = true;
            this.cmb_Blood_Group.Items.AddRange(new object[] {
            "A-",
            "A+",
            "AB-",
            "AB+",
            "B-",
            "B+",
            "O-",
            "O+"});
            this.cmb_Blood_Group.Location = new System.Drawing.Point(226, 352);
            this.cmb_Blood_Group.Name = "cmb_Blood_Group";
            this.cmb_Blood_Group.Size = new System.Drawing.Size(475, 30);
            this.cmb_Blood_Group.TabIndex = 0;
            this.cmb_Blood_Group.TextChanged += new System.EventHandler(this.cmb_Blood_Group_TextChanged);
            // 
            // lbl_Blood_Group
            // 
            this.lbl_Blood_Group.AutoSize = true;
            this.lbl_Blood_Group.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Blood_Group.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Group.Location = new System.Drawing.Point(45, 355);
            this.lbl_Blood_Group.Name = "lbl_Blood_Group";
            this.lbl_Blood_Group.Size = new System.Drawing.Size(160, 27);
            this.lbl_Blood_Group.TabIndex = 42;
            this.lbl_Blood_Group.Text = "Blood Group";
            // 
            // tb_Blood_Required
            // 
            this.tb_Blood_Required.Enabled = false;
            this.tb_Blood_Required.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Blood_Required.Location = new System.Drawing.Point(1035, 355);
            this.tb_Blood_Required.MaxLength = 30;
            this.tb_Blood_Required.Name = "tb_Blood_Required";
            this.tb_Blood_Required.Size = new System.Drawing.Size(475, 29);
            this.tb_Blood_Required.TabIndex = 3;
            this.tb_Blood_Required.TextChanged += new System.EventHandler(this.tb_Blood_Required_TextChanged);
            this.tb_Blood_Required.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Stock_Required
            // 
            this.lbl_Stock_Required.AutoSize = true;
            this.lbl_Stock_Required.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock_Required.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Required.Location = new System.Drawing.Point(796, 344);
            this.lbl_Stock_Required.Name = "lbl_Stock_Required";
            this.lbl_Stock_Required.Size = new System.Drawing.Size(223, 54);
            this.lbl_Stock_Required.TabIndex = 44;
            this.lbl_Stock_Required.Text = "Blood Required\r\n(Quantity In Unit)";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(45, 517);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(72, 27);
            this.lbl_Price.TabIndex = 51;
            this.lbl_Price.Text = "Price";
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(226, 517);
            this.tb_Price.MaxLength = 30;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(475, 29);
            this.tb_Price.TabIndex = 5;
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Snow;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(916, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 44);
            this.btn_Close.TabIndex = 6;
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
            this.btn_Refresh.Location = new System.Drawing.Point(715, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(145, 44);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Update_Stock
            // 
            this.btn_Update_Stock.BackColor = System.Drawing.Color.Snow;
            this.btn_Update_Stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Update_Stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update_Stock.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Stock.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update_Stock.Image")));
            this.btn_Update_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update_Stock.Location = new System.Drawing.Point(455, 16);
            this.btn_Update_Stock.Name = "btn_Update_Stock";
            this.btn_Update_Stock.Size = new System.Drawing.Size(204, 44);
            this.btn_Update_Stock.TabIndex = 4;
            this.btn_Update_Stock.Text = "Update Stock";
            this.btn_Update_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update_Stock.UseVisualStyleBackColor = false;
            this.btn_Update_Stock.Click += new System.EventHandler(this.btn_Update_Stock_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1035, 188);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(475, 29);
            this.dtp_Date.TabIndex = 3;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(796, 192);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(72, 27);
            this.lbl_Date.TabIndex = 54;
            this.lbl_Date.Text = "Date ";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(647, 85);
            this.tb_ID.MaxLength = 30;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(359, 29);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Snow;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(1035, 77);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 40);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Recipient_ID
            // 
            this.lbl_Recipient_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Recipient_ID.Font = new System.Drawing.Font("Georgia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recipient_ID.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Recipient_ID.Image")));
            this.lbl_Recipient_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Recipient_ID.Location = new System.Drawing.Point(382, 85);
            this.lbl_Recipient_ID.Name = "lbl_Recipient_ID";
            this.lbl_Recipient_ID.Size = new System.Drawing.Size(230, 27);
            this.lbl_Recipient_ID.TabIndex = 56;
            this.lbl_Recipient_ID.Text = "Recipient ID";
            this.lbl_Recipient_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.Location = new System.Drawing.Point(796, 519);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(120, 27);
            this.lbl_Total_Bill.TabIndex = 44;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Enabled = false;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(1035, 515);
            this.tb_Total_Bill.MaxLength = 30;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(475, 29);
            this.tb_Total_Bill.TabIndex = 6;
            this.tb_Total_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Gold;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Brown;
            this.xuiGradientPanel1.Controls.Add(this.lbl_Blood_Stock_For_Recipient);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 57;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Brown;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Gold;
            this.xuiGradientPanel2.Controls.Add(this.btn_Close);
            this.xuiGradientPanel2.Controls.Add(this.btn_Refresh);
            this.xuiGradientPanel2.Controls.Add(this.btn_Update_Stock);
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
            // frm_Update_Recipient_Blood_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1566, 740);
            this.ControlBox = false;
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.lbl_Recipient_ID);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Total_Bill);
            this.Controls.Add(this.tb_Blood_Required);
            this.Controls.Add(this.lbl_Total_Bill);
            this.Controls.Add(this.lbl_Stock_Required);
            this.Controls.Add(this.cmb_Blood_Group);
            this.Controls.Add(this.lbl_Blood_Group);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Recipient_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Update_Recipient_Blood_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Blood_Stock_For_Recipient;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Recipient_Name;
        private System.Windows.Forms.ComboBox cmb_Blood_Group;
        private System.Windows.Forms.Label lbl_Blood_Group;
        private System.Windows.Forms.TextBox tb_Blood_Required;
        private System.Windows.Forms.Label lbl_Stock_Required;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update_Stock;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Recipient_ID;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
    }
}