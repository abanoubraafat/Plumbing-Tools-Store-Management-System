using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    public partial class GetAllSellBillsForm : Form
    {
        public GetAllSellBillsForm()
        {
            InitializeComponent();
        }

        private void NewBillBtn_Click(object sender, EventArgs e)
        {
            SellBillForm sellBill = new SellBillForm();
            sellBill.ShowDialog();
        }
    }
}
