using Microsoft.Win32;
using Project_Manager.Models;
using System.DirectoryServices.ActiveDirectory;
using Project_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string SetValueForText3 = "";

        public static string SetValueForText8 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            ProjectPrnContext context = new ProjectPrnContext();
            string username = textBox1.Text;
            string password = textBox2.Text;
            SetValueForText3 = username;

            if (username.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản"); }
            else if (password.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); }

            else
            {
                User u = context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);

                if (u != null)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmain f = new frmain();
                    f.Show();
                    SetValueForText8 = Convert.ToString(u.RoleId);
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
                }
            }
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

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "xác nhận", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpass r = new forgotpass();
            r.Show();
            this.Hide();
        }
    }
}