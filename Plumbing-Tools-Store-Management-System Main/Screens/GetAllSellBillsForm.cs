using Plumbing_Tools_Store_Management_System_Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    public partial class GetAllSellBillsForm : Form
    {
        DataContext context = new DataContext();
        bool IsFiltered = false;
        int BillId = 0;
        int selectedRow;
        public GetAllSellBillsForm()
        {
            //InitializeComponent();
            ReloadForm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterDateBtn_Click(object sender, EventArgs e)
        {
            IsFiltered = true;
            DateTime start = FromDatePicker.Value;
            DateTime end = ToDatePicker.Value;
            Filter(b => b.SellDate >= start && b.SellDate <= end);
            DateFilterLbl.Visible = true;
        }

        private void Filter(Func<SellBill, bool> condtition)
        {
            List<SellBill> bills = new List<SellBill>();
            bills = context.SellBills.Include(b => b.SellBillDetails.Select(dt => dt.Product)).Where(condtition).ToList();
            dataGridView1.Rows.Clear();
            foreach (SellBill bill in bills)
            {
                int RowIdx = dataGridView1.Rows.Add(bill.ID, "", bill.SellDate, bill.Discount, bill.Total, "", bill.Notes);
                if (bill.SellBillDetails != null)/////////////
                {
                    foreach (SellBillDetails details in bill.SellBillDetails)
                    {
                        //dataGridView1.Columns[6].DefaultCellStyle.NullValue = "";
                        dataGridView1.Rows[RowIdx].Cells[4].Value += details.Product.Name + " - ";
                    }
                }

            }
        }

        private void CancelFilterDateBtn_Click(object sender, EventArgs e)
        {
            if (IsFiltered)
            {
                IsFiltered = false;
                DateFilterLbl.Visible = false;
                ReloadForm();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                BillId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                selectedRow = dataGridView1.CurrentRow.Index;
            }
        }

        private void EditBillBtn_Click(object sender, EventArgs e)
        {
            if (BillId != 0)
            {
                EditSellBillForm form = new EditSellBillForm(BillId);
                var result = form.ShowDialog();
                ReloadForm();
            }
            else
            {
                MessageBox.Show("برجاء تحديد فاتورة !!", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteBillBtn_Click(object sender, EventArgs e)
        {
            if (BillId != 0)
            {
                var res = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذه الفاتورة ؟ هذا الخيار لا رجعة فيه! !! حذف الفاتورة لن ينتج عنه استرجاع المنتجات اذا كنت تريد استرجاع المنتجات اضفط تعديل الفاتورة ثم استرجاع كل المنتجات.", "خطأ !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    var deletedDetails = context.SellBillDetails.Where(b => b.SellBillID == BillId).ToList();
                    context.SellBillDetails.RemoveRange(deletedDetails);
                    context.SaveChanges();
                    var bill = context.SellBills.FirstOrDefault(b => b.ID == BillId);
                    context.SellBills.Remove(bill);
                    context.SaveChanges();
                    dataGridView1.Rows.RemoveAt(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("برجاء تحديد فاتورة !!", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //User defined funcs
        private void ReloadForm()
        {
            context = new DataContext();
            this.Controls.Clear();
            this.WindowState = FormWindowState.Maximized;
            this.InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            List<SellBill> bills = new List<SellBill>();
            bills = context.SellBills.Include(b => b.SellBillDetails.Select(dt => dt.Product)).ToList();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if(bills.Count == 0)
            {
                MessageBox.Show("لا توجد أي فواتير مبيعات بعد !", "معلومة !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (SellBill bill in bills)
            {
                int RowIdx = dataGridView1.Rows.Add(bill.ID, bill.SellDate, bill.Discount, bill.Total, "", bill.Notes);
                if (bill.SellBillDetails != null)/////////////
                {
                    foreach (SellBillDetails details in bill.SellBillDetails)
                    {
                        dataGridView1.Rows[RowIdx].Cells[4].Value += details.Product.Name + " - ";
                    }
                }

            }
        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

    }
}
