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
    public partial class frm_Hospital_Bill : Form
    {
        DataTable dt = new DataTable();

        public frm_Hospital_Bill()
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

        #region ClearControls
        void ClearControls()
        {
            tb_Hospital_Name.Clear();
            tb_Hospital_ID.Clear();
            cmb_Blood_Group.SelectedIndex = -1;
            tb_Stock_Required.Clear();
            tb_Price.Clear();
            tb_Total_Price.Clear();
            dgv_Stock.DataSource = dt;
            dt.Clear();
            tb_Total_Bill.Clear();
            tb_Hospital_ID.Enabled = true;
            gb_Stock.Enabled = false;
            btn_Add_Bill.Enabled = false;
            btn_Delete_Stock.Enabled = false;
        }
        #endregion

        private void frm_Hospital_Bill_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Blood_Group", Type.GetType("System.String"));
            dt.Columns.Add("Stock", Type.GetType("System.Int32"));
            dt.Columns.Add("Price", Type.GetType("System.Decimal"));
            dt.Columns.Add("Total_Price", Type.GetType("System.Decimal"));
            dgv_Stock.DataSource = dt;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Hospital_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select Hospital_Name From Hospital_Details where Hospital_ID = " + tb_Hospital_ID.Text + " ", Con);
                var obj = cmd.ExecuteReader();
                if (obj.Read())
                {
                    tb_Hospital_Name.Text = obj.GetString(obj.GetOrdinal("Hospital_Name"));
                }
                else
                {
                    MessageBox.Show("Incorrect Hospital ID Entered !!!", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                    tb_Hospital_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Hospital ID", "ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();

            if (tb_Hospital_ID.Text != "")
            {
                tb_Hospital_ID.Enabled = false;
                gb_Stock.Enabled = true;
                btn_Add_Bill.Enabled = true;             
            }
            else
            {
                tb_Hospital_ID.Enabled = true;
                gb_Stock.Enabled = false;
                btn_Add_Bill.Enabled = false;              
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con_Open();

            decimal Stock;
            decimal Price;
            decimal Total_Price;

            if (cmb_Blood_Group.Text != "" && tb_Stock_Required.Text != "" && tb_Price.Text != "")
            {
                Stock = Convert.ToDecimal(tb_Stock_Required.Text);
                Price = Convert.ToDecimal(tb_Price.Text);

                Total_Price = Stock * Price;

                tb_Total_Price.Text = Convert.ToString(Total_Price);


                SqlCommand Cmd = new SqlCommand("Select Units From Stock_Details where Blood_Group = '" + cmb_Blood_Group.Text + "' ", Con);
                SqlDataAdapter sda = new SqlDataAdapter(Cmd);
                DataTable ds = new DataTable();
                sda.Fill(ds);

                if (ds.Rows.Count > 0)
                {
                    for (int j = 0; j < ds.Rows.Count; j++)
                    {
                        decimal Units = Convert.ToDecimal(ds.Rows[j]["Units"]);
                        decimal stock1 = Convert.ToDecimal(tb_Stock_Required.Text);

                        if (Units <= stock1)
                        {
                            MessageBox.Show("No Enough Stock Available. There is only " + Units + " Units available.", "Less Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmb_Blood_Group.SelectedIndex = -1;
                            tb_Stock_Required.Clear();
                            tb_Price.Clear();
                            tb_Total_Price.Clear();
                        }
                        else if (Units > stock1)
                        {
                            int flag = -1;

                            for (int i = 0; i <= dgv_Stock.Rows.Count - 1; i++)
                            {
                                if (Convert.ToString(dgv_Stock.Rows[i].Cells[0].Value) == cmb_Blood_Group.Text)
                                {
                                    flag = 0;
                                }
                            }

                            if (flag == 0)
                            {
                                for (int i = 0; i < dgv_Stock.Rows.Count; i++)
                                {
                                    if (Convert.ToString(dgv_Stock.Rows[i].Cells[0].Value) == cmb_Blood_Group.Text)
                                    {
                                        dgv_Stock.Rows[i].Cells[1].Value = Convert.ToString(double.Parse(tb_Stock_Required.Text) + double.Parse(dgv_Stock.Rows[i].Cells[1].Value.ToString()));

                                        foreach (DataGridViewRow row in dgv_Stock.Rows)
                                        {
                                            row.Cells[dgv_Stock.Columns["Total_Price"].Index].Value = (Convert.ToDecimal(row.Cells[dgv_Stock.Columns["Price"].Index].Value) * Convert.ToDecimal(row.Cells[dgv_Stock.Columns["Stock"].Index].Value));
                                        }
                                    }
                                }
                            }
                            else
                            {
                                dt.Rows.Add(cmb_Blood_Group.Text, tb_Stock_Required.Text, tb_Price.Text, tb_Total_Price.Text);
                                this.dgv_Stock.DataSource = dt;
                                btn_Delete_Stock.Enabled = true;
                            }
                        }
                    }                    
                }
            }
            else
            {
                MessageBox.Show("First Fill all the fields !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
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
        }

        private void btn_Add_Bill_Click(object sender, EventArgs e)
        {
            tb_Total_Bill.Text = "0";
            for (int i = 0; i < dgv_Stock.Rows.Count; i++)
            {
                tb_Total_Bill.Text = Convert.ToString(double.Parse(tb_Total_Bill.Text) + double.Parse(dgv_Stock.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
           
            if (tb_Hospital_ID.Text != "" && tb_Hospital_Name.Text != "" && dtp_Date.Text != ""  && tb_Total_Bill.Text != "" && tb_Stock_Required.Text != "")
            {
                foreach( DataGridViewRow Rw in dgv_Stock.Rows)
                {
                    SqlCommand cmd = new SqlCommand("Insert Into Hospital_Bill_List(ID, Hospital_Name, Date, Blood_Group, Stock, Price, Total_Price, Total_Bill) values (" + tb_Hospital_ID.Text + ", '" + tb_Hospital_Name.Text + "', '" + dtp_Date.Text + "', '" + Rw.Cells[0].Value + "', '" + Rw.Cells[1].Value + "', '" + Rw.Cells[2].Value + "', '" + Rw.Cells[3].Value + "', " + tb_Total_Bill.Text + ")", Con);                    
                    cmd.ExecuteNonQuery();
                }

                SqlCommand Cmd = new SqlCommand("Update Hospital_Details Set Total_Bill = " + tb_Total_Bill.Text + " where Hospital_ID = " + tb_Hospital_ID.Text + " ", Con);
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Bill Generated Successfully !!!", "Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("First Fill all the information !!!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            for (int i = 0; i < dgv_Stock.Rows.Count; i++)
            {               
                SqlCommand Cmd = new SqlCommand("Update Stock_Details Set Units = Units - " + dgv_Stock.Rows[i].Cells[1].Value + " where Blood_Group = '" + dgv_Stock.Rows[i].Cells[0].Value + "'", Con);               
                Cmd.ExecuteNonQuery();
            }

            ClearControls();
            tb_Hospital_ID.Focus();

            Con_Close();
        }     

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
            tb_Hospital_ID.Focus();
        }

        private void btn_Delete_Stock_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count != 0)
            {
                int rowIndex = dgv_Stock.CurrentCell.RowIndex;
                if (MessageBox.Show("Do you want to delete selected stock permanently ?", "Delete Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgv_Stock.Rows.RemoveAt(rowIndex);
                }
                cmb_Blood_Group.SelectedIndex = -1;
                tb_Stock_Required.Clear();
                tb_Price.Clear();
                tb_Total_Price.Clear();
            }
            else if (dt.Rows.Count == 0)
            {
                btn_Delete_Stock.Enabled = false;
            }
        }            
    }
}
