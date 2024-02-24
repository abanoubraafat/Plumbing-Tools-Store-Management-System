using AddProduct.Screens;
using Plumbing_Tools_Store_Management_System_Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    public partial class BuyBillForm : Form
    {
        DataContext context = new DataContext();
        int ProductId = 0;
        int selectedRow;
        public BuyBillForm()
        {
            InitializeComponent();
            SupplierCombo.DisplayMember = "Name";
            SupplierCombo.ValueMember = "ID";
            SupplierCombo.DataSource = context.Suppliers.Select(s => s).ToList();
            

            SearchProductCombo.DisplayMember = "Name";
            SearchProductCombo.ValueMember = "ID";
            SearchProductCombo.DataSource = context.Products.Select(p => p).ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BuyBill addedBill;
        private void SaveBillBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount != 0)
            { 
                

                //saving logic without valdiations
                BuyBill buyBill = new BuyBill();
                buyBill.BuyDate = BillDate.Value.Date;
                buyBill.Notes = BillNotesTxt.Text;
                if(double.TryParse(TotalDiscountTxt.Text, out double discount))
                    buyBill.Discount = discount;
                if (double.TryParse(TotalTxt.Text, out double total))
                    buyBill.Total = total;
                //BuyBillDetails billDetails = new BuyBillDetails() { BuyBill = buyBill};
                if (SupplierCombo.SelectedValue != null)
                {
                    int selectedSupplierID = int.Parse(SupplierCombo.SelectedValue.ToString());
                    Supplier supplier = context.Suppliers.FirstOrDefault(s => s.ID == selectedSupplierID);
                    if (supplier != null)
                        buyBill.Supplier = supplier;
                }

                else
                {
                    MessageBox.Show(text: "برجاء إضافة إسم مورد صالح !", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                addedBill = context.BuyBills.Add(buyBill);
                context.SaveChanges();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string code = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Product product = context.Products.First(p => p.BarCode == code);
                    product.Quantity += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    BuyBillDetails buyBillDetails = new BuyBillDetails() { BuyBill = buyBill, Product = product , Qty = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) };
                    //buyBill.BuyBillDetails.Add(buyBillDetails);
                    context.BuyBillDetails.Add(buyBillDetails);
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

        private void DeleteBillBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("الفاتورة لا تحتوى على أي منتجات", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var result = MessageBox.Show("هل أنت واثق أنك تريد حذف الفاتورة ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                if(addedBill != null)
                {
                    context.BuyBills.Remove(addedBill);
                    context.SaveChanges();
                }
                ReloadForm();
                MessageBox.Show("تم حذف الفاتورة بنجاح !", "إنتبه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        dataGridView1.Rows[rowIdx].Cells[colIdx + 1].Value = product.BuyPrice * QtyVal;
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

        private void AddNewProductBtn_Click(object sender, EventArgs e)
        {
            BuyBill buyBill = new BuyBill()
            {
                BuyDate = DateTime.Now,

            };
            context.BuyBills.Add(buyBill);
            context.SaveChanges();
            var p = context.Products.FirstOrDefault();
            BuyBillDetails det = new BuyBillDetails()
            {
                BuyBill = buyBill,
                Product = p,
                Qty = 10
            };
            context.BuyBillDetails.Add(det);
            context.SaveChanges();

        }

        private void AddByCodeBtn_Click(object sender, EventArgs e)
        {
            Product product = context.Products.FirstOrDefault(p => p.BarCode == ProductCodeTxt.Text);
            if (product != null)
            {
                if (!AddExistingProduct(product))
                    dataGridView1.Rows.Add(product.BarCode, product.Name, product.BuyPrice, 1, product.BuyPrice);
            }
            else
            {
                MessageBox.Show(text: "لا يوجد منتج له هذا الباركود !", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddByNameBtn_Click(object sender, EventArgs e)
        {
            if (SearchProductCombo.SelectedValue != null)
            {
                int selectedProdID = int.Parse(SearchProductCombo.SelectedValue.ToString());
                Product product = context.Products.FirstOrDefault(p => p.ID == selectedProdID);
                if(!AddExistingProduct(product))
                    dataGridView1.Rows.Add(product.BarCode, product.Name, product.BuyPrice, 1, product.BuyPrice);
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

        //private void EditBillBtn_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.RowCount != 0)
        //    {
        //        //dataGridView1.ReadOnly = false;
        //        dataGridView1.Columns[3].ReadOnly = false;
        //        MessageBox.Show("يمكنك الآن تعديل الفاتورة", "إنتبه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //        MessageBox.Show("الفاتورة لا تحتوى على أي منتجات", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //}
        
        private void NewBillBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                var result = MessageBox.Show("لم يتم حفظ الفاتورة هل أنت واثق أنك تريد إنشاء فاتورة جديدة ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result != DialogResult.OK)
                {
                    return;
                }
            }
            this.Controls.Clear();
            this.InitializeComponent();
            SupplierCombo.DisplayMember = "Name";
            SupplierCombo.ValueMember = "ID";
            SupplierCombo.DataSource = context.Suppliers.Select(s => s).ToList();

            SearchProductCombo.DisplayMember = "Name";
            SearchProductCombo.ValueMember = "ID";
            SearchProductCombo.DataSource = context.Products.Select(p => p).ToList();

        }
        //User-defined Functions
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
                    dataGridView1.Rows[i].Cells[4].Value = product.BuyPrice * double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    //Total Edit
                    TotalChanged();
                    //
                    return true;
                }
            }
            return false;
        }
        public void ReloadForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            SupplierCombo.DisplayMember = "Name";
            SupplierCombo.ValueMember = "ID";
            SupplierCombo.DataSource = context.Suppliers.Select(s => s).ToList();

            SearchProductCombo.DisplayMember = "Name";
            SearchProductCombo.ValueMember = "ID";
            SearchProductCombo.DataSource = context.Products.Select(p => p).ToList();

        }

        private void DeleteProductFromBillBtn_Click(object sender, EventArgs e)
        {
            if (ProductId != 0 )
            {
                dataGridView1.Rows.RemoveAt(selectedRow);
                TotalChanged();
            }
            else
            {
                MessageBox.Show("برجاء تحديد منتج !!", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                ProductId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                selectedRow = dataGridView1.CurrentRow.Index;
            }
            
        }

        private void EditBillBtn_Click(object sender, EventArgs e)
        {

        }

        private void TotalDiscountTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            (printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 40;
            Font f = new Font("Arial", 18, FontStyle.Bold);
            string strDate = "التاريخ: " + BillDate.Text;
            string strName = SupplierCombo.Text + " : اسم المورد";

            SizeF fontSizeNO = e.Graphics.MeasureString("#NO " + BillNoTxt.Text, f);
            SizeF fontSizeDate = e.Graphics.MeasureString(strDate, f);
            SizeF fontSizeName = e.Graphics.MeasureString(strName, f);

            e.Graphics.DrawString("#NO " + BillNoTxt.Text, f, Brushes.Red, (e.PageBounds.Width - fontSizeNO.Width) / 2, margin);
            e.Graphics.DrawString(strDate, f, Brushes.Black, e.PageBounds.Width - fontSizeDate.Width - margin, margin + fontSizeNO.Height);
            e.Graphics.DrawString(strName, f, Brushes.Black, e.PageBounds.Width - fontSizeName.Width - margin, margin + fontSizeNO.Height + fontSizeDate.Height);


            float preHeights = margin + fontSizeNO.Height + fontSizeDate.Height + 70;

            e.Graphics.DrawRectangle(Pens.Black, margin, preHeights, e.PageBounds.Width - margin * 2, e.PageBounds.Height - margin - preHeights);

            float height = 20;

            float colHeight = 60;

            float col1Width = 270;
            float col2Width = 110 + col1Width;
            float col3Width = 110 + col2Width;
            float col4Width = 125 + col3Width;
            float col5Width = 110 + col4Width;

            e.Graphics.DrawLine(Pens.Black, margin, preHeights + colHeight, e.PageBounds.Width - margin, preHeights + colHeight);

            e.Graphics.DrawString("اسم الصنف", f, Brushes.Black, e.PageBounds.Width - col1Width, preHeights + height);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1Width, preHeights, e.PageBounds.Width - margin * 2 - col1Width, e.PageBounds.Height - margin);

            e.Graphics.DrawString(" رقم الصنف", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2Width, preHeights + height);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2Width, preHeights, e.PageBounds.Width - margin * 2 - col2Width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الكمية", f, Brushes.Black, e.PageBounds.Width - margin - col3Width, preHeights + height);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3Width, preHeights, e.PageBounds.Width - margin * 2 - col3Width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("السعر", f, Brushes.Black, e.PageBounds.Width - margin - col4Width, preHeights + height);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col4Width, preHeights, e.PageBounds.Width - margin * 2 - col4Width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الاجمالي", f, Brushes.Black, e.PageBounds.Width - 55 - col5Width, preHeights + height);
            //e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col5Width, preHeights, e.PageBounds.Width - margin * 2 - col5Width, e.PageBounds.Height - margin);


            float rowsHeight = 60;

            for (int x = 0; x < dataGridView1.Rows.Count; x++)
            {

                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[0].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col1Width, preHeights + rowsHeight + height);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[1].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2Width, preHeights + rowsHeight + height);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[2].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3Width, preHeights + rowsHeight + height);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[3].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4Width, preHeights + rowsHeight + height);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[5].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col5Width, preHeights + rowsHeight + height);
                e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight + colHeight, e.PageBounds.Width - margin, preHeights + rowsHeight + colHeight);

                rowsHeight += 60;
            }

            e.Graphics.DrawString("الخصم", f, Brushes.Red, e.PageBounds.Width - margin - col4Width, preHeights + rowsHeight + height);
            e.Graphics.DrawString(TotalTxt.Text, f, Brushes.Blue, e.PageBounds.Width - margin * 2 - col5Width, preHeights + rowsHeight + height);
            e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight + colHeight, e.PageBounds.Width - margin, preHeights + rowsHeight + colHeight);

            e.Graphics.DrawString("الاجمالي الكلي", f, Brushes.Red, e.PageBounds.Width - margin * 2 - col4Width, preHeights + rowsHeight * 2 + height);
            e.Graphics.DrawString(TotalTxt.Text, f, Brushes.Blue, e.PageBounds.Width - margin * 2 - col5Width, preHeights + rowsHeight + height);
            e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight + colHeight, e.PageBounds.Width - margin, preHeights + rowsHeight + colHeight);



        }
    }
}
