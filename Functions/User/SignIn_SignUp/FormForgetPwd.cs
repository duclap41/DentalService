using DentalService.QrCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.SignIn_SignUp
{
    public partial class FormForgetPwd : Form
    {
        // Get instance
        private static FormForgetPwd instance;
        public static FormForgetPwd Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FormForgetPwd();
                }
                instance.ShowDialog();
                return instance;
            }
        }

        public FormForgetPwd()
        {
            InitializeComponent();
            instance = this;
        }

        public string GenerateRandomNumericPassword(int length)
        {
            char[] digits = "0123456789".ToCharArray();
            char[] password = new char[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                password[i] = digits[random.Next(digits.Length)];
            }

            return new string(password);
        }

        DataAccess.UserProfile currUser;
        private void GetCurrnetUser()
        {
            var profiles = DataAccess.LoadTable.userProfile;
            foreach (var user in profiles)
            {
                if (user.Email == txtEmail.Texts)
                {
                    currUser = user;
                    break;
                }
            }
        }

        private void SendMail(string destinationMail)
        {
            string newPass = GenerateRandomNumericPassword(8);

            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("minamasaki1996@gmail.com");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "mnsuueamnhruochs");
            smtp.Host = "smtp.gmail.com";

            //recipient
            mail.To.Add(new MailAddress(destinationMail));
            mail.IsBodyHtml = true;
            mail.Subject = "NHA KHOA LẬP ĐỨC: Đổi mật khẩu mới";
            mail.Body = "<p>Bạn đã yêu cầu lấy lại mật khẩu mới</p>" +
                    "<p>Đây là mật khẩu mới: <b>" + newPass + "</b></p>" +
                    "<p>Hãy đăng nhập lại và thay đổi mật khẩu để bảo mật tốt hơn.</p>" +
                    "<p>Nếu bạn không yêu cầu điều này, hãy liên hệ với chúng tôi ngay lập tức.</p>";
            mail.IsBodyHtml = true;

            smtp.Send(mail);

            //Reset pass in database
            DataAccess.LoadTable.UpdatePassword(currUser.UserID, newPass);

            //TODO: add constraint if account not exist
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            GetCurrnetUser();
            SendMail(txtEmail.Texts);
            lbNoti.Visible = true;
        }
    }
}
