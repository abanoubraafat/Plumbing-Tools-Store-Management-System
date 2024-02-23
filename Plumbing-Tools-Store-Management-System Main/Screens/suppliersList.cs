using Plumbing_Tools_Store_Management_System_Main.Model;
using Plumbing_Tools_Store_Management_System_Main.Screens;
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

namespace project
{
    public partial class suppliersList : Form
    {
        DataContext dataContext = new DataContext();
        int idofsupplierselected = 0;
        int indexofsupplierselected;
        public suppliersList()
        {
            InitializeComponent();
            printdata();
        }
        public void printdata()
        {
            var query1 = dataContext.Suppliers.Select(e => new { e.ID, e.Name, e.Phone,e.CompanyName,e.Notes, e.Address });
            foreach (var item in query1)
            {
                suppliers_dataGridView.Rows.Add(item.ID, item.Name, item.Phone, item.CompanyName, item.Notes,item.Address);
            }
        }

        private void suppliers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            idofsupplierselected = int.Parse(suppliers_dataGridView.CurrentRow.Cells[0].Value.ToString());
            indexofsupplierselected = suppliers_dataGridView.CurrentRow.Index;
        }

        private void deletesupplier_Btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت واثق أنك تريد حذف هذا المورد ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Supplier supplierdeleted = dataContext.Suppliers.Where(ee => ee.ID == idofsupplierselected).FirstOrDefault();
                dataContext.Suppliers.Remove(supplierdeleted);
                dataContext.SaveChanges();
                suppliers_dataGridView.Rows.Remove(suppliers_dataGridView.Rows[indexofsupplierselected]);
                MessageBox.Show("تم حذف المورد بنجاح !", "إنتبه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Refresh();
            }
        }

        private void updatesupplier_Btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت واثق أنك تريد تعديل هذا المورد ؟", "تحذير !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                EditSupplier editSupplier = new EditSupplier(idofsupplierselected);
                editSupplier.ShowDialog();
            }
        }

        private void addsupplier_Btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت واثق أنك تريد اضافة مورد جديد؟", "حقا !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Supplier_Recording supplier_Recording = new Supplier_Recording();
                supplier_Recording.ShowDialog();
            }
        }

        private void reloadsupplier_btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            printdata();
        }
    }
}
