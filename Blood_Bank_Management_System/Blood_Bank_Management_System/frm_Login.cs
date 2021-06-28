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
    public partial class frm_Login : Form
    {
        public frm_Login()
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            pnl_Login.Visible = true;                     
        }

        private void Close_Click(object sender, EventArgs e)
        {
            pnl_Login.Visible = false;
            tb_Username.Clear();
            tb_Password.Clear();
            cmb_User_Type1.SelectedIndex = -1;
            tb_Password.Enabled = false;
            btn_Login1.Enabled = false;
            tb_Username.Enabled = false;
            lnl_Forgot_Password.Visible = false;
        }         
        
        private void btn_Sign_up_Click(object sender, EventArgs e)
        {
            pnl_Sign_Up.Visible = true;           
        }
       
        private void frm_Login_Load(object sender, EventArgs e)
        {
            pnl_Login.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_Sign_Up.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_Forgot_Password.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_Login.Location = new Point(255, 81);
            pnl_Sign_Up.Location = new Point(255, 81);
            pnl_Forgot_Password.Location = new Point(255, 81);
            this.Size = new Size(890, 625);
            this.Location = new Point(310, 115);
            //1176, 770
        }
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            pnl_Sign_Up.Visible = false;
            tb_Username1.Clear();
            tb_Password1.Clear();
            cmb_User_Type2.SelectedIndex = -1;
            tb_Username1.Enabled = false;
            tb_Confirm_Password.Clear();
            tb_Password1.Enabled = false;
            tb_Confirm_Password.Enabled = false;
            btn_Save.Enabled = false;
        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            pnl_Forgot_Password.Visible = false;
            cmb_UserType2.SelectedIndex = -1;
            tb_Username2.Clear();
            tb_Password2.Clear();
            tb_Confirm_New_Password.Clear();
            tb_Admin_Key.Clear();
            tb_Username2.Enabled = false;
            tb_Password2.Enabled = false;
            tb_Confirm_New_Password.Enabled = false;
            tb_Admin_Key.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Password1.Text == tb_Confirm_Password.Text && tb_Username1.Text != "" && tb_Password1.Text != "" && cmb_User_Type2.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand("Insert into Login_List values ('" + tb_Username1.Text + "', '" + tb_Confirm_Password.Text + "', '" + cmb_User_Type2.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Username1.Clear();
                tb_Password1.Clear();
                cmb_User_Type2.SelectedIndex = -1;
                tb_Confirm_Password.Clear();
            }
            else
            {
                MessageBox.Show("Fill all the information Correctly !!!", "Incomplete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                tb_Password1.Enabled = false;
                tb_Confirm_Password.Enabled = false;
                btn_Save.Enabled = false;
                tb_Username1.Enabled = false;
                tb_Username1.Clear();
                tb_Password1.Clear();
                cmb_User_Type2.SelectedIndex = -1;
                tb_Confirm_Password.Clear();
                cmb_User_Type2.Focus();
            }
            Con_Close();
        }

        private void cmb_User_Type2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Username1.Enabled = true;
        }

        private void tb_Username1_TextChanged(object sender, EventArgs e)
        {
            tb_Password1.Enabled = true;
        }

        private void tb_Password1_TextChanged(object sender, EventArgs e)
        {
            tb_Confirm_Password.Enabled = true;
        }

        private void tb_Confirm_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
        }

         private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged_1(object sender, EventArgs e)
        {
            btn_Login1.Enabled = true;
        }

        private void cmb_UserType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Username2.Enabled = true;

            if (cmb_UserType2.SelectedIndex == 0)
            {
                tb_Admin_Key.Enabled = false;
            }
            else if (cmb_UserType2.SelectedIndex == 1)
            {
                tb_Admin_Key.Enabled = true;
            }
        }

        private void tb_Username2_TextChanged(object sender, EventArgs e)
        {
            tb_Password2.Enabled = true;
        }

        private void tb_Password2_TextChanged(object sender, EventArgs e)
        {
            tb_Confirm_New_Password.Enabled = true;
        }

        private void tb_Confirm_New_Password_TextChanged(object sender, EventArgs e)
        {
            tb_Admin_Key.Enabled = true;

            tb_Username2.Enabled = true;

            if (cmb_UserType2.SelectedIndex == 0)
            {
                tb_Admin_Key.Enabled = false;
                btn_Update.Enabled = true;
            }
            else if (cmb_UserType2.SelectedIndex == 1)
            {
                tb_Admin_Key.Enabled = true;
            }
        }

        private void tb_Admin_Key_TextChanged(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
        }

        private void btn_Login1_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Username.Text != "" && tb_Password.Text != "" && cmb_User_Type1.SelectedIndex != -1)
            {

                Con_Open();

                SqlCommand cmd = new SqlCommand("Select * From Login_List where Username = '" + tb_Username.Text + "' and Password = '" + tb_Password.Text + "' ", Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string cmbItemValue = cmb_User_Type1.SelectedItem.ToString();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["UserType"].ToString() == cmbItemValue)
                        {
                            MessageBox.Show("You are logged in as " + dt.Rows[i][2], "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Global_Vars.Username = "Welcome " + tb_Username.Text;
                            if (cmb_User_Type1.SelectedIndex == 0)
                            {
                                Global_Vars.URole = 1;
                            }
                            else if (cmb_User_Type1.SelectedIndex == 1)
                            {
                                Global_Vars.URole = 2;
                            }
                            Dashboard dd = new Dashboard();
                            dd.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please Change User Type", "UserType Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No data found for Admin", "Incorrect Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Username.Clear();
                    tb_Password.Clear();
                    cmb_User_Type1.SelectedIndex = -1;
                    tb_Username.Enabled = false;
                    tb_Password.Enabled = false;
                    btn_Login1.Enabled = false;
                    cmb_User_Type2.Focus();
                    lnl_Forgot_Password.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please fill login details");
            }

            Con_Close();
        }

        #region Show_Method
        private void lnl_Show_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnl_Show.Text == "Show")
            {
                lnl_Show.Text = "Hide";
                tb_Password.PasswordChar = '\0';
            }
            else
            {
                lnl_Show.Text = "Show";
                tb_Password.PasswordChar = '*';
            }
        }

        private void lnl_Show1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnl_Show1.Text == "Show")
            {
                lnl_Show1.Text = "Hide";
                tb_Password1.PasswordChar = '\0';
            }
            else
            {
                lnl_Show1.Text = "Show";
                tb_Password1.PasswordChar = '*';
            }
        }

        private void lnl_Show2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnl_Show2.Text == "Show")
            {
                lnl_Show2.Text = "Hide";
                tb_Confirm_Password.PasswordChar = '\0';
            }
            else
            {
                lnl_Show2.Text = "Show";
                tb_Confirm_Password.PasswordChar = '*';
            }
        }

        private void lnl_Show_New_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnl_Show_New_Password.Text == "Show")
            {
                lnl_Show_New_Password.Text = "Hide";
                tb_Password2.PasswordChar = '\0';
            }
            else
            {
                lnl_Show_New_Password.Text = "Show";
                tb_Password2.PasswordChar = '*';
            }
        }

        private void lnl_Show_Confirm_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnl_Show_Confirm_Password.Text == "Show")
            {
                lnl_Show_Confirm_Password.Text = "Hide";
                tb_Confirm_New_Password.PasswordChar = '\0';
            }
            else
            {
                lnl_Show_Confirm_Password.Text = "Show";
                tb_Confirm_New_Password.PasswordChar = '*';
            }
        }
        #endregion

        private void btn_Close_App_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            timer2.Start();
        }

        private void cmb_User_Type1_TextChanged(object sender, EventArgs e)
        {
            tb_Username.Enabled = true;
        }

        private void btn_Minimize_App_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_App_MouseHover(object sender, EventArgs e)
        {
            btn_Close_App.BackColor = Color.Red;
            btn_Close_App.ForeColor = Color.White;
        }

        private void btn_Close_App_MouseLeave(object sender, EventArgs e)
        {
            btn_Close_App.BackColor = Color.White;
            btn_Close_App.ForeColor = Color.Black;
        }

        private void btn_Minimize_App_MouseHover(object sender, EventArgs e)
        {
            btn_Minimize_App.BackColor = Color.LightGray;
        }
        
        private void btn_Minimize_App_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimize_App.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                Application.Exit();
            }
            Opacity -= .2;
        }

        private void lnl_Forgot_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_Login.Visible = false;
            lnl_Forgot_Password.Visible = false;
            pnl_Forgot_Password.Visible = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_UserType2.SelectedIndex != -1 && tb_Username2.Text != "" && tb_Password2.Text != "" && tb_Confirm_New_Password.Text != "" && tb_Password2.Text == tb_Confirm_New_Password.Text)
            {
                if (cmb_UserType2.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("Update Login_List set Password = '" + tb_Password2.Text + "' where Username = '" + tb_Username2.Text + "' ", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password updated successfully!..", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_UserType2.SelectedIndex = -1;
                    tb_Username2.Clear();
                    tb_Password2.Clear();
                    tb_Confirm_New_Password.Clear();
                }
                //else
                //{
                //    MessageBox.Show("Please Change UserType!..");
                //}
            }
            else
            {
                MessageBox.Show("No data found for Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();

            Con_Open();

            if (cmb_UserType2.SelectedIndex != -1 && tb_Username2.Text != "" && tb_Password2.Text != "" && tb_Confirm_New_Password.Text != "" && tb_Password2.Text == tb_Confirm_New_Password.Text && tb_Admin_Key.Text != "")
            {
                if (cmb_UserType2.SelectedIndex == 1)
                {
                    string key = "Select AdminKey from Admin_Key_Details";

                    SqlCommand CMD = new SqlCommand(key, Con);
                    //CMD.Parameters.Add("@UType", SqlDbType.VarChar).Value = "Admin";

                    string PassedAkey = Convert.ToString(CMD.ExecuteScalar());
                    CMD.Dispose();

                    if (PassedAkey == tb_Admin_Key.Text)
                    {
                        string str = "Update Login_List set Password = '" + tb_Password2.Text + "' where Username = '" + tb_Username2.Text + "' ";
                        SqlDataAdapter sda = new SqlDataAdapter(str, Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        MessageBox.Show("Password Updated Successfully!..", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_UserType2.SelectedIndex = -1;
                        tb_Username2.Clear();
                        tb_Password2.Clear();
                        tb_Confirm_New_Password.Clear();
                        tb_Admin_Key.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Admin Key not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            Con_Close();
        }
    }
}
