using Plumbing_Tools_Store_Management_System_Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddProduct.Screens
{
    public partial class Login : Form
    {
        DataContext DB = new DataContext();
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            User user;
            if (txt_Uname.Text != "" || txt_pass.Text != "")
            {
                try
                {
                    user = DB.Users.FirstOrDefault(u => u.Name == txt_Uname.Text && u.Password == txt_pass.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("خطأ في اسم المستخدم او كلمة المرور", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                if (user != null)
                {
                    Close();
                    Thread thread = new Thread(()=>Application.Run(new Home()));
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();

                }
                else
                {
                    MessageBox.Show("خطأ في اسم المستخدم او كلمة المرور", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("يجب ملئ جميع الخانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
