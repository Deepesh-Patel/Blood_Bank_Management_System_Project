namespace Blood_Bank_Management_System
{
    partial class frm_Single_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Single_Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crv_single_view = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Hospital_Report_Show = new System.Windows.Forms.Button();
            this.btn_Show_Report = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.crv_single_view);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1527, 649);
            this.panel1.TabIndex = 0;
            // 
            // crv_single_view
            // 
            this.crv_single_view.ActiveViewIndex = -1;
            this.crv_single_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_single_view.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_single_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_single_view.Location = new System.Drawing.Point(0, 0);
            this.crv_single_view.Name = "crv_single_view";
            this.crv_single_view.ShowLogo = false;
            this.crv_single_view.Size = new System.Drawing.Size(1527, 649);
            this.crv_single_view.TabIndex = 0;
            this.crv_single_view.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lbl_ID
            // 
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Georgia", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ID.Image")));
            this.lbl_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ID.Location = new System.Drawing.Point(235, 45);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(203, 27);
            this.lbl_ID.TabIndex = 89;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(527, 44);
            this.tb_ID.MaxLength = 30;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(298, 31);
            this.tb_ID.TabIndex = 90;
            // 
            // btn_Hospital_Report_Show
            // 
            this.btn_Hospital_Report_Show.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Hospital_Report_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Hospital_Report_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hospital_Report_Show.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hospital_Report_Show.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hospital_Report_Show.Image")));
            this.btn_Hospital_Report_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hospital_Report_Show.Location = new System.Drawing.Point(949, 35);
            this.btn_Hospital_Report_Show.Name = "btn_Hospital_Report_Show";
            this.btn_Hospital_Report_Show.Size = new System.Drawing.Size(206, 44);
            this.btn_Hospital_Report_Show.TabIndex = 91;
            this.btn_Hospital_Report_Show.Text = "Show Report";
            this.btn_Hospital_Report_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Hospital_Report_Show.UseVisualStyleBackColor = false;
            this.btn_Hospital_Report_Show.Visible = false;
            this.btn_Hospital_Report_Show.Click += new System.EventHandler(this.btn_Hospital_Report_Show_Click);
            // 
            // btn_Show_Report
            // 
            this.btn_Show_Report.BackColor = System.Drawing.Color.Snow;
            this.btn_Show_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Show_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Show_Report.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Report.Image = ((System.Drawing.Image)(resources.GetObject("btn_Show_Report.Image")));
            this.btn_Show_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Show_Report.Location = new System.Drawing.Point(949, 35);
            this.btn_Show_Report.Name = "btn_Show_Report";
            this.btn_Show_Report.Size = new System.Drawing.Size(206, 44);
            this.btn_Show_Report.TabIndex = 12;
            this.btn_Show_Report.Text = "Show Report";
            this.btn_Show_Report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Show_Report.UseVisualStyleBackColor = false;
            this.btn_Show_Report.Visible = false;
            this.btn_Show_Report.Click += new System.EventHandler(this.btn_Show_Report_Click);
            // 
            // frm_Single_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1527, 789);
            this.Controls.Add(this.btn_Show_Report);
            this.Controls.Add(this.btn_Hospital_Report_Show);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_Single_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Single_Report_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_single_view;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_Hospital_Report_Show;
        private System.Windows.Forms.Button btn_Show_Report;

    }
}