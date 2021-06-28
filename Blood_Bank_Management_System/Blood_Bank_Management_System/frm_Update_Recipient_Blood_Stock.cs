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
    public partial class frm_Update_Recipient_Blood_Stock : Form
    {
        public frm_Update_Recipient_Blood_Stock()
        {
            InitializeComponent();       
        }

        #region SQL_Connection
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS3;Initial Catalog=Blood_Bank_Management_System_DB;Integrated Security=True; MultipleActiveResultSets=True");
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

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        #region ClearControls
        void ClearControls()
        {
            tb_ID.Clear();
            tb_Name.Clear();
            cmb_Blood_Group.SelectedIndex = -1;
            dtp_Date.ResetText();
            tb_Blood_Required.Clear();
            tb_Price.Clear();
            tb_Total_Bill.Clear();
            tb_ID.Enabled = true;
            tb_Blood_Required.Enabled = false;
        }
        #endregion

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * From Recipient_List where Recipient_ID = " + tb_ID.Text + "", Con);
                var obj = cmd.ExecuteReader();
                if (obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    dtp_Date.Text = (obj["Date"].ToString());
                    cmb_Blood_Group.Text = obj.GetString(obj.GetOrdinal("Blood_Group"));
                    //tb_Blood_Required.Text = (obj["Blood_Required"].ToString());
                    //tb_Price.Text = (obj["Price"].ToString());
                    //tb_Total_Bill.Text = (obj["Total_Bill"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Recipient ID Entered, Please Enter Valid ID.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                }

            }
            else
            {
                MessageBox.Show("Please Enter ID", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ID.Focus();
                tb_ID.Enabled = true;
            }

            Con_Close();

            if (tb_ID.Text != "")
            {
                tb_Blood_Required.Enabled = true;
            }
            else if (tb_ID.Text == "")
            {
                tb_Blood_Required.Enabled = false;
            }
        }

        private void tb_Blood_Required_TextChanged(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Blood_Required.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select Units From Stock_Details where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
                SqlDataAdapter sda = new SqlDataAdapter(Cmd);
                DataTable ds = new DataTable();
                sda.Fill(ds);

                if (ds.Rows.Count > 0)
                {
                    for (int j = 0; j < ds.Rows.Count; j++)
                    {
                        decimal Units = Convert.ToDecimal(ds.Rows[j]["Units"]);
                        decimal stock1 = Convert.ToDecimal(tb_Blood_Required.Text);

                        if (Units <= stock1)
                        {
                            MessageBox.Show("No Enough Stock Available. There is only " + Units + " Units available.", "Less Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tb_Blood_Required.Clear();
                        }
                    }
                }

                decimal Stock;
                decimal Price;
                decimal Total_Bill;

                if (tb_Blood_Required.Text != "")
                {
                    Stock = Convert.ToDecimal(tb_Blood_Required.Text);
                    Price = Convert.ToDecimal(tb_Price.Text);

                    Total_Bill = Stock * Price;

                    tb_Total_Bill.Text = Convert.ToString(Total_Bill);
                }
                else if (tb_Blood_Required.Text == "")
                {
                    tb_Total_Bill.Clear();
                }
            }
            else if (tb_Blood_Required.Text == "")
            {
                tb_Total_Bill.Clear();
            }

            Con_Close();
        }

        private void btn_Update_Stock_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_ID.Text != "" && tb_Name.Text != "" && dtp_Date.Text != "" && cmb_Blood_Group.Text != "" && tb_Price.Text != "" && tb_Total_Bill.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Recipient_List Set Date = '" + dtp_Date.Text + "', Blood_Required = " + tb_Blood_Required.Text + ", Price = " + tb_Price.Text + ", Total_Bill = " + tb_Total_Bill.Text + " where Recipient_ID = " + tb_ID.Text + " ", Con);
                cmd.ExecuteNonQuery();
                SqlCommand Cmd = new SqlCommand("Update Stock_Details Set Units = Units - " + tb_Blood_Required.Text + " where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Stock Updated Successfully,Bill Generated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
            }
            else
            {
                MessageBox.Show("Please Enter Recipient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void cmb_Blood_Group_TextChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Price from Stock_List_Price where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
            var obj = cmd.ExecuteReader();
            while (obj.Read())
            {
                tb_Price.Text = (obj["Price"].ToString());
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
