﻿using Plumbing_Tools_Store_Management_System_Main.Model;
using project;
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

namespace Plumbing_Tools_Store_Management_System_Main.Screens
{
    public partial class EditSupplier : Form
    {
    
        DataContext context = new DataContext();
        public EditSupplier(int id)
        {
           
            InitializeComponent();

            // Show data from data grid view
            Supplier supplier = context.Suppliers.FirstOrDefault(S => S.ID == id);
            SupID_txt.Text = supplier.ID.ToString();
            SupName_txt.Text = supplier.Name;
            SupPhone_txt.Text = supplier.Phone;
            SupAddress_txt.Text = supplier.Address;
            Company_txt.Text = supplier.CompanyName;
            Notes_txt.Text = supplier.Notes;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SupName_txt.Text) || string.IsNullOrWhiteSpace(SupPhone_txt.Text) ||
            string.IsNullOrWhiteSpace(SupAddress_txt.Text) || string.IsNullOrWhiteSpace(Company_txt.Text))
            {
                MessageBox.Show("من فضلك يجب ملئ جميع الحقول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (SupPhone_txt.Text.Length != 11)
            {
                MessageBox.Show("يجب ادخال رقم تليفون 11 رقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                int id;
                if (!int.TryParse(SupID_txt.Text, out id))
                {
                    MessageBox.Show("ال ID الخاص بهذا المورد غير صالح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Supplier supplier = context.Suppliers.FirstOrDefault(s => s.ID == id);
                if (supplier == null)
                {
                    MessageBox.Show("المورد غير موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                supplier.Name = SupName_txt.Text;
                supplier.Phone = SupPhone_txt.Text;
                supplier.Address = SupAddress_txt.Text;
                supplier.CompanyName = Company_txt.Text;
                supplier.Notes = Notes_txt.Text;

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("تم تعديل البيانات بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("الرجاء إدخال حروف فقط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SupPhone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("الرجاء إدخال أرقام فقط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SupPhone_txt_Leave(object sender, EventArgs e)
        {

            //if (SupPhone_txt.Text.Length != 11)
            //{
            //    MessageBox.Show("يجب ادخال رقم تليفون 11 رقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    SupPhone_txt.Focus();
            //}
        }
    }
}
