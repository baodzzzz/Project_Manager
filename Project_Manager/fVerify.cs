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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Manager
{
    public partial class fVerify : Form
    {
        ProjectPrnContext context = new ProjectPrnContext();

        public fVerify()
        {
            InitializeComponent();
        }

        private void fVerify_Load(object sender, EventArgs e)
        {
            label1.Text = register.SetValueForText1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (register.SetValueForText2 == textBox2.Text)
            {
                User u1 = context.Users.Single(u => u.Email == register.SetValueForText1);
                u1.Verify = 1;
                context.SaveChanges();

                if (MessageBox.Show("Tài khoản đã được xác minh! Bây giờ bạn có thể đăng nhập", "xác nhận", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    login flogin = new login();
                    flogin.Show();
                    this.Hide();
                }

            }
            else
            {
                if (MessageBox.Show("Mã xác nhận sai!!!! Vui lòng kiểm tra lại!!!", "xác nhận", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes) ;
            }
        }

    }
}
