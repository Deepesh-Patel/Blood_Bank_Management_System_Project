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
    public partial class frm_Add_New_Recipient : Form
    {
        public frm_Add_New_Recipient()
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
            SqlCommand Cmd = new SqlCommand("Select Count(Recipient_ID) from Recipient_List", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Recipient_ID) from Recipient_List";

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

        private void frm_Add_New_Recipient_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = Convert.ToString(Auto_Incr());
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
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
       
        #region Clear_Controls
        void ClearControls()
        {
            lbl_ID.Text = Convert.ToString(Auto_Incr());
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
            btn_Next.Enabled = false;
        }
        #endregion

        private void btn_Save_Click(object sender, EventArgs e)
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

            if(lbl_ID.Text != "" && tb_Name.Text != "" && dtp_Dob.Text != "" && tb_Mob_No.Text != "" && Gender != "" && tb_Aadhar_Card.Text != "" && tb_Age.Text != "" && cmb_Blood_Group.Text != "" && tb_Weight.Text != "" && tb_City.Text != "" && rtb_Address.Text != "" && tb_Email.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into Recipient_List values (" + lbl_ID.Text + " ,'" + tb_Name.Text + "' ,@stdDob ," + tb_Mob_No.Text + " ,'" + Gender + "' ," + tb_Aadhar_Card.Text + " ," + tb_Age.Text + " ,'" + cmb_Blood_Group.Text + "' ," + tb_Weight.Text + " ,'" + tb_City.Text + "' ,'" + rtb_Address.Text + "' ,'" + tb_Email.Text + "' ," + tb_Blood_Required.Text + " ,@stdDate ," + tb_Price.Text + " ," + tb_Total_Bill.Text + ")", Con);
                cmd.Parameters.Add("@stdDob", SqlDbType.Date).Value = dtp_Dob.Text;
                cmd.Parameters.Add("@stdDate", SqlDbType.Date).Value = dtp_Date.Text;
                cmd.ExecuteNonQuery();
                                              
                SqlCommand Cmd = new SqlCommand("Update Stock_Details Set Units =Units- " + tb_Blood_Required.Text + " where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                tbp_Add_Recipient.SelectTab(tbp_Recipient_Details);
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
            ClearControls();
        }
       
        private void btn_Next_Click(object sender, EventArgs e)
        {
            tbp_Add_Recipient.SelectTab(tbp_Blood_Details);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            tbp_Add_Recipient.SelectTab(tbp_Recipient_Details);
        }

        private void dtp_Dob_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dtp_Dob.Value;
            DateTime to = DateTime.Now;
            TimeSpan TSpan = to - from;
            double days = TSpan.TotalDays;
            tb_Age.Text = (days / 365).ToString("0");
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

            if (cmb_Blood_Group.Text != "")
            {
                tb_Blood_Required.Enabled = true;
            }
            else if (cmb_Blood_Group.Text == "")
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

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {
            if (tb_Email.Text != "")
            {
                btn_Next.Enabled = true;
            }
            else if (tb_Email.Text == "")
            {
                btn_Next.Enabled = false;
            }
        }       
    }
}
