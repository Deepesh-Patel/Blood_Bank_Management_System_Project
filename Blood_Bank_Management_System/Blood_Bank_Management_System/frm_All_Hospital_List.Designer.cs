namespace Blood_Bank_Management_System
{
    partial class frm_All_Hospital_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_All_Hospital_List));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dgv_Hospital_List = new System.Windows.Forms.DataGridView();
            this.hospitalDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blood_Bank_Management_System_DBDataSet = new Blood_Bank_Management_System.Blood_Bank_Management_System_DBDataSet();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.hospital_DetailsTableAdapter = new Blood_Bank_Management_System.Blood_Bank_Management_System_DBDataSetTableAdapters.Hospital_DetailsTableAdapter();
            this.hospitalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hospital_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_Management_System_DBDataSet)).BeginInit();
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
            this.lbl_Header.Location = new System.Drawing.Point(588, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(385, 50);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "All Hospital List";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Snow;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(1409, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 44);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Close";
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // dgv_Hospital_List
            // 
            this.dgv_Hospital_List.AllowUserToAddRows = false;
            this.dgv_Hospital_List.AllowUserToDeleteRows = false;
            this.dgv_Hospital_List.AutoGenerateColumns = false;
            this.dgv_Hospital_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Hospital_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Hospital_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hospital_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hospitalIDDataGridViewTextBoxColumn,
            this.hospitalNameDataGridViewTextBoxColumn,
            this.contactNoIDataGridViewTextBoxColumn,
            this.contactNoIIDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgv_Hospital_List.DataSource = this.hospitalDetailsBindingSource;
            this.dgv_Hospital_List.Location = new System.Drawing.Point(32, 93);
            this.dgv_Hospital_List.Name = "dgv_Hospital_List";
            this.dgv_Hospital_List.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Hospital_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Hospital_List.RowTemplate.Height = 24;
            this.dgv_Hospital_List.Size = new System.Drawing.Size(1501, 528);
            this.dgv_Hospital_List.TabIndex = 14;
            // 
            // hospitalDetailsBindingSource
            // 
            this.hospitalDetailsBindingSource.DataMember = "Hospital_Details";
            this.hospitalDetailsBindingSource.DataSource = this.blood_Bank_Management_System_DBDataSet;
            // 
            // blood_Bank_Management_System_DBDataSet
            // 
            this.blood_Bank_Management_System_DBDataSet.DataSetName = "Blood_Bank_Management_System_DBDataSet";
            this.blood_Bank_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Number.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.ForeColor = System.Drawing.Color.Red;
            this.lbl_Number.Location = new System.Drawing.Point(1486, 629);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(53, 29);
            this.lbl_Number.TabIndex = 74;
            this.lbl_Number.Text = "No.";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total.Font = new System.Drawing.Font("Georgia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(1278, 627);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(190, 31);
            this.lbl_Total.TabIndex = 73;
            this.lbl_Total.Text = "Total Count:";
            // 
            // hospital_DetailsTableAdapter
            // 
            this.hospital_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // hospitalIDDataGridViewTextBoxColumn
            // 
            this.hospitalIDDataGridViewTextBoxColumn.DataPropertyName = "Hospital_ID";
            this.hospitalIDDataGridViewTextBoxColumn.HeaderText = "Hospital ID";
            this.hospitalIDDataGridViewTextBoxColumn.Name = "hospitalIDDataGridViewTextBoxColumn";
            this.hospitalIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hospitalNameDataGridViewTextBoxColumn
            // 
            this.hospitalNameDataGridViewTextBoxColumn.DataPropertyName = "Hospital_Name";
            this.hospitalNameDataGridViewTextBoxColumn.HeaderText = "Hospital Name";
            this.hospitalNameDataGridViewTextBoxColumn.Name = "hospitalNameDataGridViewTextBoxColumn";
            this.hospitalNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoIDataGridViewTextBoxColumn
            // 
            this.contactNoIDataGridViewTextBoxColumn.DataPropertyName = "Contact_No_I";
            this.contactNoIDataGridViewTextBoxColumn.HeaderText = "Contact No I";
            this.contactNoIDataGridViewTextBoxColumn.Name = "contactNoIDataGridViewTextBoxColumn";
            this.contactNoIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoIIDataGridViewTextBoxColumn
            // 
            this.contactNoIIDataGridViewTextBoxColumn.DataPropertyName = "Contact_No_II";
            this.contactNoIIDataGridViewTextBoxColumn.HeaderText = "Contact No II";
            this.contactNoIIDataGridViewTextBoxColumn.Name = "contactNoIIDataGridViewTextBoxColumn";
            this.contactNoIIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_All_Hospital_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1566, 740);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.dgv_Hospital_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_All_Hospital_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_All_Hospital_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hospital_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_Management_System_DBDataSet)).EndInit();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dgv_Hospital_List;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_Total;
        private Blood_Bank_Management_System_DBDataSet blood_Bank_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource hospitalDetailsBindingSource;
        private Blood_Bank_Management_System_DBDataSetTableAdapters.Hospital_DetailsTableAdapter hospital_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}