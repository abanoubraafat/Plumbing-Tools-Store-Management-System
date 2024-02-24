﻿using Plumbing_Tools_Store_Management_System_Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddProduct.Screens
{
    public partial class EditProduct : Form
    {
        DataContext DB = new DataContext();

        int getid;
        public EditProduct(int _id)
        {
            getid= _id;
            InitializeComponent();
            Product product = DB.Products.First(P => P.ID == _id);
            CodeTxt.Text = product.BarCode;
            ProductNameTxt.Text = product.Name;
            BuyingPriceTxt.Text = (product.BuyPrice).ToString();
            SellingPriceTxt.Text = (product.SellPrice).ToString();
            QuantityTxt.Value = product.Quantity;
            pictureBox1.ImageLocation = product.Image;
        }
        bool imgChange = false;
        string PImage;
        private void SaveProductBtn_Click(object sender, EventArgs e)
        {
            if ( CodeTxt.Text == "" || ProductNameTxt.Text == "" || BuyingPriceTxt.Text == "" || QuantityTxt.Value == 0)
            {
                MessageBox.Show("يجب ملئ جميع الخانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Product p = DB.Products.First(P => P.ID == getid);
                p.BarCode = CodeTxt.Text;
                p.Name = ProductNameTxt.Text;
                p.BuyPrice = double.Parse(BuyingPriceTxt.Text);
                p.SellPrice = double.Parse(SellingPriceTxt.Text);
                p.Quantity = int.Parse(QuantityTxt.Value.ToString());

                
                DB.SaveChanges();

                if (imgChange)
                {
                    string newpath = $"{Environment.CurrentDirectory}\\Images\\Products\\{p.ID}.jpg";
                    File.Delete(newpath);
                    File.Copy(PImage, newpath);
                    p.Image = PImage;
                    DB.SaveChanges();
                }

                MessageBox.Show("تم حفظ المنتج بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dialog.FileName;
                PImage = pictureBox1.ImageLocation;
                imgChange = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dialog.FileName;
                PImage = pictureBox1.ImageLocation;
                imgChange = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuantityTxt_Leave(object sender, EventArgs e)
        {
            if (QuantityTxt.Value != 0)
            {
                QtyErrLabel.Visible = false;
            }
        }

        private static bool ContainsNumber(string input)
        {
            return Regex.IsMatch(input, @"\d+");
        }
        private void BuyingPriceTxt_Leave(object sender, EventArgs e)
        {
            if (ContainsNumber(BuyingPriceTxt.Text))
            {
                
            }
        }
    }
}