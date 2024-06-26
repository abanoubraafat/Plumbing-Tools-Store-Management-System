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

namespace AddProduct
{
    public partial class Form1 : Form
    {
        DataContext DB = new DataContext();
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(Environment.CurrentDirectory);
        }

        //private static bool ContainsNumber(string input)
        //{
        //    return Regex.IsMatch(input, @"\d+");
        //}

        //string ValidPrice;
        //private void ProductPriceTxt_TextChanged(object sender, EventArgs e)
        //{
        //    if (!ContainsNumber(BuyingPriceTxt.Text))
        //    {
        //        MessageBox.Show("يجب ادخال السعر بالارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        BuyingPriceTxt.Text = ValidPrice;
        //    }
        //    else
        //    {
        //        ValidPrice = BuyingPriceTxt.Text;
        //    }
        //}
        string PImage;
        private void SaveProductBtn_Click(object sender, EventArgs e)
        {
            if (CodeTxt.Text == "" || ProductNameTxt.Text == "" || BuyingPriceNum.Value == 0 || SellingPriceNum.Value == 0 || QuantityTxt.Value == 0)
            {
                MessageBox.Show("يجب ملئ جميع الخانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BuyingPriceNum.Value > SellingPriceNum.Value)
            {
                MessageBox.Show("يجب ان يزيد سعر البيع عن سعر الشراء", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DB.Products.FirstOrDefault(pc => pc.BarCode == CodeTxt.Text) != null)
                {
                    MessageBox.Show("هذا الباركود موجود مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Product p = new Product()
                    {
                        BarCode = CodeTxt.Text,
                        Name = ProductNameTxt.Text,
                        BuyPrice = double.Parse(BuyingPriceNum.Value.ToString()),
                        SellPrice = double.Parse(SellingPriceNum.Value.ToString()),
                        Quantity = int.Parse(QuantityTxt.Value.ToString())
                    };

                    DB.Products.Add(p);
                    DB.SaveChanges();
                    if (pictureBox1.ImageLocation != null)
                    {
                        string newpath = $"{Environment.CurrentDirectory}\\Images\\Products\\{p.ID}.jpg";
                        File.Copy(PImage, newpath);

                        p.Image = PImage;
                        DB.SaveChanges();
                    }

                    MessageBox.Show("تم حفظ المنتج بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dialog.FileName;
                PImage = pictureBox1.ImageLocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dialog.FileName;
                PImage = pictureBox1.ImageLocation;
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
        private void BuyingPriceNum_Leave(object sender, EventArgs e)
        {
            if (BuyingPriceNum.Value != 0)
                BuyLabel.Visible = false;
        }

        private void SellingPriceNum_Leave(object sender, EventArgs e)
        {
            if (SellingPriceNum.Value != 0)
                SellLabel.Visible = false;
        }

    }
}
