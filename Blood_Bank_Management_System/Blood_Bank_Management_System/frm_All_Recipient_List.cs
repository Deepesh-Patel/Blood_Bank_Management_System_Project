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
    public partial class frm_All_Recipient_List : Form
    { 
        public frm_All_Recipient_List()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_All_Recipient_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet2.Recipient_List' table. You can move, or remove it, as needed.
            this.recipient_ListTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet2.Recipient_List);
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet2.Recipient_List' table. You can move, or remove it, as needed.
            this.recipient_ListTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet2.Recipient_List);

            lbl_Number.Text = dgv_Recipient_List.Rows.Count.ToString();
        }
    }
}
