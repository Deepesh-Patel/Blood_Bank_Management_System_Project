namespace Blood_Bank_Management_System
{
    partial class frm_Search_Donor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Search_Donor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Search_Donor = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Blood_Grp = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_Search_Donor_BG = new System.Windows.Forms.DataGridView();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.cmb_Blood_Group = new System.Windows.Forms.ComboBox();
            this.tb_Donor_ID = new System.Windows.Forms.TextBox();
            this.lbl_Donor_ID = new System.Windows.Forms.Label();
            this.btn_Refresh_Grid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Donor_BG)).BeginInit();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Search_Donor
            // 
            this.lbl_Search_Donor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Search_Donor.AutoSize = true;
            this.lbl_Search_Donor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Search_Donor.Font = new System.Drawing.Font("Cooper Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Donor.Location = new System.Drawing.Point(619, 9);
            this.lbl_Search_Donor.Name = "lbl_Search_Donor";
            this.lbl_Search_Donor.Size = new System.Drawing.Size(338, 50);
            this.lbl_Search_Donor.TabIndex = 1;
            this.lbl_Search_Donor.Text = "Search Donor ";
            this.lbl_Search_Donor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Snow;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(1411, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 44);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Blood_Grp
            // 
            this.lbl_Blood_Grp.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Grp.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Blood_Grp.Image")));
            this.lbl_Blood_Grp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Blood_Grp.Location = new System.Drawing.Point(68, 92);
            this.lbl_Blood_Grp.Name = "lbl_Blood_Grp";
            this.lbl_Blood_Grp.Size = new System.Drawing.Size(201, 27);
            this.lbl_Blood_Grp.TabIndex = 14;
            this.lbl_Blood_Grp.Text = "Blood Group";
            this.lbl_Blood_Grp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Snow;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(1399, 84);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 40);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_Search_Donor_BG
            // 
            this.dgv_Search_Donor_BG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search_Donor_BG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Search_Donor_BG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search_Donor_BG.Location = new System.Drawing.Point(32, 140);
            this.dgv_Search_Donor_BG.Name = "dgv_Search_Donor_BG";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search_Donor_BG.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Search_Donor_BG.RowTemplate.Height = 24;
            this.dgv_Search_Donor_BG.Size = new System.Drawing.Size(1495, 464);
            this.dgv_Search_Donor_BG.TabIndex = 17;
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Gold;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Brown;
            this.xuiGradientPanel1.Controls.Add(this.lbl_Search_Donor);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1566, 72);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 47;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Brown;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Gold;
            this.xuiGradientPanel2.Controls.Add(this.btn_Close);
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
            this.cmb_Blood_Group.Location = new System.Drawing.Point(289, 92);
            this.cmb_Blood_Group.Name = "cmb_Blood_Group";
            this.cmb_Blood_Group.Size = new System.Drawing.Size(451, 30);
            this.cmb_Blood_Group.TabIndex = 1;
            this.cmb_Blood_Group.SelectedIndexChanged += new System.EventHandler(this.Load_Donor_Data);
            // 
            // tb_Donor_ID
            // 
            this.tb_Donor_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Donor_ID.Location = new System.Drawing.Point(1059, 92);
            this.tb_Donor_ID.MaxLength = 30;
            this.tb_Donor_ID.Name = "tb_Donor_ID";
            this.tb_Donor_ID.Size = new System.Drawing.Size(317, 29);
            this.tb_Donor_ID.TabIndex = 2;
            this.tb_Donor_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Donor_ID
            // 
            this.lbl_Donor_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Donor_ID.Font = new System.Drawing.Font("Georgia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Donor_ID.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Donor_ID.Image")));
            this.lbl_Donor_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Donor_ID.Location = new System.Drawing.Point(829, 90);
            this.lbl_Donor_ID.Name = "lbl_Donor_ID";
            this.lbl_Donor_ID.Size = new System.Drawing.Size(176, 31);
            this.lbl_Donor_ID.TabIndex = 69;
            this.lbl_Donor_ID.Text = "Donor ID";
            this.lbl_Donor_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Refresh_Grid
            // 
            this.btn_Refresh_Grid.BackColor = System.Drawing.Color.Snow;
            this.btn_Refresh_Grid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh_Grid.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh_Grid.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh_Grid.Image")));
            this.btn_Refresh_Grid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh_Grid.Location = new System.Drawing.Point(1310, 618);
            this.btn_Refresh_Grid.Name = "btn_Refresh_Grid";
            this.btn_Refresh_Grid.Size = new System.Drawing.Size(217, 44);
            this.btn_Refresh_Grid.TabIndex = 4;
            this.btn_Refresh_Grid.Text = "Refresh Grid";
            this.btn_Refresh_Grid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh_Grid.UseVisualStyleBackColor = false;
            this.btn_Refresh_Grid.Click += new System.EventHandler(this.btn_Refresh_Grid_Click);
            // 
            // frm_Search_Donor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1566, 740);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh_Grid);
            this.Controls.Add(this.tb_Donor_ID);
            this.Controls.Add(this.lbl_Donor_ID);
            this.Controls.Add(this.cmb_Blood_Group);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.dgv_Search_Donor_BG);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Blood_Grp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Search_Donor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Search_Donor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search_Donor_BG)).EndInit();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search_Donor;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Blood_Grp;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Search_Donor_BG;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private System.Windows.Forms.ComboBox cmb_Blood_Group;
        private System.Windows.Forms.TextBox tb_Donor_ID;
        private System.Windows.Forms.Label lbl_Donor_ID;
        private System.Windows.Forms.Button btn_Refresh_Grid;
    }
}