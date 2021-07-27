namespace Blood_Bank_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.xuiClock1 = new XanderUI.XUIClock();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Logged_In_User = new System.Windows.Forms.Label();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDonorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDonorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodDonatedQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRecipientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRecipientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRecipientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requiredBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchRecipientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStockPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HospitalBillListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateHospitalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datewiseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recipientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.singleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipientToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.donorCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.xuiGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiClock1
            // 
            resources.ApplyResources(this.xuiClock1, "xuiClock1");
            this.xuiClock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // btn_Close
            // 
            resources.ApplyResources(this.btn_Close, "btn_Close");
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Logged_In_User
            // 
            resources.ApplyResources(this.lbl_Logged_In_User, "lbl_Logged_In_User");
            this.lbl_Logged_In_User.BackColor = System.Drawing.Color.Snow;
            this.lbl_Logged_In_User.Name = "lbl_Logged_In_User";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDonorToolStripMenuItem,
            this.allDonorListToolStripMenuItem,
            this.updateDonorDetailsToolStripMenuItem,
            this.bloodDonatedQuantityToolStripMenuItem});
            resources.ApplyResources(this.donorToolStripMenuItem, "donorToolStripMenuItem");
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            // 
            // addNewDonorToolStripMenuItem
            // 
            resources.ApplyResources(this.addNewDonorToolStripMenuItem, "addNewDonorToolStripMenuItem");
            this.addNewDonorToolStripMenuItem.Name = "addNewDonorToolStripMenuItem";
            this.addNewDonorToolStripMenuItem.Click += new System.EventHandler(this.addNewDonorToolStripMenuItem_Click);
            // 
            // allDonorListToolStripMenuItem
            // 
            resources.ApplyResources(this.allDonorListToolStripMenuItem, "allDonorListToolStripMenuItem");
            this.allDonorListToolStripMenuItem.Name = "allDonorListToolStripMenuItem";
            this.allDonorListToolStripMenuItem.Click += new System.EventHandler(this.allDonorListToolStripMenuItem_Click);
            // 
            // updateDonorDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.updateDonorDetailsToolStripMenuItem, "updateDonorDetailsToolStripMenuItem");
            this.updateDonorDetailsToolStripMenuItem.Name = "updateDonorDetailsToolStripMenuItem";
            this.updateDonorDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDonorDetailsToolStripMenuItem_Click);
            // 
            // bloodDonatedQuantityToolStripMenuItem
            // 
            resources.ApplyResources(this.bloodDonatedQuantityToolStripMenuItem, "bloodDonatedQuantityToolStripMenuItem");
            this.bloodDonatedQuantityToolStripMenuItem.Name = "bloodDonatedQuantityToolStripMenuItem";
            this.bloodDonatedQuantityToolStripMenuItem.Click += new System.EventHandler(this.bloodDonatedQuantityToolStripMenuItem_Click);
            // 
            // recipientToolStripMenuItem
            // 
            this.recipientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRecipientToolStripMenuItem,
            this.allRecipientListToolStripMenuItem,
            this.updateRecipientDetailsToolStripMenuItem,
            this.requiredBloodToolStripMenuItem});
            resources.ApplyResources(this.recipientToolStripMenuItem, "recipientToolStripMenuItem");
            this.recipientToolStripMenuItem.Name = "recipientToolStripMenuItem";
            // 
            // addNewRecipientToolStripMenuItem
            // 
            resources.ApplyResources(this.addNewRecipientToolStripMenuItem, "addNewRecipientToolStripMenuItem");
            this.addNewRecipientToolStripMenuItem.Name = "addNewRecipientToolStripMenuItem";
            this.addNewRecipientToolStripMenuItem.Click += new System.EventHandler(this.addNewRecipientToolStripMenuItem_Click);
            // 
            // allRecipientListToolStripMenuItem
            // 
            resources.ApplyResources(this.allRecipientListToolStripMenuItem, "allRecipientListToolStripMenuItem");
            this.allRecipientListToolStripMenuItem.Name = "allRecipientListToolStripMenuItem";
            this.allRecipientListToolStripMenuItem.Click += new System.EventHandler(this.allRecipientListToolStripMenuItem_Click);
            // 
            // updateRecipientDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.updateRecipientDetailsToolStripMenuItem, "updateRecipientDetailsToolStripMenuItem");
            this.updateRecipientDetailsToolStripMenuItem.Name = "updateRecipientDetailsToolStripMenuItem";
            this.updateRecipientDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateRecipientDetailsToolStripMenuItem_Click);
            // 
            // requiredBloodToolStripMenuItem
            // 
            resources.ApplyResources(this.requiredBloodToolStripMenuItem, "requiredBloodToolStripMenuItem");
            this.requiredBloodToolStripMenuItem.Name = "requiredBloodToolStripMenuItem";
            this.requiredBloodToolStripMenuItem.Click += new System.EventHandler(this.requiredBloodToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchDonorToolStripMenuItem,
            this.searchRecipientToolStripMenuItem});
            resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            // 
            // searchDonorToolStripMenuItem
            // 
            this.searchDonorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorIDToolStripMenuItem,
            this.bloodGroupToolStripMenuItem});
            resources.ApplyResources(this.searchDonorToolStripMenuItem, "searchDonorToolStripMenuItem");
            this.searchDonorToolStripMenuItem.Name = "searchDonorToolStripMenuItem";
            // 
            // donorIDToolStripMenuItem
            // 
            resources.ApplyResources(this.donorIDToolStripMenuItem, "donorIDToolStripMenuItem");
            this.donorIDToolStripMenuItem.Name = "donorIDToolStripMenuItem";
            this.donorIDToolStripMenuItem.Click += new System.EventHandler(this.donorIDToolStripMenuItem_Click);
            // 
            // bloodGroupToolStripMenuItem
            // 
            resources.ApplyResources(this.bloodGroupToolStripMenuItem, "bloodGroupToolStripMenuItem");
            this.bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            this.bloodGroupToolStripMenuItem.Click += new System.EventHandler(this.bloodGroupToolStripMenuItem_Click);
            // 
            // searchRecipientToolStripMenuItem
            // 
            this.searchRecipientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem,
            this.bloodGroupToolStripMenuItem1});
            resources.ApplyResources(this.searchRecipientToolStripMenuItem, "searchRecipientToolStripMenuItem");
            this.searchRecipientToolStripMenuItem.Name = "searchRecipientToolStripMenuItem";
            // 
            // iDToolStripMenuItem
            // 
            resources.ApplyResources(this.iDToolStripMenuItem, "iDToolStripMenuItem");
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Click += new System.EventHandler(this.iDToolStripMenuItem_Click);
            // 
            // bloodGroupToolStripMenuItem1
            // 
            resources.ApplyResources(this.bloodGroupToolStripMenuItem1, "bloodGroupToolStripMenuItem1");
            this.bloodGroupToolStripMenuItem1.Name = "bloodGroupToolStripMenuItem1";
            this.bloodGroupToolStripMenuItem1.Click += new System.EventHandler(this.bloodGroupToolStripMenuItem1_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.AddStockPriceToolStripMenuItem,
            this.stockDetailsToolStripMenuItem});
            resources.ApplyResources(this.stockToolStripMenuItem, "stockToolStripMenuItem");
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            // 
            // increaseToolStripMenuItem
            // 
            resources.ApplyResources(this.increaseToolStripMenuItem, "increaseToolStripMenuItem");
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // AddStockPriceToolStripMenuItem
            // 
            resources.ApplyResources(this.AddStockPriceToolStripMenuItem, "AddStockPriceToolStripMenuItem");
            this.AddStockPriceToolStripMenuItem.Name = "AddStockPriceToolStripMenuItem";
            this.AddStockPriceToolStripMenuItem.Click += new System.EventHandler(this.AddStockPriceToolStripMenuItem_Click);
            // 
            // stockDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.stockDetailsToolStripMenuItem, "stockDetailsToolStripMenuItem");
            this.stockDetailsToolStripMenuItem.Name = "stockDetailsToolStripMenuItem";
            this.stockDetailsToolStripMenuItem.Click += new System.EventHandler(this.stockDetailsToolStripMenuItem_Click);
            // 
            // hospitalToolStripMenuItem
            // 
            this.hospitalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewHospitalToolStripMenuItem,
            this.hospitalListToolStripMenuItem,
            this.HospitalBillListToolStripMenuItem,
            this.hospitalBillToolStripMenuItem,
            this.updateHospitalDetailsToolStripMenuItem});
            resources.ApplyResources(this.hospitalToolStripMenuItem, "hospitalToolStripMenuItem");
            this.hospitalToolStripMenuItem.Name = "hospitalToolStripMenuItem";
            // 
            // addNewHospitalToolStripMenuItem
            // 
            resources.ApplyResources(this.addNewHospitalToolStripMenuItem, "addNewHospitalToolStripMenuItem");
            this.addNewHospitalToolStripMenuItem.Name = "addNewHospitalToolStripMenuItem";
            this.addNewHospitalToolStripMenuItem.Click += new System.EventHandler(this.addNewHospitalToolStripMenuItem_Click);
            // 
            // hospitalListToolStripMenuItem
            // 
            resources.ApplyResources(this.hospitalListToolStripMenuItem, "hospitalListToolStripMenuItem");
            this.hospitalListToolStripMenuItem.Name = "hospitalListToolStripMenuItem";
            this.hospitalListToolStripMenuItem.Click += new System.EventHandler(this.hospitalListToolStripMenuItem_Click);
            // 
            // HospitalBillListToolStripMenuItem
            // 
            resources.ApplyResources(this.HospitalBillListToolStripMenuItem, "HospitalBillListToolStripMenuItem");
            this.HospitalBillListToolStripMenuItem.Name = "HospitalBillListToolStripMenuItem";
            this.HospitalBillListToolStripMenuItem.Click += new System.EventHandler(this.HospitalBillListToolStripMenuItem_Click);
            // 
            // hospitalBillToolStripMenuItem
            // 
            resources.ApplyResources(this.hospitalBillToolStripMenuItem, "hospitalBillToolStripMenuItem");
            this.hospitalBillToolStripMenuItem.Name = "hospitalBillToolStripMenuItem";
            this.hospitalBillToolStripMenuItem.Click += new System.EventHandler(this.hospitalBillToolStripMenuItem_Click);
            // 
            // updateHospitalDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.updateHospitalDetailsToolStripMenuItem, "updateHospitalDetailsToolStripMenuItem");
            this.updateHospitalDetailsToolStripMenuItem.Name = "updateHospitalDetailsToolStripMenuItem";
            this.updateHospitalDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateHospitalDetailsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.recipientToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.hospitalToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datewiseReportsToolStripMenuItem,
            this.singleReportToolStripMenuItem});
            resources.ApplyResources(this.reportsToolStripMenuItem, "reportsToolStripMenuItem");
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            // 
            // datewiseReportsToolStripMenuItem
            // 
            this.datewiseReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem1,
            this.recipientToolStripMenuItem1,
            this.hospitalToolStripMenuItem1});
            resources.ApplyResources(this.datewiseReportsToolStripMenuItem, "datewiseReportsToolStripMenuItem");
            this.datewiseReportsToolStripMenuItem.Name = "datewiseReportsToolStripMenuItem";
            // 
            // donorToolStripMenuItem1
            // 
            resources.ApplyResources(this.donorToolStripMenuItem1, "donorToolStripMenuItem1");
            this.donorToolStripMenuItem1.Name = "donorToolStripMenuItem1";
            this.donorToolStripMenuItem1.Click += new System.EventHandler(this.donorToolStripMenuItem1_Click);
            // 
            // recipientToolStripMenuItem1
            // 
            resources.ApplyResources(this.recipientToolStripMenuItem1, "recipientToolStripMenuItem1");
            this.recipientToolStripMenuItem1.Name = "recipientToolStripMenuItem1";
            this.recipientToolStripMenuItem1.Click += new System.EventHandler(this.recipientToolStripMenuItem1_Click);
            // 
            // hospitalToolStripMenuItem1
            // 
            resources.ApplyResources(this.hospitalToolStripMenuItem1, "hospitalToolStripMenuItem1");
            this.hospitalToolStripMenuItem1.Name = "hospitalToolStripMenuItem1";
            this.hospitalToolStripMenuItem1.Click += new System.EventHandler(this.hospitalToolStripMenuItem1_Click);
            // 
            // singleReportToolStripMenuItem
            // 
            this.singleReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipientToolStripMenuItem2,
            this.hospitalToolStripMenuItem2,
            this.donorCertificateToolStripMenuItem});
            resources.ApplyResources(this.singleReportToolStripMenuItem, "singleReportToolStripMenuItem");
            this.singleReportToolStripMenuItem.Name = "singleReportToolStripMenuItem";
            // 
            // recipientToolStripMenuItem2
            // 
            resources.ApplyResources(this.recipientToolStripMenuItem2, "recipientToolStripMenuItem2");
            this.recipientToolStripMenuItem2.Name = "recipientToolStripMenuItem2";
            this.recipientToolStripMenuItem2.Click += new System.EventHandler(this.recipientToolStripMenuItem2_Click);
            // 
            // hospitalToolStripMenuItem2
            // 
            resources.ApplyResources(this.hospitalToolStripMenuItem2, "hospitalToolStripMenuItem2");
            this.hospitalToolStripMenuItem2.Name = "hospitalToolStripMenuItem2";
            this.hospitalToolStripMenuItem2.Click += new System.EventHandler(this.hospitalToolStripMenuItem2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 50;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // xuiGradientPanel1
            // 
            resources.ApplyResources(this.xuiGradientPanel1, "xuiGradientPanel1");
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.IndianRed;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Coral;
            this.xuiGradientPanel1.Controls.Add(this.lbl_Title);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // lbl_Title
            // 
            resources.ApplyResources(this.lbl_Title, "lbl_Title");
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Name = "lbl_Title";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // donorCertificateToolStripMenuItem
            // 
            resources.ApplyResources(this.donorCertificateToolStripMenuItem, "donorCertificateToolStripMenuItem");
            this.donorCertificateToolStripMenuItem.Name = "donorCertificateToolStripMenuItem";
            this.donorCertificateToolStripMenuItem.Click += new System.EventHandler(this.donorCertificateToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Logged_In_User);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.xuiClock1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Opacity = 0D;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.xuiGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Logged_In_User;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDonorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDonorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodDonatedQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRecipientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRecipientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRecipientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requiredBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchRecipientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddStockPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HospitalBillListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateHospitalDetailsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datewiseReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recipientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hospitalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem singleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipientToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hospitalToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem donorCertificateToolStripMenuItem;
    }
}