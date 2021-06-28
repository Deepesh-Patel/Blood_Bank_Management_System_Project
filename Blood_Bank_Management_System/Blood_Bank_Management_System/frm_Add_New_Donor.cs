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
    public partial class frm_Add_New_Donor : Form
    {
        public frm_Add_New_Donor()
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
            SqlCommand Cmd = new SqlCommand("Select Count(Donor_ID) from Donor_Details", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Donor_ID) from Donor_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1001;
            }

            Con_Close();

            return Cnt;
        }

        private void frm_Add_New_Donor_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = Convert.ToString(Auto_Incr());
        }
 
        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void Only_Char_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == '.') || (e.KeyChar == '@'))))
            {
                e.Handled = true;
            }
        }
    
        #region Clear_Controls
        void Clear_Controls()
        {
            lbl_ID.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();           
            tb_Mob_No.Clear();
            rd_btn_Male.Checked = false;
            rd_btn_Female.Checked = false;
            rd_btn_Other.Checked = false;
            tb_Aadhar_Card.Clear();
            tb_Email.Clear();
            tb_Age.Clear();
            rd_btn_Yes.Checked = false;
            rd_btn_No.Checked = true;
            cmb_Blood_Group.SelectedIndex = -1;
            tb_Weight.Clear();
            tb_City.Clear();
            rtb_Address.Clear();
            tb_Blood_Donated.Clear();
            dtp_Date.ResetText();
            btn_Next.Enabled = false;
        }
        #endregion
 
        private void btn_Close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            string Gender = "";
            string Disease = "";

            if (rd_btn_Male.Checked == true)
            {
                Gender = rd_btn_Male.Text;
            }
            else if (rd_btn_Female.Checked == true)
            {
                Gender = rd_btn_Female.Text;
            }
            else
            {
                Gender = rd_btn_Other.Text;
            }

            if (rd_btn_Yes.Checked == true)
            {
                Disease = rd_btn_Yes.Text;
            }
            else
            {
                Disease = rd_btn_No.Text;
            }
            
            if (tb_Name.Text != "" && dtp_Dob.Text != "" && tb_Mob_No.Text != "" && Gender != "" && tb_Aadhar_Card.Text != "" && tb_Email.Text != "" && tb_Age.Text != "" && Disease != "" && cmb_Blood_Group.Text != "" && tb_Weight.Text != "" && tb_City.Text != "" && rtb_Address.Text != "" && tb_Blood_Donated.Text != "" && dtp_Date.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert into Donor_Details values(" + lbl_ID.Text + " ,'" + tb_Name.Text + "' ,'" + dtp_Dob.Text + "' ," + tb_Mob_No.Text + " ,'" + Gender + "' ," + tb_Aadhar_Card.Text + " ,'" + tb_Email.Text + "' ," + tb_Age.Text + " ,'" + Disease + "' ,'" + cmb_Blood_Group.Text + "' ," + tb_Weight.Text + " ,'" + tb_City.Text + "' ,'" + rtb_Address.Text + "' ," + tb_Blood_Donated.Text + " ,'" + dtp_Date.Text + "')", Con);
                Cmd.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("Update Stock_Details Set Units =Units+ " + tb_Blood_Donated.Text + " where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved! Thankyou "+tb_Name.Text+" for registering for Blood Donation.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
                tb_Name.Focus();                
            }
            else
            {
                MessageBox.Show("Fill all the information", "Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
                   
        private void btn_Next_Click(object sender, EventArgs e)
        {
            tbp_Add_Donor.SelectTab(tbp_Donor_Blood_Donated);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            tbp_Add_Donor.SelectTab(tbp_Donor_Details);
        }

        private void dtp_Dob_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dtp_Dob.Value;
            DateTime to = DateTime.Now;
            TimeSpan TSpan = to - from;
            double days = TSpan.TotalDays;
            tb_Age.Text = (days / 365).ToString("0");

            decimal Age;
            Age = Convert.ToDecimal(tb_Age.Text);
            if (Age < 18)
            {
                MessageBox.Show("Age should be minimum of 18 yrs", "Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Age.Clear();
            }
            else if (Age > 60)
            {
                MessageBox.Show("Age should be maximum of 60 yrs", "Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Age.Clear();
            }
        }

        private void rd_btn_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_btn_Yes.Checked == true)
            {
                MessageBox.Show("You cannot donate blood. You have to wait atleast 7 days.", "Diseased Person", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                rd_btn_Yes.Checked = false;
            }
        }

        private void tb_Aadhar_Card_TextChanged(object sender, EventArgs e)
        {
            if (tb_Aadhar_Card.Text != "")
            {
                btn_Next.Enabled = true;
            }
            else if (tb_Aadhar_Card.Text == "")
            {
                btn_Next.Enabled = false;
            }
        }
    }
}
