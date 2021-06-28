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
    public partial class frm_Increase_Stock : Form
    {
        public frm_Increase_Stock()
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
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void ClearControls()
        {
            cmb_Blood_Group.SelectedIndex = -1;
            tb_Unit.Clear();
        }

        private void frm_Increase_Stock_Load(object sender, EventArgs e)
        {           
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter(" Select Blood_Group,Units From Stock_Details ", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Increase_Stock.DataSource = dt;

            Con_Close();           
        }

        private void btn_Increase_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_Blood_Group.Text != "" && tb_Unit.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Stock_Details Set Units = Units+ " + tb_Unit.Text + " where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
                cmd.ExecuteNonQuery();               
                MessageBox.Show("Stock Updated Succesfully by " + tb_Unit.Text + " Units", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Increase_Stock_Load(this, null);
                ClearControls();
            }
            else
            {
                MessageBox.Show("Please Enter some value", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
