using Project_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager
{
    public partial class forgotpass : Form
    {
        ProjectPrnContext context = new ProjectPrnContext();
        public forgotpass()
        {
            InitializeComponent();
        }

        public static string RandomChar(int numberRD)
        {
            string randomStr = "";
            try
            {
                string[] myIntArray = new string[numberRD];
                int x;
                //that is to create the random # and add it to uour string
                Random autoRand = new Random();
                for (x = 0; x < numberRD; x++)
                {
                    myIntArray[x] = Convert.ToChar(Convert.ToInt32(autoRand.Next(65, 87))).ToString();
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch (Exception ex)
            {
                randomStr = "error";
            }
            return randomStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = tbEmail.Text;
            var rs = context.Users.SingleOrDefault(x => x.Email == tbEmail.Text);
            if (rs == null)
            {
                MessageBox.Show("Email chưa được đăng ký!");
            }
            else if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng ký!"); }
            else
            {
                try
                {
                    SmtpClient clientDetails = new SmtpClient();
                    clientDetails.Port = 587;
                    clientDetails.Host = "smtp.gmail.com";
                    clientDetails.EnableSsl = true;
                    clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                    clientDetails.UseDefaultCredentials = false;
                    clientDetails.Credentials = new NetworkCredential("baodz686868@gmail.com", "Bao12345678");

                    MailMessage mailDetails = new MailMessage();
                    mailDetails.From = new MailAddress("baodz686868@gmail.com");
                    mailDetails.To.Add(tbEmail.Text.Trim());

                    mailDetails.Subject = "Mật khẩu mới của bạn";
                    mailDetails.Body = RandomChar(6);
                    clientDetails.Send(mailDetails);
                    tbCode.Text = mailDetails.Body;

                    var tom = context.Users.Single(w => w.Email == tbEmail.Text);
                    tom.Password = tbCode.Text;
                    context.Users.Update(tom);
                    context.SaveChanges();
                    if (MessageBox.Show("Lấy lại mật khẩu thành công! Vui lòng đăng nhập lại", "xác nhận", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        login lo = new login();
                        lo.Show();
                        this.Hide();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void forgotpass_Load(object sender, EventArgs e)
        {
            tbCode.Enabled = false;
        }
    }
}
