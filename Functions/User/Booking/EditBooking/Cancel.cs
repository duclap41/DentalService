using DentalService.Booking.Calender;
using DentalService.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Booking.Cancel
{
    public partial class Cancel : UserControl
    {
        // Get instance
        private static Cancel instance;
        public static Cancel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Cancel();
                }
                instance.Visible = true;
                return instance;
            }
        }

        public Cancel()
        {
            InitializeComponent();
            InitializeLoading();
            instance = this; // pay attention

        }

        // Send mail to annouce successfull appoiment 
        private async Task SendMail(string email)
        {
            string mailAd = email;

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
            mail.To.Add(new MailAddress(mailAd));
            mail.IsBodyHtml = true;
            mail.Subject = "NHA KHOA LẬP ĐỨC: Hủy lịch hẹn thành công!";
            mail.Body = "Chúc mừng bạn đã lên lịch hẹn thành công.\n Chúng tôi rất vinh dự đón tiếp bạn.";

            //for (int i = 0; i < attachmentFilename.Length; i++)
            //    mail.Attachments.Add(new Attachment(attachmentFilename[i]));

            await smtp.SendMailAsync(mail);
            //MessageBox.Show("Email sent successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // loading animation
        private PictureBox picLoading;
        private void InitializeLoading()
        {
            picLoading = new PictureBox
            {
                Image = Properties.Resources.loading_animation,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Visible = false,
                Size = new System.Drawing.Size(200, 200)
            };
            this.Controls.Add(picLoading);
            picLoading.Location = new System.Drawing.Point((this.Width / 2) - picLoading.Width / 2,
                                                    (this.Height / 2) - picLoading.Height / 2); // Đặt ở giữa form
        }

        private async void Booking_Page7_Load(object sender, EventArgs e)
        {
            ShowLoading(true);

            // waiting send mail
            await Task.WhenAll(SendMail("lapkull@gmail.com"));
            
            ShowLoading(false);
        }

        private void ShowLoading(bool isLoading)
        {
            picLoading.Visible = isLoading;
            if (isLoading)
            {
                picLoading.BringToFront();
            }
            else if (!isLoading)
            {
                tbLPnContainer.Visible = true;
            }
        }
        
    }
}
