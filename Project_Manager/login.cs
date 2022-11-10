using Project_Manager.Helper;
using Project_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager
{
    public partial class login : Form
    {
        ProjectPrnContext context = new ProjectPrnContext();
        public login()
        {
            InitializeComponent();
        }
        public static string SetValueForText3 = "";

        public static string SetValueForText8 = "";


        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text;
            string password = textBox2.Text;
            string checkpass = AccountHelper.HashPassWord(password);
            SetValueForText3 = username;

            if (username.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản"); }
            else if (password.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); }

            else
            {
                User u = context.Users.SingleOrDefault(x => x.Username == username && x.Password == checkpass);

                if (u != null)
                {
                    if (u.Verify != 0)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        frmain f = new frmain();
                        f.Show();
                        SetValueForText8 = Convert.ToString(u.RoleId);
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Tài khoản chưa được xác minh");
                        fVerify a = new fVerify();
                        a.Show();
                        this.Hide();
                    }
                    
                }

                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
                }
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpass r = new forgotpass();
            r.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register r = new register();
            r.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else textBox2.PasswordChar = '*';
        }
    }
}
