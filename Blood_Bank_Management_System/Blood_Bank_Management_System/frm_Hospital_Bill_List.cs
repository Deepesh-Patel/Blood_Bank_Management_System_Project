using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class frm_Blood_Stock_Requirement : Form
    {
        public frm_Blood_Stock_Requirement()
        {
            InitializeComponent();
        }

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

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void frm_Blood_Stock_Requirement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet4.Hospital_Bill_List' table. You can move, or remove it, as needed.
            this.hospital_Bill_ListTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet4.Hospital_Bill_List);
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet4.Hospital_Bill_List' table. You can move, or remove it, as needed.
            this.hospital_Bill_ListTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet4.Hospital_Bill_List);

        }
    }
}
