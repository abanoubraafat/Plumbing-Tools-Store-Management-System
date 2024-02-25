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
    public partial class Register : Form
    {
        private DataContext DB = new DataContext();
        public Register()
        {
            //DB = new AppDBContext();
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTxt.Text != "" && PasswordTxt.Text != "" && RePasswordTxt.Text != "")
            {
                if (DB.Users.FirstOrDefault(pc => pc.Name == UserNameTxt.Text) != null)
                {
                    MessageBox.Show("مستخدم موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (PasswordTxt.Text != RePasswordTxt.Text)
                    {
                        MessageBox.Show("كلمة السر يجب ان تكون متشابهة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        User user = new User()
                        {
                            Name = UserNameTxt.Text,
                            Password = PasswordTxt.Text
                        };
                        DB.Users.Add(user);
                        DB.SaveChanges();
                        MessageBox.Show("تم تسجيل مستخدم جديد بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("يجب ملئ جميع الخانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
