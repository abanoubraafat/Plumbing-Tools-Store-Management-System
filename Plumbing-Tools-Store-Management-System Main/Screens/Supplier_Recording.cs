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
    public partial class Supplier_Recording : Form
    {
        public Supplier_Recording()
        {
            InitializeComponent();
        }


        // Check if all fields are filled
        private bool AllFieldsAreFilled()
        {
            if (string.IsNullOrWhiteSpace(SupName_txt.Text) ||
                string.IsNullOrWhiteSpace(SupPhone_txt.Text) ||
                string.IsNullOrWhiteSpace(SupAddress_txt.Text)||
                string.IsNullOrWhiteSpace(Company_txt.Text))
            {
                return false;
            }

            return true;
        }



        // Check if a supplier with the given details exists in the database or not and if exist, show message it's already exist
        private bool SupplierExists(string supplierName, string supplierAddress, string supplierPhone , string Company )
        {
            using (var context = new DataContext())
            {
                return context.Suppliers.Any(s => s.Name == supplierName && 
                s.Address == supplierAddress && s.Phone == supplierPhone && 
                s.CompanyName==Company );
            }
        }


        //Clear fields after adding data in data base
        private void ClearFormFields()
        {
            SupName_txt.Text = ""; 
            SupPhone_txt.Text = ""; 
            SupID_txt.Text = ""; 
            SupAddress_txt.Text = ""; 
            Company_txt.Text = "";
           if (Notes_txt.Text != "")
            {
                Notes_txt.Text = "";
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {

            if (!AllFieldsAreFilled())
            {
                MessageBox.Show("Please fill in all fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            using (var context = new DataContext())
            {
                Supplier newSupplier = new Supplier
                {
                    Name = SupName_txt.Text,
                    Address = SupAddress_txt.Text,
                    Phone = SupPhone_txt.Text,
                    CompanyName = Company_txt.Text,
                    Notes = Notes_txt.Text,

                };

                // If the supplier already exists, show a message to the user
                if (SupplierExists(SupName_txt.Text, SupAddress_txt.Text, SupPhone_txt.Text, Company_txt.Text))
                {
                    MessageBox.Show("Supplier already exists.", "Duplicate Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method
                }

                // Adding data in data base
                context.Suppliers.Add(newSupplier);
                context.SaveChanges();

                // Show Message Confirm
                MessageBox.Show("Data saved successfully.", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFormFields();
            }


            

        }

        // Validate phone number length
        private void SupPhone_txt_Leave(object sender, EventArgs e)
        {
            if (SupPhone_txt.Text.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 characters long.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SupPhone_txt.Focus(); 
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
