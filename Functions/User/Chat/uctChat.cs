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

namespace DentalService.Chat
{
    public partial class uctChat : UserControl
    {
        // get instance
        static uctChat instance;
        public static uctChat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new uctChat();
                }
                return instance;
            }
        }

        DataAccess.UserProfile currUser;
        public uctChat()
        {
            InitializeComponent();
            instance = this;
            this.Dock = DockStyle.Fill;
        }

        private void GetCurrentUser(int id)
        {
            if ( id != -1)
            {
                foreach (var user in DataAccess.LoadTable.userProfile)
                {
                    if (user.UserID == id)
                    {
                        currUser = user;
                    }
                }
            }
        }

        private void picSend_Click(object sender, EventArgs e)
        {
            GetCurrentUser(SignIn_SignUp.uctSignIn.userID);
            Message message = new Message();
            fLPContainer.Controls.Add(message);
            message.LoadData(txtChatBox.Texts);
            if (currUser != null)
            {
                SendMail(currUser.Email, currUser.FullName, txtChatBox.Texts);
            }
            else
            {
                SendMail("có trong tin nhắn", "Vô danh", txtChatBox.Texts);
            }
            txtChatBox.Texts = "";
        }

        private void SendMail(string fromMail, string name, string message)
        {
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
            mail.To.Add(new MailAddress("rumbonaruson@gmail.com"));
            mail.IsBodyHtml = true;
            mail.Subject = $"NHA KHOA LẬP ĐỨC: Tin nhắn tư vấn từ khách hàng {name}";
            mail.Body = $"<p>Email khách hàng {fromMail}<br>" +
                    "Nội dung tin nhắn: <b>" + message + "</b><br>" +
                    "Vui lòng phản hồi nhanh nhất có thể.</p>";

            smtp.SendMailAsync(mail);
          }

        // check sign in?
        public void ChangeMessage()
        {
            customPanel1.Visible = false;
        }
    }
}
