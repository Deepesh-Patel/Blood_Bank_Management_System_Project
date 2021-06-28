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
    public partial class frm_splash_form : Form
    {
        public frm_splash_form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar_splash.PerformStep();

            if (pbar_splash.Value <= 10)
            {
                lbl_note.Text = "Loading Application Please Wait......";
                lbl_per.Text = "10 %";
            }
            if (pbar_splash.Value >= 10 && pbar_splash.Value <= 20)
            {
                lbl_note.Text = "Loading All Forms Please Wait......";
                lbl_per.Text = "20 %";
            }
            if (pbar_splash.Value >= 20 && pbar_splash.Value <= 50)
            {
                lbl_note.Text = "Loading Forms and Tables Please Wait......";
                lbl_per.Text = "50 %";
            }
            if (pbar_splash.Value >= 50 && pbar_splash.Value <= 75)
            {
                lbl_note.Text = "Connecting To Database Please Wait......";
                lbl_per.Text = "75 %";
            }
            if (pbar_splash.Value >= 75 && pbar_splash.Value <= 85)
            {
                lbl_note.Text = "Loading Login Page Please Wait......";
                lbl_per.Text = "85 %";
            }
            if (pbar_splash.Value >= 85 && pbar_splash.Value <= 100)
            {
                lbl_note.Text = "Starting Application Please Wait......";
                lbl_per.Text = "100 %";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            System.Threading.Thread.Sleep(200);
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;

            if (this.Opacity <= 0)
            {
                timer3.Enabled = false;

                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }
    }
}
