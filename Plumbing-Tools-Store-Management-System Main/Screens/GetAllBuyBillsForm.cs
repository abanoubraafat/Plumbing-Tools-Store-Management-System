using Plumbing_Tools_Store_Management_System_Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    public partial class GetAllBuyBillsForm : Form
    {
        DataContext context = new DataContext();
        bool isFilteredBySupplier = false;
        bool isFilteredByDate = false;
        int BillId = 0;
        int selectedRow;
        public GetAllBuyBillsForm()
        {
            InitializeComponent();
            SupplierCombo.DisplayMember = "Name";
            SupplierCombo.ValueMember = "ID";
            SupplierCombo.DataSource = context.Suppliers.Select(s => s).ToList();
            //SupplierCombo.Items[0] = "كل الموردين";

            List<BuyBill> bills = new List<BuyBill>();
            bills = context.BuyBills.Include(b => b.BuyBillDetails.Select(dt => dt.Product)).Include(b => b.Supplier).ToList();
            foreach (BuyBill bill in bills)
            {
                
                int RowIdx = dataGridView1.Rows.Add(bill.ID, bill.Supplier.Name, bill.BuyDate, bill.Discount, bill.Total, "", bill.Notes);
                if (bill.BuyBillDetails != null)/////////////
                {
                    foreach (BuyBillDetails details in bill.BuyBillDetails)
                    {
                        //dataGridView1.Columns[6].DefaultCellStyle.NullValue = "";
                        dataGridView1.Rows[RowIdx].Cells[5].Value += details.Product.Name + " - ";
                    }
                }

            }
        }

        private void NewBillBtn_Click(object sender, EventArgs e)
        {
            BuyBillForm buyBill = new BuyBillForm();
            buyBill.ShowDialog();
            ReloadForm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterSupplierBtn_Click(object sender, EventArgs e)
        {
            if (SupplierCombo.SelectedValue != null)
            {
                int supplierId = int.Parse(SupplierCombo.SelectedValue.ToString());
                if (isFilteredByDate)
                {
                    DateTime start = FromDatePicker.Value;
                    DateTime end = ToDatePicker.Value;
                    Filter(b => b.BuyDate >= start && b.BuyDate <= end && b.Supplier.ID == supplierId);
                    FilterDateLbl.Visible = false;
                    BothFilterLbl.Visible = true;
                }
                else
                {
                    Filter(b => b.Supplier.ID == supplierId);
                    FilterSupplierLbl.Visible = true;
                }
                isFilteredBySupplier = true;
            }
            else
                MessageBox.Show(text: "لا يوجد مورد بهذا الإسم !", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Filter(Func<BuyBill, bool> condtition)
        {
            List<BuyBill> bills = new List<BuyBill>();
            bills = context.BuyBills.Include(b => b.BuyBillDetails.Select(dt => dt.Product)).Where(condtition).ToList();
            dataGridView1.Rows.Clear();
            foreach (BuyBill bill in bills)
            {
                int RowIdx = dataGridView1.Rows.Add(bill.ID, bill.Supplier.Name, bill.BuyDate, bill.Discount, bill.Total, "", bill.Notes);
                if (bill.BuyBillDetails != null)/////////////
                {
                    foreach (BuyBillDetails details in bill.BuyBillDetails)
                    {
                        //dataGridView1.Columns[6].DefaultCellStyle.NullValue = "";
                        dataGridView1.Rows[RowIdx].Cells[5].Value += details.Product.Name + " - ";
                    }
                }

            }
        }

        private void FilterDateBtn_Click(object sender, EventArgs e)
        {
            DateTime start = FromDatePicker.Value;
            DateTime end = ToDatePicker.Value;
            if (isFilteredBySupplier)
            {
                int supplierId = int.Parse(SupplierCombo.SelectedValue.ToString());
                Filter(b => b.BuyDate >= start && b.BuyDate <= end && b.Supplier.ID == supplierId);
                FilterSupplierLbl.Visible = false;
                BothFilterLbl.Visible = true;
            }
            else
            {
                Filter(b => b.BuyDate >= start && b.BuyDate <= end);
                FilterDateLbl.Visible = true;
            }
            isFilteredByDate = true;
        }

        private void CancelFilterSupplierBtn_Click(object sender, EventArgs e)
        {
            isFilteredBySupplier = false;
            if (isFilteredByDate)
            {
                FilterDateBtn_Click(sender, e);
                FilterDateLbl.Visible = true;
            }
            else
            {
                ReloadForm();
            }
            FilterSupplierLbl.Visible = false;
            BothFilterLbl.Visible = false;
        }

        private void CancelFilterDateBtn_Click(object sender, EventArgs e)
        {
            isFilteredByDate = false;
            if (isFilteredBySupplier)
            {
                FilterSupplierBtn_Click(sender, e);
                FilterSupplierLbl.Visible = true;
            }
            else
            {
                ReloadForm();
            }
            FilterDateLbl.Visible = false;
            BothFilterLbl.Visible = false;
        }

        private void DeleteBillBtn_Click(object sender, EventArgs e)
        {
            if (BillId != 0)
            {
                var res = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذه الفاتورة ؟ هذا الخيار لا رجعة فيه! !! حذف الفاتورة لن ينتج عنه استرجاع المنتجات اذا كنت تريد استرجاع المنتجات اضفط تعديل الفاتورة ثم استرجاع كل المنتجات.", "خطأ !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    dataGridView1.Rows.RemoveAt(selectedRow);
                    var deletedDetails = context.BuyBillDetails.Where(b => b.BuyBillID == BillId).ToList();
                    context.BuyBillDetails.RemoveRange(deletedDetails);
                    context.SaveChanges();
                    var bill = context.BuyBills.FirstOrDefault(b => b.ID == BillId);
                    context.BuyBills.Remove(bill);
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("برجاء تحديد فاتورة !!", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                EditBuyBillForm form = new EditBuyBillForm(BillId);
                var result = form.ShowDialog();
                ReloadForm();
            }
            else
            {
                MessageBox.Show("برجاء تحديد فاتورة !!", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void ReloadForm()
        {
            context = new DataContext();
            this.Controls.Clear();
            this.WindowState = FormWindowState.Maximized;
            this.InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            SupplierCombo.DisplayMember = "Name";
            SupplierCombo.ValueMember = "ID";
            SupplierCombo.DataSource = context.Suppliers.Select(s => s).ToList();
            //SupplierCombo.Items[0] = "كل الموردين";

            List<BuyBill> bills = new List<BuyBill>();
            bills = context.BuyBills.Include(b => b.BuyBillDetails.Select(dt => dt.Product)).ToList();
            dataGridView1.Rows.Clear();
            if(bills.Count == 0)
            {
                MessageBox.Show("لا توجد أي فواتير مشتريات بعد !", "معلومة !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (BuyBill bill in bills)
            {
                int RowIdx = dataGridView1.Rows.Add(bill.ID, bill.Supplier.Name, bill.BuyDate, bill.Discount, bill.Total, "", bill.Notes);
                if (bill.BuyBillDetails != null)/////////////
                {
                    foreach (BuyBillDetails details in bill.BuyBillDetails)
                    {
                        //dataGridView1.Columns[6].DefaultCellStyle.NullValue = "";
                        dataGridView1.Rows[RowIdx].Cells[5].Value += details.Product.Name + " - ";
                    }
                }

            }

        }
    }
}
