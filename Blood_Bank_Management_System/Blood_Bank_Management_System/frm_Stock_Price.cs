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
    public partial class frm_Stock_Price : Form
    {
        public frm_Stock_Price()
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

        private void btn_Close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ClearControls()
        {
            cmb_Blood_Group.SelectedIndex = -1;
            tb_Price.Clear();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void frm_Stock_Price_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select Blood_Group, Price From Stock_List_Price", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Stock_Price.DataSource = dt;

            Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Price.Text != "" && cmb_Blood_Group.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Stock_List_Price Set Price = " + tb_Price.Text + " where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Price Updated Successfully !!!", "Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Stock_Price_Load(this, null);
                ClearControls();
                cmb_Blood_Group.Focus();
            }
            else
            {
                MessageBox.Show("Please Select Blood type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }      
    }
}
