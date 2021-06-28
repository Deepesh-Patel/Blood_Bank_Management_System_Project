namespace Blood_Bank_Management_System
{
    partial class frm_Hospital_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Hospital_Bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Hospital_Bill = new System.Windows.Forms.Label();
            this.tb_Hospital_Name = new System.Windows.Forms.TextBox();
            this.tb_Hospital_ID = new System.Windows.Forms.TextBox();
            this.lbl_Hospital_Name = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Hospital_ID = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.gb_Stock = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.dgv_Stock = new System.Windows.Forms.DataGridView();
            this.tb_Stock_Required = new System.Windows.Forms.TextBox();
            this.cmb_Blood_Group = new System.Windows.Forms.ComboBox();
            this.lbl_Stock_Required = new System.Windows.Forms.Label();
            this.lbl_Blood_Group = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.btn_Add_Bill = new System.Windows.Forms.Button();
            this.btn_Delete_Stock = new System.Windows.Forms.Button();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            this.gb_Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Hospital_Bill
            // 
            this.lbl_Hospital_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Hospital_Bill.AutoSize = true;
            this.lbl_Hospital_Bill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hospital_Bill.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hospital_Bill.Location = new System.Drawing.Point(608, 9);
            this.lbl_Hospital_Bill.Name = "lbl_Hospital_Bill";
            this.lbl_Hospital_Bill.Size = new System.Drawing.Size(301, 50);
            this.lbl_Hospital_Bill.TabIndex = 1;
            this.lbl_Hospital_Bill.Text = "Hospital Bill";
            this.lbl_Hospital_Bill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Hospital_Name
            // 
            this.tb_Hospital_Name.Enabled = false;
            this.tb_Hospital_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Hospital_Name.Location = new System.Drawing.Point(346, 189);
            this.tb_Hospital_Name.MaxLength = 30;
            this.tb_Hospital_Name.Name = "tb_Hospital_Name";
            this.tb_Hospital_Name.Size = new System.Drawing.Size(382, 29);
            this.tb_Hospital_Name.TabIndex = 40;
            this.tb_Hospital_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Hospital_ID
            // 
            this.tb_Hospital_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Hospital_ID.Location = new System.Drawing.Point(617, 88);
            this.tb_Hospital_ID.MaxLength = 30;
            this.tb_Hospital_ID.Name = "tb_Hospital_ID";
            this.tb_Hospital_ID.Size = new System.Drawing.Size(325, 29);
            this.tb_Hospital_ID.TabIndex = 1;
            this.tb_Hospital_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Hospital_Name
            // 
            this.lbl_Hospital_Name.AutoSize = true;
            this.lbl_Hospital_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hospital_Name.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hospital_Name.Location = new System.Drawing.Point(73, 189);
            this.lbl_Hospital_Name.Name = "lbl_Hospital_Name";
            this.lbl_Hospital_Name.Size = new System.Drawing.Size(185, 27);
            this.lbl_Hospital_Name.TabIndex = 38;
            this.lbl_Hospital_Name.Text = "Hospital Name";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Snow;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(970, 80);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 40);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Hospital_ID
            // 
            this.lbl_Hospital_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hospital_ID.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hospital_ID.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Hospital_ID.Image")));
            this.lbl_Hospital_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Hospital_ID.Location = new System.Drawing.Point(380, 88);
            this.lbl_Hospital_ID.Name = "lbl_Hospital_ID";
            this.lbl_Hospital_ID.Size = new System.Drawing.Size(206, 27);
            this.lbl_Hospital_ID.TabIndex = 44;
            this.lbl_Hospital_ID.Text = "Hospital ID";
            this.lbl_Hospital_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1056, 187);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(382, 29);
            this.dtp_Date.TabIndex = 3;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(927, 189);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(72, 27);
            this.lbl_Date.TabIndex = 46;
            this.lbl_Date.Text = "Date ";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(750, 43);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(72, 27);
            this.lbl_Price.TabIndex = 49;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Total_Bill.Image")));
            this.lbl_Total_Bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(399, 606);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(159, 33);
            this.lbl_Total_Bill.TabIndex = 46;
            this.lbl_Total_Bill.Text = "Total Bill";
            this.lbl_Total_Bill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Enabled = false;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(587, 611);
            this.tb_Total_Bill.MaxLength = 2;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(382, 31);
            this.tb_Total_Bill.TabIndex = 7;
            this.tb_Total_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Snow;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(919, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 44);
            this.btn_Close.TabIndex = 9;
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
            this.btn_Refresh.Location = new System.Drawing.Point(718, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(145, 44);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.UseVisualStyleBackColor = false;
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
            this.btn_Save.Location = new System.Drawing.Point(553, 16);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(109, 44);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Gold;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Brown;
            this.xuiGradientPanel1.Controls.Add(this.lbl_Hospital_Bill);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 52;
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
            // gb_Stock
            // 
            this.gb_Stock.Controls.Add(this.button2);
            this.gb_Stock.Controls.Add(this.button1);
            this.gb_Stock.Controls.Add(this.btn_Add);
            this.gb_Stock.Controls.Add(this.tb_Price);
            this.gb_Stock.Controls.Add(this.dgv_Stock);
            this.gb_Stock.Controls.Add(this.tb_Stock_Required);
            this.gb_Stock.Controls.Add(this.cmb_Blood_Group);
            this.gb_Stock.Controls.Add(this.lbl_Stock_Required);
            this.gb_Stock.Controls.Add(this.lbl_Blood_Group);
            this.gb_Stock.Controls.Add(this.lbl_Total_Price);
            this.gb_Stock.Controls.Add(this.lbl_Price);
            this.gb_Stock.Controls.Add(this.tb_Total_Price);
            this.gb_Stock.Enabled = false;
            this.gb_Stock.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Stock.Location = new System.Drawing.Point(29, 246);
            this.gb_Stock.Name = "gb_Stock";
            this.gb_Stock.Size = new System.Drawing.Size(1510, 344);
            this.gb_Stock.TabIndex = 67;
            this.gb_Stock.TabStop = false;
            this.gb_Stock.Text = "Stock";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(2264, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2009, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Snow;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(1375, 34);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(109, 44);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(828, 43);
            this.tb_Price.MaxLength = 8;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(142, 29);
            this.tb_Price.TabIndex = 4;
            // 
            // dgv_Stock
            // 
            this.dgv_Stock.AllowUserToAddRows = false;
            this.dgv_Stock.AllowUserToDeleteRows = false;
            this.dgv_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock.Location = new System.Drawing.Point(22, 97);
            this.dgv_Stock.Name = "dgv_Stock";
            this.dgv_Stock.ReadOnly = true;
            this.dgv_Stock.RowTemplate.Height = 24;
            this.dgv_Stock.Size = new System.Drawing.Size(1462, 227);
            this.dgv_Stock.TabIndex = 55;
            // 
            // tb_Stock_Required
            // 
            this.tb_Stock_Required.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock_Required.Location = new System.Drawing.Point(573, 43);
            this.tb_Stock_Required.MaxLength = 2;
            this.tb_Stock_Required.Name = "tb_Stock_Required";
            this.tb_Stock_Required.Size = new System.Drawing.Size(142, 29);
            this.tb_Stock_Required.TabIndex = 4;
            this.tb_Stock_Required.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
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
            this.cmb_Blood_Group.Location = new System.Drawing.Point(194, 43);
            this.cmb_Blood_Group.Name = "cmb_Blood_Group";
            this.cmb_Blood_Group.Size = new System.Drawing.Size(142, 30);
            this.cmb_Blood_Group.TabIndex = 3;
            this.cmb_Blood_Group.TextChanged += new System.EventHandler(this.cmb_Blood_Group_TextChanged);
            // 
            // lbl_Stock_Required
            // 
            this.lbl_Stock_Required.AutoSize = true;
            this.lbl_Stock_Required.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock_Required.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Required.Location = new System.Drawing.Point(365, 43);
            this.lbl_Stock_Required.Name = "lbl_Stock_Required";
            this.lbl_Stock_Required.Size = new System.Drawing.Size(187, 27);
            this.lbl_Stock_Required.TabIndex = 54;
            this.lbl_Stock_Required.Text = "Stock Required";
            // 
            // lbl_Blood_Group
            // 
            this.lbl_Blood_Group.AutoSize = true;
            this.lbl_Blood_Group.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Blood_Group.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Group.Location = new System.Drawing.Point(17, 43);
            this.lbl_Blood_Group.Name = "lbl_Blood_Group";
            this.lbl_Blood_Group.Size = new System.Drawing.Size(160, 27);
            this.lbl_Blood_Group.TabIndex = 53;
            this.lbl_Blood_Group.Text = "Blood Group";
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.Location = new System.Drawing.Point(1011, 44);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(139, 27);
            this.lbl_Total_Price.TabIndex = 49;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(1172, 44);
            this.tb_Total_Price.MaxLength = 2;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(142, 29);
            this.tb_Total_Price.TabIndex = 6;
            this.tb_Total_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Add_Bill
            // 
            this.btn_Add_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_Bill.BackColor = System.Drawing.Color.Snow;
            this.btn_Add_Bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_Bill.Enabled = false;
            this.btn_Add_Bill.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Bill.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add_Bill.Image")));
            this.btn_Add_Bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Bill.Location = new System.Drawing.Point(1002, 606);
            this.btn_Add_Bill.Name = "btn_Add_Bill";
            this.btn_Add_Bill.Size = new System.Drawing.Size(161, 46);
            this.btn_Add_Bill.TabIndex = 6;
            this.btn_Add_Bill.Text = "Add Bill";
            this.btn_Add_Bill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add_Bill.UseVisualStyleBackColor = false;
            this.btn_Add_Bill.Click += new System.EventHandler(this.btn_Add_Bill_Click);
            // 
            // btn_Delete_Stock
            // 
            this.btn_Delete_Stock.BackColor = System.Drawing.Color.Snow;
            this.btn_Delete_Stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Delete_Stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete_Stock.Enabled = false;
            this.btn_Delete_Stock.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Stock.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Stock.Image")));
            this.btn_Delete_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete_Stock.Location = new System.Drawing.Point(1201, 606);
            this.btn_Delete_Stock.Name = "btn_Delete_Stock";
            this.btn_Delete_Stock.Size = new System.Drawing.Size(312, 46);
            this.btn_Delete_Stock.TabIndex = 68;
            this.btn_Delete_Stock.Text = "Delete Selected Stock";
            this.btn_Delete_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete_Stock.UseVisualStyleBackColor = false;
            this.btn_Delete_Stock.Click += new System.EventHandler(this.btn_Delete_Stock_Click);
            // 
            // frm_Hospital_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1566, 740);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Delete_Stock);
            this.Controls.Add(this.btn_Add_Bill);
            this.Controls.Add(this.gb_Stock);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.tb_Total_Bill);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Total_Bill);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Hospital_ID);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Hospital_Name);
            this.Controls.Add(this.tb_Hospital_ID);
            this.Controls.Add(this.lbl_Hospital_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Hospital_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Hospital_Bill_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.gb_Stock.ResumeLayout(false);
            this.gb_Stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Hospital_Bill;
        private System.Windows.Forms.TextBox tb_Hospital_Name;
        private System.Windows.Forms.TextBox tb_Hospital_ID;
        private System.Windows.Forms.Label lbl_Hospital_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Hospital_ID;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private System.Windows.Forms.GroupBox gb_Stock;
        private System.Windows.Forms.DataGridView dgv_Stock;
        private System.Windows.Forms.TextBox tb_Stock_Required;
        private System.Windows.Forms.ComboBox cmb_Blood_Group;
        private System.Windows.Forms.Label lbl_Stock_Required;
        private System.Windows.Forms.Label lbl_Blood_Group;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Button btn_Add_Bill;
        private System.Windows.Forms.Button btn_Delete_Stock;
    }
}