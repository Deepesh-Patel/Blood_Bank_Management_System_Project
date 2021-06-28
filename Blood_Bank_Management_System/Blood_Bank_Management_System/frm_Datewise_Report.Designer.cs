namespace Blood_Bank_Management_System
{
    partial class frm_Datewise_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Datewise_Report));
            this.pnl_Report = new System.Windows.Forms.Panel();
            this.crv_Recipient_List_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.btn_Show_Report = new System.Windows.Forms.Button();
            this.btn_Donor_Report_Show = new System.Windows.Forms.Button();
            this.btn_Hospital_Report_Show = new System.Windows.Forms.Button();
            this.pnl_Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Report
            // 
            this.pnl_Report.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Report.Controls.Add(this.crv_Recipient_List_Viewer);
            this.pnl_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Report.Location = new System.Drawing.Point(0, 127);
            this.pnl_Report.Name = "pnl_Report";
            this.pnl_Report.Size = new System.Drawing.Size(1461, 615);
            this.pnl_Report.TabIndex = 0;
            // 
            // crv_Recipient_List_Viewer
            // 
            this.crv_Recipient_List_Viewer.ActiveViewIndex = -1;
            this.crv_Recipient_List_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Recipient_List_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Recipient_List_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Recipient_List_Viewer.Location = new System.Drawing.Point(0, 0);
            this.crv_Recipient_List_Viewer.Name = "crv_Recipient_List_Viewer";
            this.crv_Recipient_List_Viewer.ShowLogo = false;
            this.crv_Recipient_List_Viewer.Size = new System.Drawing.Size(1461, 615);
            this.crv_Recipient_List_Viewer.TabIndex = 0;
            this.crv_Recipient_List_Viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.BackColor = System.Drawing.Color.Transparent;
            this.lbl_From.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(119, 46);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(135, 27);
            this.lbl_From.TabIndex = 88;
            this.lbl_From.Text = "Date From";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.BackColor = System.Drawing.Color.Transparent;
            this.lbl_To.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.Location = new System.Drawing.Point(694, 46);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(35, 27);
            this.lbl_To.TabIndex = 88;
            this.lbl_To.Text = "to";
            // 
            // dtp_From
            // 
            this.dtp_From.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From.Location = new System.Drawing.Point(306, 44);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(277, 29);
            this.dtp_From.TabIndex = 89;
            // 
            // dtp_To
            // 
            this.dtp_To.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To.Location = new System.Drawing.Point(793, 44);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(277, 29);
            this.dtp_To.TabIndex = 89;
            // 
            // btn_Show_Report
            // 
            this.btn_Show_Report.BackColor = System.Drawing.Color.Snow;
            this.btn_Show_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Show_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Show_Report.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Report.Image = ((System.Drawing.Image)(resources.GetObject("btn_Show_Report.Image")));
            this.btn_Show_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Show_Report.Location = new System.Drawing.Point(1159, 36);
            this.btn_Show_Report.Name = "btn_Show_Report";
            this.btn_Show_Report.Size = new System.Drawing.Size(206, 44);
            this.btn_Show_Report.TabIndex = 11;
            this.btn_Show_Report.Text = "Show Report";
            this.btn_Show_Report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Show_Report.UseVisualStyleBackColor = false;
            this.btn_Show_Report.Visible = false;
            this.btn_Show_Report.Click += new System.EventHandler(this.btn_Show_Report_Click);
            // 
            // btn_Donor_Report_Show
            // 
            this.btn_Donor_Report_Show.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Donor_Report_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Donor_Report_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Donor_Report_Show.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Donor_Report_Show.Image = ((System.Drawing.Image)(resources.GetObject("btn_Donor_Report_Show.Image")));
            this.btn_Donor_Report_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Donor_Report_Show.Location = new System.Drawing.Point(1159, 36);
            this.btn_Donor_Report_Show.Name = "btn_Donor_Report_Show";
            this.btn_Donor_Report_Show.Size = new System.Drawing.Size(206, 44);
            this.btn_Donor_Report_Show.TabIndex = 12;
            this.btn_Donor_Report_Show.Text = "Show Report";
            this.btn_Donor_Report_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Donor_Report_Show.UseVisualStyleBackColor = false;
            this.btn_Donor_Report_Show.Visible = false;
            this.btn_Donor_Report_Show.Click += new System.EventHandler(this.btn_Donor_Report_Show_Click);
            // 
            // btn_Hospital_Report_Show
            // 
            this.btn_Hospital_Report_Show.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Hospital_Report_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Hospital_Report_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hospital_Report_Show.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hospital_Report_Show.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hospital_Report_Show.Image")));
            this.btn_Hospital_Report_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hospital_Report_Show.Location = new System.Drawing.Point(1159, 36);
            this.btn_Hospital_Report_Show.Name = "btn_Hospital_Report_Show";
            this.btn_Hospital_Report_Show.Size = new System.Drawing.Size(206, 44);
            this.btn_Hospital_Report_Show.TabIndex = 12;
            this.btn_Hospital_Report_Show.Text = "Show Report";
            this.btn_Hospital_Report_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Hospital_Report_Show.UseVisualStyleBackColor = false;
            this.btn_Hospital_Report_Show.Visible = false;
            this.btn_Hospital_Report_Show.Click += new System.EventHandler(this.btn_Hospital_Report_Show_Click);
            // 
            // frm_Datewise_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1461, 742);
            this.Controls.Add(this.btn_Hospital_Report_Show);
            this.Controls.Add(this.btn_Donor_Report_Show);
            this.Controls.Add(this.btn_Show_Report);
            this.Controls.Add(this.dtp_To);
            this.Controls.Add(this.dtp_From);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.pnl_Report);
            this.MaximizeBox = false;
            this.Name = "frm_Datewise_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Datewise_Report_Load);
            this.pnl_Report.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Report;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Recipient_List_Viewer;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.Button btn_Show_Report;
        private System.Windows.Forms.Button btn_Donor_Report_Show;
        private System.Windows.Forms.Button btn_Hospital_Report_Show;
    }
}