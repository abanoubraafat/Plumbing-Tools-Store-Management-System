using Plumbing_Tools_Store_Management_System_Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    public partial class EditSellBillForm : Form
    {
        DataContext context = new DataContext();
        int BillId;
        SellBill bill;
        int ProductId = 0;
        int selectedRow;
        List<SellBillDetails> details;
        Dictionary<int, int> ProductQtyBeforeEdit = new Dictionary<int, int>();
        public EditSellBillForm(int _BillId)
        {
            InitializeComponent();
            this.BillId = _BillId;
            bill = context.SellBills.First(b => b.ID == _BillId);
            //Intializeing bill with saved values
            BillNoTxt.Text = bill.ID.ToString();
            BillDate.Value = bill.SellDate;
            BillNotesTxt.Text = bill.Notes;
            TotalDiscountTxt.Text = bill.Discount.ToString();
            TotalTxt.Text = bill.Total.ToString();
            details = context.SellBillDetails.Where(b => b.SellBillID == _BillId).Include(b => b.Product).ToList();
            foreach (SellBillDetails item in details)
            {
                //may chane if u used price, total fields in BuyBillDetails
                dataGridView1.Rows.Add(item.Product.BarCode, item.Product.Name, item.Product.SellPrice, item.Qty, item.Qty * item.Product.SellPrice, item.ProductID);
                ProductQtyBeforeEdit[item.ProductID] = item.Qty;
            }


            SearchProductCombo.DisplayMember = "Name";
            SearchProductCombo.ValueMember = "ID";
            SearchProductCombo.DataSource = context.Products.Select(p => p).ToList();
        }

        private void DeleteBillBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت واثق أنك تريد حذف الفاتورة ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

            }
            else
            {

            }
        }

        private void SaveBillBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {

            }
            else
            {
                MessageBox.Show("الفاتورة لا تحتوى على أي منتجات", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBillBtn_Click_1(object sender, EventArgs e)
        {
            context.SaveChanges();
            if (dataGridView1.RowCount != 0)
            {
                bill.SellDate = BillDate.Value.Date;
                bill.Notes = BillNotesTxt.Text;
                if (double.TryParse(TotalDiscountTxt.Text, out double discount))
                    bill.Discount = discount;
                if (double.TryParse(TotalTxt.Text, out double total))
                    bill.Total = total;

                details = context.SellBillDetails.Where(b => b.SellBillID == BillId).Include(b => b.Product).ToList();
                context.SellBillDetails.RemoveRange(details);
                details.Clear();
                context.SaveChanges();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string code = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Product product = context.Products.First(p => p.BarCode == code);
                    if (ProductQtyBeforeEdit.ContainsKey(product.ID))
                        product.Quantity = product.Quantity + ProductQtyBeforeEdit[product.ID] - int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    else
                        product.Quantity -= int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    //ProductQtyBeforeEdit[product.ID] = product.Quantity;
                    SellBillDetails sellBillDetails = new SellBillDetails() { SellBill = bill, Product = product, Qty = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) };
                    var added = (context.SellBillDetails.Add(sellBillDetails));
                    details.Add(added);
                    ProductQtyBeforeEdit[added.ProductID] = added.Qty;
                }
                context.SaveChanges();
                MessageBox.Show($" تم تعديل الفاتورة بنجاح رقم الفاتورة : {bill.ID} !", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("الفاتورة لا تحتوى على أي منتجات", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void AddByNameBtn_Click(object sender, EventArgs e)
        {
            if (SearchProductCombo.SelectedValue != null)
            {
                int selectedProdID = int.Parse(SearchProductCombo.SelectedValue.ToString());
                Product product = context.Products.FirstOrDefault(p => p.ID == selectedProdID);
                if (!AddExistingProduct(product))
                    dataGridView1.Rows.Add(product.BarCode, product.Name, product.SellPrice, 1, product.SellPrice, product.ID);
            }
            else
            {
                MessageBox.Show(text: "لا يوجد منتج بهذا الإسم !", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool AddExistingProduct(Product product)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string CurrentRowProduct_Barcode = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (CurrentRowProduct_Barcode == product.BarCode.ToString())
                {
                    double qty = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + 1;
                    dataGridView1.Rows[i].Cells[3].Value = qty;
                    //
                    dataGridView1.Rows[i].Cells[4].Value = product.SellPrice * double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    //Total Edit
                    TotalChanged();
                    //
                    return true;
                }
            }
            return false;
        }

        private void TotalChanged()
        {
            if (double.TryParse(TotalTxt.Text, out double total))
            {
                total = 0;
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        total += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                    TotalTxt.Text = total.ToString();
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {

                int colIdx = e.ColumnIndex;
                int rowIdx = e.RowIndex;
                string ProductCode = dataGridView1.Rows[rowIdx].Cells[0].Value.ToString();
                var currentQty = dataGridView1.Rows[rowIdx].Cells[3].Value?.ToString();
                Product product = context.Products.FirstOrDefault(p => p.BarCode == ProductCode);
                if (dataGridView1.Columns[colIdx].Name == "Qty")
                {
                    bool IsNum = double.TryParse(currentQty, out double QtyVal);
                    if (IsNum && QtyVal > 0)
                    {
                        if(QtyVal > product.Quantity)
                        {
                            MessageBox.Show(text: "الكمية التي ادخلتها أكبر من المخزون", "تحذير !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridView1.Rows[rowIdx].Cells[colIdx].Value = 1;
                            TotalChanged();
                        }
                        else
                        {
                            dataGridView1.Rows[rowIdx].Cells[colIdx + 1].Value = product.SellPrice * QtyVal;
                            //Total Edit
                            TotalChanged();
                        }
                        TotalDiscountTxt.Text = "0";
                    }
                    else
                    {
                        dataGridView1.Rows[rowIdx].Cells[colIdx].Value = 1;
                        MessageBox.Show(text: "قيمة غير صحيحة", "تحذير !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
            }
        }

        private void DeleteProductFromBillBtn_Click(object sender, EventArgs e)
        {
            if (ProductId != 0)
            {
                Product product = context.Products.FirstOrDefault(p => p.ID == ProductId);
                product.Quantity += ProductQtyBeforeEdit[product.ID];
                dataGridView1.Rows.RemoveAt(selectedRow);
                TotalDiscountTxt.Text = "0";
                TotalChanged();
            }
            else
            {
                MessageBox.Show("برجاء تحديد منتج !!", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ProductId = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                selectedRow = dataGridView1.CurrentRow.Index;
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double total = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    total += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    TotalTxt.Text = total.ToString();
                }
                if (TotalDiscountTxt.Text.Length > 0)
                {
                    double totalDiscount = double.Parse(TotalDiscountTxt.Text.ToString());
                    total -= totalDiscount;
                    TotalTxt.Text = total.ToString();
                }
            }
        }

        private void DeleteBillBtn_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت واثق أنك تريد حذف الفاتورة ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (bill != null)
                {

                    context.SellBills.Remove(bill);
                    context.SaveChanges();
                }
                ReloadForm();
                MessageBox.Show("تم حذف الفاتورة بنجاح !", "إنتبه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ReloadForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            
            SearchProductCombo.DisplayMember = "Name";
            SearchProductCombo.ValueMember = "ID";
            SearchProductCombo.DataSource = context.Products.Select(p => p).ToList();

        }

        private void TotalDiscountTxt_Leave(object sender, EventArgs e)
        {
            bool isNum = double.TryParse(TotalDiscountTxt.Text, out double totalDiscount);
            if (TotalDiscountTxt.Text.Length > 0)
            {
                if (isNum)
                {
                    if (double.TryParse(TotalTxt.Text, out double total))
                    {
                        total = 0;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            total += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        }
                        if (totalDiscount > total || totalDiscount < 0)
                        {
                            MessageBox.Show("قيمة الخصم التي أدخلتها غير صحيحة", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TotalDiscountTxt.Text = "";
                            return;
                        }
                        total -= totalDiscount;
                        TotalTxt.Text = total.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("قيمة الخصم التي أدخلتها غير صحيحة", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TotalDiscountTxt.Text = "";
                }

            }
        }

        private void AddByCodeBtn_Click(object sender, EventArgs e)
        {
            Product product = context.Products.FirstOrDefault(p => p.BarCode == ProductCodeTxt.Text);
            if (product != null)
            {
                if (!AddExistingProduct(product))
                    dataGridView1.Rows.Add(product.BarCode, product.Name, product.SellPrice, 1, product.SellPrice, product.ID);
            }
            else
            {
                MessageBox.Show(text: "لا يوجد منتج له هذا الباركود !", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RestoreAllBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("الفاتورة لا تحتوى على أي منتجات", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var result = MessageBox.Show("هل أنت واثق أنك تريد استرجاع كل المنتجات ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (bill != null)
                {
                    foreach (var item in details)
                    {
                        if (ProductQtyBeforeEdit.ContainsKey(item.ProductID))
                        {
                            item.Product.Quantity += ProductQtyBeforeEdit[item.ProductID];
                        }
                    }
                    context.SaveChanges();
                    context.SellBills.Remove(bill);
                    context.SaveChanges();
                }
                MessageBox.Show("تم استرجاع المنتجات بنجاح !", "إنتبه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void TotalDiscountTxt_TextChanged(object sender, EventArgs e)
        {
            bool isNum = double.TryParse(TotalDiscountTxt.Text, out double totalDiscount);
            if (TotalDiscountTxt.Text.Length >= 0)
            {
                if (isNum)
                {
                    if (double.TryParse(TotalTxt.Text, out double total))
                    {
                        total = 0;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            total += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        }
                        if (totalDiscount > total || totalDiscount < 0)
                        {
                            MessageBox.Show("قيمة الخصم التي أدخلتها غير صحيحة", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TotalDiscountTxt.Text = "0";
                            return;
                        }
                        total -= totalDiscount;
                        TotalTxt.Text = total.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("قيمة الخصم التي أدخلتها غير صحيحة", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TotalDiscountTxt.Text = "0";
                }

            }
        }
    }
}
