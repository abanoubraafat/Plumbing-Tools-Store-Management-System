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

namespace WindowsFormsApp1
{
    public partial class HomeList : Form
    {
        DataContext context = new DataContext();
        bool Hidden;

        public HomeList()
        {
            InitializeComponent();
            Hidden = false;
            SearchProductCombo.DataSource = context.Products.Select(p => p).ToList();
            SearchProductCombo.ValueMember = "ID";
            SearchProductCombo.DisplayMember = "Name";

        }



        private void SaveProductBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddByCodeBtn_Click(object sender, EventArgs e)
        {
            Product product = context.Products.FirstOrDefault(p => p.BarCode == ProductCodeTxt.Text);
            if (product != null)
            {
                if (!AddExistingProduct(product))
                    dataGridView1.Rows.Add(product.ID, product.BarCode, product.Name, product.SellPrice, 1, product.SellPrice);
            }
            else
            {
                MessageBox.Show(text: "لا يوجد منتج له هذا الباركود !", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AddByNameBtn_Click(object sender, EventArgs e)
        {
            if (SearchProductCombo.SelectedValue != null)
            {
                int selectedProdID = int.Parse(SearchProductCombo.SelectedValue.ToString());
                Product product = context.Products.FirstOrDefault(p => p.ID == selectedProdID);
                if (!AddExistingProduct(product))
                    dataGridView1.Rows.Add(product.ID.ToString(), product.BarCode.ToString(), product.Name, product.SellPrice.ToString(), 1, product.SellPrice.ToString());
            }
            else
            {
                MessageBox.Show(text: "لا يوجد منتج بهذا الإسم !", "خطأ !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int p_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int New_Quantity = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            Product p = context.Products.First(x => x.ID == p_id);

            if (New_Quantity > p.Quantity)
            {
                MessageBox.Show("الكمية اكبر من المخزون");
                dataGridView1.CurrentRow.Cells[4].Value = "1";
            }
            else
            {
                //New_Total *= New_Quantity;
                dataGridView1.CurrentRow.Cells[5].Value = (New_Quantity * p.SellPrice).ToString();
            }
        }


        private void DiscountTxt_TextChanged(object sender, EventArgs e)
        {
            double Total = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Total += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            if (DiscountTxt.Text == "")
            {
                TotalTxt.Text = Total.ToString();
            }
            else
                TotalTxt.Text = (Total - double.Parse(DiscountTxt.Text)).ToString();

        }
    }
}
