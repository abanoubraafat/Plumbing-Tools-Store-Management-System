using AddProduct.Screens;
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

namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    public partial class SellBillForm : Form
    {
        DataContext context = new DataContext();
        int ProductId = 0;
        int selectedRow;
        List<Product> productsList;
        public SellBillForm(List<Product> productsList)
        {
            InitializeComponent();
            SearchProductCombo.DisplayMember = "Name";
            SearchProductCombo.ValueMember = "ID";
            SearchProductCombo.DataSource = context.Products.Select(p => p).ToList();
            this.productsList = productsList;
            foreach(Product product in productsList)
            {
                dataGridView1.Rows.Add(product.BarCode, product.Name, product.SellPrice, product.Quantity, product.Quantity * product.SellPrice);
            }
        }

        private void DeleteBillBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("الفاتورة لا تحتوى على أي منتجات", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var result = MessageBox.Show("هل أنت واثق أنك تريد حذف الفاتورة ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (addedBill != null)
                {
                    context.SellBills.Remove(addedBill);
                    context.SaveChanges();
                }
                ReloadForm();
                MessageBox.Show("تم حذف الفاتورة بنجاح !", "إنتبه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        SellBill addedBill;
        private void SaveBillBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                //saving logic without valdiations
                SellBill sellBill = new SellBill();
                sellBill.SellDate = BillDate.Value.Date;
                sellBill.Notes = BillNotesTxt.Text;
                if (double.TryParse(TotalDiscountTxt.Text, out double discount))
                    sellBill.Discount = discount;
                if (double.TryParse(TotalTxt.Text, out double total))
                    sellBill.Total = total;
                addedBill = context.SellBills.Add(sellBill);
                context.SaveChanges();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string code = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Product product = context.Products.First(p => p.BarCode == code);
                    product.Quantity -= int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    SellBillDetails sellBillDetails = new SellBillDetails() { SellBill = sellBill, Product = product, Qty = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) };
                    context.SellBillDetails.Add(sellBillDetails);
                }
                context.SaveChanges();
                MessageBox.Show($" تم إضافة الفاتورة بنجاح رقم الفاتورة : {addedBill.ID} !", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("الفاتورة لا تحتوى على أي منتجات", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void NewBillBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var result = MessageBox.Show("لم يتم حفظ الفاتورة هل أنت واثق أنك تريد إنشاء فاتورة جديدة ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result != DialogResult.OK)
                {
                    return;
                }
            }
            this.Controls.Clear();
            this.InitializeComponent();

            SearchProductCombo.DisplayMember = "Name";
            SearchProductCombo.ValueMember = "ID";
            SearchProductCombo.DataSource = context.Products.Select(p => p).ToList();
        }
        private void TotalChanged()
        {
            if (double.TryParse(TotalTxt.Text, out double total))
            {
                total = 0;
                if (dataGridView1.Rows.Count >= 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        total += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                    TotalTxt.Text = total.ToString();
                }
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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ProductId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                selectedRow = dataGridView1.CurrentRow.Index;
            }
        }
        private void DeleteProductFromBillBtn_Click(object sender, EventArgs e)
        {
            if (ProductId != 0)
            {
                dataGridView1.Rows.RemoveAt(selectedRow);
                TotalChanged();
                ////db reflect
            }
            else
            {
                MessageBox.Show("برجاء تحديد منتج !!", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SearchProductCombo.SelectedValue != null)
            {
                int selectedProdID = int.Parse(SearchProductCombo.SelectedValue.ToString());
                Product product = context.Products.FirstOrDefault(p => p.ID == selectedProdID);
                if (!AddExistingProduct(product))
                    dataGridView1.Rows.Add(product.BarCode, product.Name, product.SellPrice, 1, product.SellPrice);
            }
            else
            {
                MessageBox.Show(text: "لا يوجد منتج بهذا الإسم !", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {

                int colIdx = e.ColumnIndex;
                int rowIdx = e.RowIndex;
                string ProductCode = dataGridView1.Rows[rowIdx].Cells[0].Value.ToString();
                var currentQty = dataGridView1.CurrentCell.Value?.ToString();
                Product product = context.Products.FirstOrDefault(p => p.BarCode == ProductCode);
                if (dataGridView1.Columns[colIdx].Name == "Qty")
                {
                    bool IsNum = double.TryParse(currentQty, out double QtyVal);
                    if (IsNum && QtyVal > 0)
                    {
                        dataGridView1.Rows[rowIdx].Cells[colIdx + 1].Value = product.SellPrice * QtyVal;
                        //Total Edit
                        TotalChanged();
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

    }
}
