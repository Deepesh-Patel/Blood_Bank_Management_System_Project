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
    public partial class frm_Sign_Up : Form
    {
        public frm_Sign_Up()
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Username.Text != "" && tb_Password.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into Login_List values('" + tb_Username.Text + "' ,'" + tb_Password.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Username.Clear();
                tb_Password.Clear();
            }
            else
            {
                MessageBox.Show("Fill all the information Correctly !!!", "Incomplete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                tb_Password.Enabled = false;
                btn_Save.Enabled = false;
            }
            Con_Close();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
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
