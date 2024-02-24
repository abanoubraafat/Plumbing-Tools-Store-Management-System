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

namespace project
{
    public partial class ProductList : Form
    {
        DataContext dataContext = new DataContext();
        int idofproductselected = 0;
        int indexofproductselected ;
        public ProductList()
        {
            InitializeComponent();
            printdata();
        }
        public void printdata()
        {
            var query1 = dataContext.Products.Select(e => new { e.ID, e.BarCode, e.Name, e.SellPrice, e.Quantity });
            foreach (var item in query1)
            {
                product_dataGridView.Rows.Add(item.ID, item.BarCode, item.Name, item.SellPrice, item.Quantity);
            }
        }

        private void product_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            idofproductselected = int.Parse(product_dataGridView.CurrentRow.Cells[0].Value.ToString());
            indexofproductselected = product_dataGridView.CurrentRow.Index;
        }

        private void deleteproduct_Btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت واثق أنك تريد حذف هذا المنتج ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Product productdeleted = dataContext.Products.Where(ee => ee.ID == idofproductselected).FirstOrDefault();
                dataContext.Products.Remove(productdeleted);
                dataContext.SaveChanges();
                product_dataGridView.Rows.Remove(product_dataGridView.Rows[indexofproductselected]);
                MessageBox.Show("تم حذف المنتج بنجاح !", "إنتبه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Refresh();
            }
        }

        private void updateproduct_Btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت واثق أنك تريد تعديل هذا المنتج ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                AddProduct.Screens.EditProduct formupdate = new AddProduct.Screens.EditProduct(idofproductselected);
                formupdate.ShowDialog();
            }

        }
        private void addproduct_Btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت واثق أنك تريد اضافة منتج جديد؟", "حقا !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                AddProduct.Form1 formadd = new AddProduct.Form1();
                formadd.ShowDialog();
            }
        }

        private void reloadproduct_btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            printdata();
        }
    }
}