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
    public partial class frm_Add_New_Hospital : Form
    {
        public frm_Add_New_Hospital()
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

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Count(Hospital_ID) from Hospital_Details", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Hospital_ID) from Hospital_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }

        private void frm_Add_New_Hospital_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Convert.ToString(Auto_Incr());            

            if (Global_Vars.Ushow == 5)
            {
                tb_Contact_No_II.Text = "0";
                tb_ID.Focus();
                lbl_Header.Text = "Add New Hospital";                
                btn_Save.Visible = true;
                tb_Name.Enabled = true;
                tb_Contact_No_I.Enabled = true;
                tb_City.Enabled = true;
                rtb_Address.Enabled = true;
                btn_Refresh.Visible = true;
            }
            else if (Global_Vars.Ushow == 6)
            {
                tb_ID.Focus();
                tb_ID.Clear();
                tb_ID.Enabled = true;
                lbl_Header.Text = "Update Hospital Details";
                btn_Search.Visible = true;
                btn_Update.Visible = true;
                tb_Contact_No_I.Enabled = true;
                tb_Contact_No_II.Enabled = true;
                rtb_Address.Enabled = true;
                btn_Refresh1.Visible = true;
            }

        }
         
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char_Special_character(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock) || (e.KeyChar == ',')))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

            if (tb_Contact_No_II.Text == "0")
            {
                tb_Contact_No_II.Text = "";
            }
            else if (tb_Contact_No_II.Text == "")
            {
                tb_Contact_No_II.Text = "0";
            }
        }
  
        #region Clear_Controls
        void ClearControls()
        {
            tb_ID.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Contact_No_I.Clear();
            tb_Contact_No_II.Text = "0";
            tb_City.Clear();
            rtb_Address.Clear();
        }       

        void ClearControls2()
        {
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Contact_No_I.Clear();
            tb_Contact_No_II.Clear();
            tb_City.Clear();
            rtb_Address.Clear();
            tb_ID.Enabled = true;
        }
        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
           
            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Contact_No_I.Text != "" && tb_City.Text != "" && rtb_Address.Text != "")
            {                
                SqlCommand cmd = new SqlCommand("Insert Into Hospital_Details(Hospital_ID, Hospital_Name, Contact_No_I, Contact_No_II, City, Address, Date) values (" + tb_ID.Text + ", '" + tb_Name.Text + "', " + tb_Contact_No_I.Text + ", " + tb_Contact_No_II.Text + ", '" + tb_City.Text + "', '" + rtb_Address.Text + "', '" + dtp_Date.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                tb_ID.Enabled = false;
                tb_Name.Focus();
            }
            else
            {
                MessageBox.Show("First Fill all the information", "Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void tb_Contact_No_I_TextChanged(object sender, EventArgs e)
        {
            if (Global_Vars.Ushow == 5)
            {
                if (tb_Contact_No_I.Text != "")
                {
                    tb_Contact_No_II.Enabled = true;
                }
                else if (tb_Contact_No_I.Text == "")
                {
                    tb_Contact_No_II.Enabled = false;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_ID.Text != "")
            {
                SqlCommand CMD = new SqlCommand("Select * From Hospital_Details where Hospital_ID = " + tb_ID.Text + "", Con);
                var obj = CMD.ExecuteReader();
                if (obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Hospital_Name"));
                    tb_Contact_No_I.Text = (obj["Contact_No_I"].ToString());
                    tb_Contact_No_II.Text = (obj["Contact_No_II"].ToString());
                    tb_City.Text = obj.GetString(obj.GetOrdinal("City"));
                    rtb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                    dtp_Date.Text = (obj["Date"].ToString());
                }
                else
                {
                    MessageBox.Show("Incorrect ID Entered !!!", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls2();                   
                    tb_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Hospital ID", "ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearControls2();
            }

            Con_Close();

            if (tb_ID.Text != "")
            {
                tb_ID.Enabled = false;
            }
            else
            {
                tb_ID.Enabled = true;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "" && tb_Contact_No_I.Text != "" && tb_City.Text != "" && rtb_Address.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Update Hospital_Details Set Contact_No_I = " + tb_Contact_No_I.Text + ", Contact_No_II = " + tb_Contact_No_II.Text + ", Address = '" + rtb_Address.Text + "' where Hospital_ID = " + tb_ID.Text + " ", Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls2();               
                tb_ID.Focus();
            }
            else
            {              
                MessageBox.Show("Please Enter Hospital ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls2();
            }

            Con_Close();
        }

        private void btn_Refresh1_Click(object sender, EventArgs e)
        {
            ClearControls2();
        }
    }
}
