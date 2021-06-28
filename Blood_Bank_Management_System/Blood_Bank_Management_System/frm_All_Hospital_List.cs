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
    public partial class frm_All_Hospital_List : Form
    {
        public frm_All_Hospital_List()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_All_Hospital_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet.Hospital_Details' table. You can move, or remove it, as needed.
            this.hospital_DetailsTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet.Hospital_Details);
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet.Hospital_Details' table. You can move, or remove it, as needed.
            this.hospital_DetailsTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet.Hospital_Details);
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet.Hospital_Details' table. You can move, or remove it, as needed.
            this.hospital_DetailsTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet.Hospital_Details);
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet.Hospital_Details' table. You can move, or remove it, as needed.
            this.hospital_DetailsTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet.Hospital_Details);

            //lbl_Number.Text = dt.Rows.Count.ToString();
            lbl_Number.Text = dgv_Hospital_List.Rows.Count.ToString();
        }
    }
}
