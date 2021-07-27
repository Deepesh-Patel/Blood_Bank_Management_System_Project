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
    public partial class frm_Update_Donor_Blood_Quantity : Form
    {
        public frm_Update_Donor_Blood_Quantity()
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

        #region ClearControls
        void ClearControls()
        {
            tb_Donor_ID.Clear();
            tb_Name.Clear();
            cmb_Blood_Group.SelectedIndex = -1;
            dtp_Date.ResetText();
            tb_Blood_Donated.Clear();
        }
        #endregion

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Donor_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * From Donor_Details where Donor_ID = " + tb_Donor_ID.Text + "", Con);
                var obj = cmd.ExecuteReader();
                if (obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    cmb_Blood_Group.Text = obj.GetString(obj.GetOrdinal("Blood_Group"));
                    //dtp_Date.Text = (obj["Date"].ToString());
                    tb_Blood_Donated.Text = (obj["Blood_Donated"].ToString());
                }
                else
                {
                    MessageBox.Show("Incorrect ID Entered !!!", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Donor_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Donor ID", "ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Update_Stock_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Blood_Donated.Text != "" && cmb_Blood_Group.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Donor_Details Set Blood_Donated = " + tb_Blood_Donated.Text + ", Date = '" + dtp_Date.Text + "' where Donor_ID = " + tb_Donor_ID.Text + " ", Con);
                cmd.ExecuteNonQuery();
                SqlCommand Cmd = new SqlCommand("Update Stock_Details Set Units= Units+ " + tb_Blood_Donated.Text + " where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Stock Updated Successfully !!!", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
            }
            else
            {
                MessageBox.Show("Please Enter Some Value !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
