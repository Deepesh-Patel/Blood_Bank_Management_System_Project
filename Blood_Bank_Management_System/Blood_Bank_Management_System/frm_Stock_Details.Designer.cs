namespace Blood_Bank_Management_System
{
    partial class frm_Stock_Details
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Stock_Details));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dg_Stock_Details = new System.Windows.Forms.DataGridView();
            this.stockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blood_Bank_Management_System_DBDataSet5 = new Blood_Bank_Management_System.Blood_Bank_Management_System_DBDataSet5();
            this.btn_Close = new System.Windows.Forms.Button();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.stock_DetailsTableAdapter = new Blood_Bank_Management_System.Blood_Bank_Management_System_DBDataSet5TableAdapters.Stock_DetailsTableAdapter();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Stock_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_Management_System_DBDataSet5)).BeginInit();
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
            this.lbl_Header.Location = new System.Drawing.Point(350, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(318, 50);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Stock Details";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dg_Stock_Details
            // 
            this.dg_Stock_Details.AllowUserToAddRows = false;
            this.dg_Stock_Details.AllowUserToDeleteRows = false;
            this.dg_Stock_Details.AutoGenerateColumns = false;
            this.dg_Stock_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Stock_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Stock_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Stock_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bloodGroupDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn});
            this.dg_Stock_Details.DataSource = this.stockDetailsBindingSource;
            this.dg_Stock_Details.Location = new System.Drawing.Point(37, 95);
            this.dg_Stock_Details.Name = "dg_Stock_Details";
            this.dg_Stock_Details.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Stock_Details.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Stock_Details.RowTemplate.Height = 24;
            this.dg_Stock_Details.Size = new System.Drawing.Size(985, 513);
            this.dg_Stock_Details.TabIndex = 40;
            // 
            // stockDetailsBindingSource
            // 
            this.stockDetailsBindingSource.DataMember = "Stock_Details";
            this.stockDetailsBindingSource.DataSource = this.blood_Bank_Management_System_DBDataSet5;
            // 
            // blood_Bank_Management_System_DBDataSet5
            // 
            this.blood_Bank_Management_System_DBDataSet5.DataSetName = "Blood_Bank_Management_System_DBDataSet5";
            this.blood_Bank_Management_System_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Snow;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(906, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 44);
            this.btn_Close.TabIndex = 44;
            this.btn_Close.Text = "Close";
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1064, 72);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 48;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Brown;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Gold;
            this.xuiGradientPanel2.Controls.Add(this.btn_Close);
            this.xuiGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiGradientPanel2.Location = new System.Drawing.Point(0, 633);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(1064, 72);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 66;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // stock_DetailsTableAdapter
            // 
            this.stock_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "Blood_Group";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "Blood Group";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Stock_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1064, 705);
            this.ControlBox = false;
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.dg_Stock_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Stock_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Stock_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Stock_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_Management_System_DBDataSet5)).EndInit();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dg_Stock_Details;
        private System.Windows.Forms.Button btn_Close;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private Blood_Bank_Management_System_DBDataSet5 blood_Bank_Management_System_DBDataSet5;
        private System.Windows.Forms.BindingSource stockDetailsBindingSource;
        private Blood_Bank_Management_System_DBDataSet5TableAdapters.Stock_DetailsTableAdapter stock_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
    }
}