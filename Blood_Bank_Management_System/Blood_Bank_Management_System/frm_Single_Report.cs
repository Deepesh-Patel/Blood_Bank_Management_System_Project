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
    public partial class frm_Single_Report : Form
    {
        public frm_Single_Report()
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

        private void frm_Single_Report_Load(object sender, EventArgs e)
        {
            if (Global_Vars.Ushow == 10)
            {
                btn_Show_Report.Visible = true;
                lbl_ID.Text = "Recipient ID";
            }
            else if (Global_Vars.Ushow == 11)
            {
                btn_Hospital_Report_Show.Visible = true;
                lbl_ID.Text = "Hospital ID";
            }
            else if (Global_Vars.Ushow == 12)
            {
                btn_Donor_Report_Show.Visible = true;
                lbl_ID.Text = "Donor ID";
            }
        }

        private void btn_Hospital_Report_Show_Click(object sender, EventArgs e)
        {
            Con_Open();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            if (tb_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select Hospital_ID, Hospital_Name, City, Date, Total_Bill from Hospital_Details where Hospital_ID = " + tb_ID.Text + " ", Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                SqlCommand cmd1 = new SqlCommand("Select * from Hospital_Bill_List where ID = " + tb_ID.Text + " ", Con);
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                sda1.Fill(dt1);

                CrystalReports.crpt_hospital_single_bill_report cph = new CrystalReports.crpt_hospital_single_bill_report();
                cph.Database.Tables["Hospital_Details"].SetDataSource(dt);
                cph.Database.Tables["Hospital_Bill_List"].SetDataSource(dt1);

                this.crv_single_view.ReportSource = cph;
            }
            else
            {
                MessageBox.Show("Please Type ID","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Con_Close();
        }

        private void btn_Show_Report_Click(object sender, EventArgs e)
        {
            Con_Open();

            DataTable dt = new DataTable();

            if (tb_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Recipient_List where Recipient_ID = " + tb_ID.Text + " ", Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                CrystalReports.crpt_Recipient_single_id_bill_report cpr = new CrystalReports.crpt_Recipient_single_id_bill_report();
                cpr.Database.Tables["Recipient_List"].SetDataSource(dt);

                this.crv_single_view.ReportSource = cpr;
            }
            else
            {
                MessageBox.Show("Please Type ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Con_Close();
        }

        private void btn_Donor_Report_Show_Click(object sender, EventArgs e)
        {
            Con_Open();

            DataTable dt = new DataTable();

            if (tb_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Donor_Details where Donor_ID = " + tb_ID.Text + " ", Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                CrystalReports.crpt_donor_certificate_report cpd = new CrystalReports.crpt_donor_certificate_report();
                cpd.Database.Tables["Donor_Details"].SetDataSource(dt);

                this.crv_single_view.ReportSource = cpd;
            }
            else
            {
                MessageBox.Show("Please Type ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Con_Close();
        }
    }
}
