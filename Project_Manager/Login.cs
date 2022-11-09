using Project_Manager.Models;
using System.DirectoryServices.ActiveDirectory;

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

            if (username.Trim() == "") { MessageBox.Show("Vui lòng nh?p tên tài kho?n"); }
            else if (password.Trim() == "") { MessageBox.Show("Vui lòng nh?p m?t kh?u"); }

            else
            {
                User u = context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);

                if (u != null)
                {
                    MessageBox.Show("??ng nh?p thành công");
                    frmain f = new frmain();
                    f.Show();
                    SetValueForText8 = Convert.ToString(u.RoleId);
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Tên ??ng nh?p ho?c m?t kh?u sai");
                }
            }
        }
    }
}