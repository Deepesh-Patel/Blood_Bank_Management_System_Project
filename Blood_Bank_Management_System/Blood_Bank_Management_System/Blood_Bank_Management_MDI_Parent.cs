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
    public partial class Blood_Bank_Management_MDI_Parent : Form
    {
        public Blood_Bank_Management_MDI_Parent()
        {
            InitializeComponent();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Donor ob = new frm_Add_New_Donor();
            ob.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allDonorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_All_Donor_List wd = new frm_All_Donor_List();
            wd.Show();
        }

        private void updateDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Donor_Details obj = new frm_Update_Donor_Details();
            obj.Show();
        }

        private void addNewRecipientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Recipient re = new frm_Add_New_Recipient();
            re.Show();
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
