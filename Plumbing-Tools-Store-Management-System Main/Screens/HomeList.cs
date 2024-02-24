﻿using Plumbing_Tools_Store_Management_System_Main.Model;
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
        double Total = 0;
        public HomeList()
        {
            InitializeComponent();
            Hidden = false;
            SearchProductCombo.DataSource = context.Products.Select(p => p).ToList();
            SearchProductCombo.ValueMember = "ID";
            SearchProductCombo.DisplayMember = "Name";
            TotalChanged();

        }


        private void AddByCodeBtn_Click(object sender, EventArgs e)
        {
            TotalChanged();
            Product product = context.Products.FirstOrDefault(p => p.BarCode == ProductCodeTxt.Text);
            if (product != null)
            {
                //if (!AddExistingProduct(product))
                //    dataGridView1.Rows.Add(product.ID, product.BarCode, product.Name, product.SellPrice, 1, product.SellPrice);
                if (!AddExistingProduct(product))
                {
                    dataGridView1.Rows.Add(product.ID.ToString(), product.BarCode.ToString(), product.Name, product.SellPrice.ToString(), 1, product.SellPrice.ToString());
                    TotalChanged();
                }
                TotalChanged();
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
                string CurrentRowProduct_Barcode = dataGridView1.Rows[i].Cells[1].Value.ToString();
                if (CurrentRowProduct_Barcode == product.BarCode.ToString())
                {
                    double qty = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) + 1;
                    dataGridView1.Rows[i].Cells[4].Value = qty;
                    //
                    //dataGridView1.Rows[i].Cells[4].Value = product.SellPrice * double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
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
            TotalTxt.Text = "0";
            if (double.TryParse(TotalTxt.Text, out double total))
            {
                total = 0;
                //if (dataGridView1.Rows.Count > 0)
                //{
                //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //    {
                //        total += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                //    }
                //    TotalTxt.Text = (total - int.Parse(DiscountNumeric.Value.ToString())).ToString();

                //}

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total += double.Parse(row.Cells[5].Value.ToString());
                    TotalTxt.Text = (total - double.Parse(DiscountNumeric.Value.ToString())).ToString();
                }
            }
        }

        //private void HomeList_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the '_Plumbing_Tools_Store_DBDataSet2.Products' table. You can move, or remove it, as needed.
        //    this.productsTableAdapter2.Fill(this._Plumbing_Tools_Store_DBDataSet2.Products);
        //    // TODO: This line of code loads data into the '_Plumbing_Tools_Store_DBDataSet1.Products' table. You can move, or remove it, as needed.
        //    this.productsTableAdapter1.Fill(this._Plumbing_Tools_Store_DBDataSet1.Products);
        //    // TODO: This line of code loads data into the '_Plumbing_Tools_Store_DBDataSet.Products' table. You can move, or remove it, as needed.
        //    this.productsTableAdapter.Fill(this._Plumbing_Tools_Store_DBDataSet.Products);
        //}


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
            TotalChanged();
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                foreach (var item in dataGridView1.Rows)
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
                    //foreach (DataGridViewRow row in dataGridView1.Rows)
                    //{
                    //    Total += double.Parse(row.Cells[5].Value.ToString());
                    //    TotalTxt.Text = Total.ToString();
                    //}
                    TotalChanged();
                }
            }
            TotalChanged();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count >= 1)
            {
                if (dataGridView1.CurrentRow.Cells[6].Selected == true)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
            TotalChanged();
        }

        private void ShowBillBtn_Click(object sender, EventArgs e)
        {
            List<Product> AddedProducts = new List<Product>();
            if (dataGridView1.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Product p = new Product()
                    {
                        BarCode = row.Cells[1].Value.ToString(),
                        Name = row.Cells[2].Value.ToString(),
                        SellPrice = int.Parse(row.Cells[3].Value.ToString()),
                        Quantity = int.Parse(row.Cells[4].Value.ToString())
                    };
                    AddedProducts.Add(p);
                }
            }

        }

        private void DiscountNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                TotalChanged();
            else
                DiscountNumeric.Value = 0;
        }
    }
}
