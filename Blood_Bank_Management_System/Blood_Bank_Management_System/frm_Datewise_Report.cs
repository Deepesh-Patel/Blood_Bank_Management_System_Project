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
    public partial class frm_Datewise_Report : Form
    {
        public frm_Datewise_Report()
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

        private void frm_Datewise_Report_Load(object sender, EventArgs e)
        {
            if (Global_Vars.Ushow == 7)
            {
                btn_Donor_Report_Show.Visible = true;
            }
            else if (Global_Vars.Ushow == 8)
            {
                btn_Show_Report.Visible = true;
            }
            else if (Global_Vars.Ushow == 9)
            {
                btn_Hospital_Report_Show.Visible = true;
            }
        }

        string date1;
        string date2;

        private void btn_Show_Report_Click(object sender, EventArgs e)
        {
            date1 = dtp_From.Value.Year + "-" + dtp_From.Value.Month + "-" + dtp_From.Value.Day;
            date2 = dtp_To.Value.Year + "-" + dtp_To.Value.Month + "-" + dtp_To.Value.Day;

            Con_Open();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from Recipient_List where Date between '" + date1 + "' and '" + date2 + "' ", Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            CrystalReports.crpt_Recipient_Datewise_Report cp = new CrystalReports.crpt_Recipient_Datewise_Report();
            cp.Database.Tables["Recipient_List"].SetDataSource(dt);
            this.crv_Recipient_List_Viewer.ReportSource = cp;

            Con_Close();
        }

        private void btn_Donor_Report_Show_Click(object sender, EventArgs e)
        {
            date1 = dtp_From.Value.Year + "-" + dtp_From.Value.Month + "-" + dtp_From.Value.Day;
            date2 = dtp_To.Value.Year + "-" + dtp_To.Value.Month + "-" + dtp_To.Value.Day;

            Con_Open();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from Donor_Details where Date between '" + date1 + "' and '" + date2 + "' ", Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            CrystalReports.crpt_Donor_Datewise_Report dcp = new CrystalReports.crpt_Donor_Datewise_Report();
            dcp.Database.Tables["Donor_Details"].SetDataSource(dt);
            this.crv_Recipient_List_Viewer.ReportSource = dcp;

            Con_Close();
        }

        private void btn_Hospital_Report_Show_Click(object sender, EventArgs e)
        {
            date1 = dtp_From.Value.Year + "-" + dtp_From.Value.Month + "-" + dtp_From.Value.Day;
            date2 = dtp_To.Value.Year + "-" + dtp_To.Value.Month + "-" + dtp_To.Value.Day;

            Con_Open();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from Hospital_Details where Date between '" + date1 + "' and '" + date2 + "' ", Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            CrystalReports.crpt_Hospital_Datewise_Report hcp = new CrystalReports.crpt_Hospital_Datewise_Report();
            hcp.Database.Tables["Hospital_Details"].SetDataSource(dt);
            this.crv_Recipient_List_Viewer.ReportSource = hcp;

            Con_Close();
        }
    }
}
