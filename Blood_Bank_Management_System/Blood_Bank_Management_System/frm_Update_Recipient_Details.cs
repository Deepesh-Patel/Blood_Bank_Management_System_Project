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
    public partial class frm_Update_Recipient_Details : Form
    {
        public frm_Update_Recipient_Details()
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
      
        private void frm_Update_Recipient_Details_Load(object sender, EventArgs e)
        {
            if (Global_Vars.Ushow == 3)
            {
                lbl_Header.Text = "Update Recipient Details";
                btn_Update.Visible = true;                
                tb_Mob_No.Enabled = true;                
                tb_Email.Enabled = true;                
                tb_Weight.Enabled = true;
                tb_City.Enabled = true;
                rtb_Address.Enabled = true;
                tb_Blood_Required.Enabled = true;
            }
            else if (Global_Vars.Ushow == 4)
            {
                lbl_Header.Text = "Search Recipient Details";
                btn_Update.Visible = false;
                tb_Blood_Required.Visible = true;
                dtp_Date.Visible = true;
                tb_Price.Visible = true;
                tb_Total_Bill.Visible = true;
                lbl_Stock_Required.Visible = true;
                lbl_Date.Visible = true;
                lbl_Price.Visible = true;
                lbl_Total_Bill.Visible = true;
            }
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

        private void Only_Char_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == '.') || (e.KeyChar == '@') || (e.KeyChar == ','))))
            {
                e.Handled = true;
            }
        }
               
        private void dtp_Dob_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dtp_Dob.Value;
            DateTime to = DateTime.Now;
            TimeSpan TSpan = to - from;
            double days = TSpan.TotalDays;
            tb_Age.Text = (days / 365).ToString("0");
        }
       
        #region ClearControls_Method
        void ClearControls()
        {
            tb_Recipient_ID.Clear();
            tb_Name.Clear();
            dtp_Dob.ResetText();
            tb_Mob_No.Clear();
            rd_btn_Male.Checked = false;
            rd_btn_Female.Checked = false;
            rd_btn_Other.Checked = false;
            tb_Aadhar_Card.Clear();
            tb_Age.Clear();
            cmb_Blood_Group.SelectedIndex = -1;
            tb_Weight.Clear();
            tb_City.Clear();
            rtb_Address.Clear();
            tb_Email.Clear();
            tb_Blood_Required.Clear();
            dtp_Date.ResetText();
            tb_Price.Clear();
            tb_Total_Bill.Clear();
            tb_Recipient_ID.Enabled = true;
        }
        #endregion

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            string Gender = "";

            if(tb_Recipient_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * From Recipient_List where Recipient_ID = " +tb_Recipient_ID.Text + "" ,Con);
                var obj = cmd.ExecuteReader();
                if(obj.Read())
                {
                    tb_Recipient_ID.Enabled = false;
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    dtp_Dob.Text = (obj["DOB"].ToString());
                    tb_Mob_No.Text = (obj["Mob_No"].ToString());
                    Gender = obj.GetString(obj.GetOrdinal("Gender"));

                    if (Gender == "Male")
                    {
                        rd_btn_Male.Checked = true;
                    }
                    else if (Gender == "Female")
                    {
                        rd_btn_Female.Checked = true;
                    }
                    else
                    {
                        rd_btn_Other.Checked = true;
                    }

                    tb_Aadhar_Card.Text = (obj["Aadhar_Card"].ToString());
                    tb_Age.Text = (obj["Age"].ToString());
                    cmb_Blood_Group.Text = obj.GetString(obj.GetOrdinal("Blood_Group"));
                    tb_Weight.Text = (obj["Weight"].ToString());
                    tb_City.Text = obj.GetString(obj.GetOrdinal("City"));
                    rtb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                    tb_Email.Text = obj.GetString(obj.GetOrdinal("Email_ID"));
                    tb_Blood_Required.Text = (obj["Blood_Required"].ToString());
                    dtp_Date.Text = (obj["Date"].ToString());
                    tb_Price.Text = (obj["Price"].ToString());
                    tb_Total_Bill.Text = (obj["Total_Bill"].ToString());
                }
                else
                {                    
                    MessageBox.Show("Incorrect ID Entered !!!", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                    tb_Recipient_ID.Enabled = true;
                    tb_Recipient_ID.Focus();                    
                }
            }
            else
            {
                MessageBox.Show("Please Enter Recipient ID", "ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                tb_Recipient_ID.Focus();
                tb_Recipient_ID.Enabled = true;
            }
            Con_Close();
            
            if (tb_Recipient_ID.Text != "")
            {
                tb_Recipient_ID.Enabled = false;
            }
            else
            {
                tb_Recipient_ID.Enabled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            string Gender = "";
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
                        
            if (tb_Recipient_ID.Text != "" && tb_Name.Text != "" && dtp_Dob.Text != "" && tb_Mob_No.Text != "" && Gender != "" && tb_Aadhar_Card.Text != "" && tb_Age.Text != "" && cmb_Blood_Group.Text != "" && tb_Weight.Text != "" && tb_City.Text != "" && rtb_Address.Text != "" && tb_Email.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Recipient_List Set Name = '" + tb_Name.Text + "', DOB = '" + dtp_Dob.Text + "', Mob_No = " + tb_Mob_No.Text + ", Gender = '" + Gender + "', Aadhar_Card = " + tb_Aadhar_Card.Text + ", Age = " + tb_Age.Text + ", Blood_Group = '" + cmb_Blood_Group.Text + "', Weight = " + tb_Weight.Text + ", City = '" + tb_City.Text + "', Address = '" + rtb_Address.Text + "', Email_ID = '" + tb_Email.Text + "' where Recipient_ID = " + tb_Recipient_ID.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                tb_Recipient_ID.Focus();
            }
            else
            {
                MessageBox.Show("Please Enter Recipient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            tbp_Update_Search_Recipient.SelectTab(tbp_Recipient_Details_II);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            tbp_Update_Search_Recipient.SelectTab(tbp_Recipient_Details_I);
        }       
    }
}
