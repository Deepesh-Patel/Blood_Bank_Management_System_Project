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
    public partial class frm_Search_Donor : Form
    {
        public frm_Search_Donor()
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }
 
        private void frm_Search_Donor_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter(" Select * From Donor_Details ", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Search_Donor_BG.DataSource = dt;

            Con_Close();
        }

        private void btn_Refresh_Grid_Click(object sender, EventArgs e)
        {
            Con_Open();

            cmb_Blood_Group.SelectedIndex = -1;
           tb_Donor_ID.Clear();
            SqlDataAdapter sda = new SqlDataAdapter(" Select * From Donor_Details ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Search_Donor_BG.DataSource = dt;

            Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Donor_ID.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(" Select * From Donor_Details where Blood_Group = '" + cmb_Blood_Group.Text + "' And Donor_ID = " + tb_Donor_ID.Text + "  ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Search_Donor_BG.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please enter Valid Recipient ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void Load_Donor_Data(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * From Donor_Details where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Search_Donor_BG.DataSource = dt;

            Con_Close();
        }
    }
}
