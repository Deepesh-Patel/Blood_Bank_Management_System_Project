using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Donor ob = new frm_Add_New_Donor();
            ob.Show();
            ob.MdiParent = this;
        }

        private void allDonorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_All_Donor_List ll = new frm_All_Donor_List();
            ll.Show();
            ll.MdiParent = this;
        }

        private void updateDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Donor_Details ud = new frm_Update_Donor_Details();
            Global_Vars.Ushow = 1;
            ud.Show();
            ud.MdiParent = this;           
        }

        private void addNewRecipientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Recipient nr = new frm_Add_New_Recipient();
            nr.Show();
            nr.MdiParent = this;
        }

        private void donorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Donor_Details sd = new frm_Update_Donor_Details();
            Global_Vars.Ushow = 2;
            sd.Show();
            sd.MdiParent = this;            
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Donor ds = new frm_Search_Donor();
            ds.Show();
            ds.MdiParent = this;
        }

        private void addNewHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Hospital ns = new frm_Add_New_Hospital();
            Global_Vars.Ushow = 5;
            ns.Show();
            ns.MdiParent = this;
            
        }
    
        private void updateRecipientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Recipient_Details rd = new frm_Update_Recipient_Details();
            Global_Vars.Ushow = 3;
            rd.Show();
            rd.MdiParent = this;
        }

        private void pcb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            timer2.Start();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Increase_Stock si = new frm_Increase_Stock();
            si.Show();
            si.MdiParent = this;
        }
      
        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock_Details sd = new frm_Stock_Details();
            sd.Show();
            sd.MdiParent = this;
        }

        private void allRecipientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_All_Recipient_List ar = new frm_All_Recipient_List();
            ar.Show();
            ar.MdiParent = this;
        }

        private void bloodGroupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Search_Recipient_BG bg = new frm_Search_Recipient_BG();
            bg.Show();
            bg.MdiParent = this;
        }

        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Recipient_Details id = new frm_Update_Recipient_Details();
            Global_Vars.Ushow = 4;
            id.Show();
            id.MdiParent = this;
        }

        private void hospitalListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_All_Hospital_List hl = new frm_All_Hospital_List();
            hl.Show();
            hl.MdiParent = this;
        }

        private void HospitalBillListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Blood_Stock_Requirement bs = new frm_Blood_Stock_Requirement();
            bs.Show();
            bs.MdiParent = this;
        }

        private void hospitalBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Hospital_Bill hb = new frm_Hospital_Bill();
            hb.Show();
            hb.MdiParent = this;
        }

        private void requiredBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Recipient_Blood_Stock rbs = new frm_Update_Recipient_Blood_Stock();
            rbs.Show();
            rbs.MdiParent = this;
        }

        private void bloodDonatedQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Donor_Blood_Quantity db = new frm_Update_Donor_Blood_Quantity();
            db.Show();
            db.MdiParent = this;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            Global_Vars.Username = "";
            if (MessageBox.Show("Are you sure!!! You want to exit Application ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {              
                //this.Close();
                timer3.Start();
                obj.Show();
            }           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_User.Text = Global_Vars.Username;

            if (Global_Vars.URole == 1)
            {
                bloodDonatedQuantityToolStripMenuItem.Visible = true;
                requiredBloodToolStripMenuItem.Visible = true;
                increaseToolStripMenuItem.Visible = true;
                AddStockPriceToolStripMenuItem.Visible = true;
                hospitalBillToolStripMenuItem.Visible = true;
            }
            else if(Global_Vars.URole == 2)
            {
                bloodDonatedQuantityToolStripMenuItem.Visible = false;
                requiredBloodToolStripMenuItem.Visible = false;
                increaseToolStripMenuItem.Visible = false;
                AddStockPriceToolStripMenuItem.Visible = false;
                hospitalBillToolStripMenuItem.Visible = false;
            }
        }

        private void AddStockPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Stock_Price sp = new frm_Stock_Price();
            sp.Show();
            sp.MdiParent = this;
        }

        private void updateHospitalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Hospital fg = new frm_Add_New_Hospital();
            Global_Vars.Ushow = 6;
            fg.Show();
            fg.MdiParent = this;
            
        }

        private void donorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Datewise_Report obj = new frm_Datewise_Report();
            Global_Vars.Ushow = 7;
            obj.Show();
        }

        private void recipientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Datewise_Report obj = new frm_Datewise_Report();
            Global_Vars.Ushow = 8;
            obj.Show();
        }

        private void hospitalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Datewise_Report obj = new frm_Datewise_Report();
            Global_Vars.Ushow = 9;
            obj.Show();
        }

        private void recipientToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Single_Report ob = new frm_Single_Report();
            Global_Vars.Ushow = 10;
            ob.Show();
        }

        private void hospitalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Single_Report ob = new frm_Single_Report();
            Global_Vars.Ushow = 11;
            ob.Show();
        }

        private void donorCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Single_Report obj = new frm_Single_Report();
            Global_Vars.Ushow = 12;
            obj.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();             
            }
            Opacity += .2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                Application.Exit();
            }
            Opacity -= .2;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Close();
            }
            Opacity -= .2;
        }
    }
}
