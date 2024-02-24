using Plumbing_Tools_Store_Management_System_Main.Model;
using Plumbing_Tools_Store_Management_System_Main.Screens;
using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AddProduct.Screens
{
    public partial class Home : Form
    {
        bool Hidden;

        public Home()
        {
            InitializeComponent();
            Hidden = false;
            ShowForm(new HomeList());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerdashboard.Start();
        }
        private void timerdashboard_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                dashboard_panel.Width = dashboard_panel.Width + 15;
                if (dashboard_panel.Width >= 252)
                {
                    pictureBox1.Show();
                    home_Btn.ImageAlign = ContentAlignment.MiddleLeft;
                    products_Btn.ImageAlign = ContentAlignment.MiddleLeft;
                    suppliers_Btn.ImageAlign = ContentAlignment.MiddleLeft;
                    sellbills_Btn.ImageAlign = ContentAlignment.MiddleLeft;
                    buybills_Btn.ImageAlign = ContentAlignment.MiddleLeft;
                    timerdashboard.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                dashboard_panel.Width = dashboard_panel.Width - 15;
                if (dashboard_panel.Width <= 55)
                {
                    pictureBox1.Hide();
                    home_Btn.ImageAlign = ContentAlignment.MiddleRight;
                    products_Btn.ImageAlign = ContentAlignment.MiddleRight;
                    suppliers_Btn.ImageAlign = ContentAlignment.MiddleRight;
                    sellbills_Btn.ImageAlign = ContentAlignment.MiddleRight;
                    buybills_Btn.ImageAlign = ContentAlignment.MiddleRight;
                    timerdashboard.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void ShowForm(Form form)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Form existingForm)
                {
                    existingForm.Close();
                    break;
                }
            }

            panel1.Dock = DockStyle.Fill;
            
            Controls.Add(panel1);
            
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            
            panel1.Controls.Add(form);
            
            form.Show();
        }

        private void products_Btn_Click(object sender, EventArgs e)
        {
            ShowForm(new ProductList());
        }

        private void suppliers_Btn_Click(object sender, EventArgs e)
        {
            ShowForm(new suppliersList());
        }

        private void sellbills_Btn_Click(object sender, EventArgs e)
        {
            ShowForm(new GetAllSellBillsForm());
        }

        private void buybills_Btn_Click(object sender, EventArgs e)
        {
            ShowForm(new GetAllBuyBillsForm());
        }

        private void home_Btn_Click(object sender, EventArgs e)
        {
            ShowForm(new HomeList());
        }
    }
}
