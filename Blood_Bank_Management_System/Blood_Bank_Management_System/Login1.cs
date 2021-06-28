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
    public partial class frm_Login_1 : Form
    {
        public frm_Login_1()
        {
            InitializeComponent();
        }
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Count(*) from Login_List where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "' ", Con);
            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successful !!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global_Vars.Username = "Welcome " + tb_Username.Text;
                Dashboard db = new Dashboard();
                db.Show();
                this.Close();
                frm_Login lg = new frm_Login();
                lg.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username & Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                tb_Username.Clear();
                tb_Password.Clear();
                tb_Username.Focus();
                tb_Password.Enabled = false;
                btn_Login.Enabled = false;
            }
            Con_Close();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Login.Enabled = true;
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
