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
    public partial class frm_Stock_Details : Form
    {
        public frm_Stock_Details()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Stock_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Bank_Management_System_DBDataSet5.Stock_Details' table. You can move, or remove it, as needed.
            this.stock_DetailsTableAdapter.Fill(this.blood_Bank_Management_System_DBDataSet5.Stock_Details);
        }
    }
}
