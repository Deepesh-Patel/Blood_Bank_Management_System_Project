namespace Blood_Bank_Management_System
{
    partial class frm_Stock_Price
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Stock_Price));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.btn_Close1 = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Stock_Price = new System.Windows.Forms.GroupBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.cmb_Blood_Group = new System.Windows.Forms.ComboBox();
            this.lbl_Blood_Group = new System.Windows.Forms.Label();
            this.dgv_Stock_Price = new System.Windows.Forms.DataGridView();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            this.gb_Stock_Price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_Price)).BeginInit();
            this.SuspendLayout();
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
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1345, 72);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 47;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(419, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(516, 49);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Add Blood Stock Price";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Brown;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Gold;
            this.xuiGradientPanel2.Controls.Add(this.btn_Close1);
            this.xuiGradientPanel2.Controls.Add(this.btn_Refresh);
            this.xuiGradientPanel2.Controls.Add(this.btn_Save);
            this.xuiGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiGradientPanel2.Location = new System.Drawing.Point(0, 608);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(1345, 72);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 48;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // btn_Close1
            // 
            this.btn_Close1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_Close1.BackColor = System.Drawing.Color.Snow;
            this.btn_Close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close1.Image")));
            this.btn_Close1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close1.Location = new System.Drawing.Point(830, 16);
            this.btn_Close1.Name = "btn_Close1";
            this.btn_Close1.Size = new System.Drawing.Size(116, 44);
            this.btn_Close1.TabIndex = 5;
            this.btn_Close1.Text = "Close";
            this.btn_Close1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close1.UseVisualStyleBackColor = false;
            this.btn_Close1.Click += new System.EventHandler(this.btn_Close1_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Snow;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.Location = new System.Drawing.Point(629, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(145, 44);
            this.btn_Refresh.TabIndex = 4;
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
            this.btn_Save.Location = new System.Drawing.Point(464, 16);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(109, 44);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Stock_Price
            // 
            this.gb_Stock_Price.Controls.Add(this.lbl_Price);
            this.gb_Stock_Price.Controls.Add(this.cmb_Blood_Group);
            this.gb_Stock_Price.Controls.Add(this.lbl_Blood_Group);
            this.gb_Stock_Price.Controls.Add(this.tb_Price);
            this.gb_Stock_Price.Location = new System.Drawing.Point(12, 89);
            this.gb_Stock_Price.Name = "gb_Stock_Price";
            this.gb_Stock_Price.Size = new System.Drawing.Size(1321, 89);
            this.gb_Stock_Price.TabIndex = 49;
            this.gb_Stock_Price.TabStop = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Price.Image")));
            this.lbl_Price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Price.Location = new System.Drawing.Point(745, 31);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(121, 27);
            this.lbl_Price.TabIndex = 56;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(902, 32);
            this.tb_Price.MaxLength = 8;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(350, 29);
            this.tb_Price.TabIndex = 2;
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
            this.cmb_Blood_Group.Location = new System.Drawing.Point(258, 31);
            this.cmb_Blood_Group.Name = "cmb_Blood_Group";
            this.cmb_Blood_Group.Size = new System.Drawing.Size(350, 30);
            this.cmb_Blood_Group.TabIndex = 1;
            // 
            // lbl_Blood_Group
            // 
            this.lbl_Blood_Group.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Blood_Group.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Group.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Blood_Group.Image")));
            this.lbl_Blood_Group.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Blood_Group.Location = new System.Drawing.Point(21, 31);
            this.lbl_Blood_Group.Name = "lbl_Blood_Group";
            this.lbl_Blood_Group.Size = new System.Drawing.Size(203, 27);
            this.lbl_Blood_Group.TabIndex = 54;
            this.lbl_Blood_Group.Text = "Blood Group";
            this.lbl_Blood_Group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv_Stock_Price
            // 
            this.dgv_Stock_Price.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Stock_Price.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Stock_Price.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock_Price.Location = new System.Drawing.Point(38, 211);
            this.dgv_Stock_Price.Name = "dgv_Stock_Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Stock_Price.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Stock_Price.RowTemplate.Height = 24;
            this.dgv_Stock_Price.Size = new System.Drawing.Size(1267, 361);
            this.dgv_Stock_Price.TabIndex = 50;
            // 
            // frm_Stock_Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1345, 680);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Stock_Price);
            this.Controls.Add(this.gb_Stock_Price);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Stock_Price";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Stock_Price_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.gb_Stock_Price.ResumeLayout(false);
            this.gb_Stock_Price.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_Price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Label lbl_Header;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private System.Windows.Forms.Button btn_Close1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Stock_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.ComboBox cmb_Blood_Group;
        private System.Windows.Forms.Label lbl_Blood_Group;
        private System.Windows.Forms.DataGridView dgv_Stock_Price;
    }
}