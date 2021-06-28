using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Blood_Bank_Management_System
{
    public partial class frm_All_Donor_List : Form
    {
        public frm_All_Donor_List()
        {
            InitializeComponent();
        }

        #region SQL_Connection
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS3;Initial Catalog=Blood_Bank_Management_System_DB;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_All_Donor_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet1.Donor_Details' table. You can move, or remove it, as needed.
            this.donor_DetailsTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet1.Donor_Details);
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet1.Donor_Details' table. You can move, or remove it, as needed.
            this.donor_DetailsTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet1.Donor_Details);

            lbl_Number.Text = dgv_Donor_Details.Rows.Count.ToString();
        }
    }
}
