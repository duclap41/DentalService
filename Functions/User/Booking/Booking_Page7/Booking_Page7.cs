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
using System.Net.Mime;
using DentalService.DataAccess;

namespace DentalService.Booking.Booking_Page7
{
    public partial class Booking_Page7 : UserControl
    {
        // Get instance
        private static Booking_Page7 instance;
        public static Booking_Page7 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Booking_Page7();
                }
                instance.Visible = true;
                return instance;
            }
        }

        public Booking_Page7()
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
            mail.Subject = "NHA KHOA LẬP ĐỨC: Đặt lịch thành công!";
            mail.Body = "<p>Chúc mừng bạn đã lên lịch hẹn thành công.<br>" +
                " Chúng tôi rất vinh dự đón tiếp bạn.<br>" +
                "Thông tin đặt lịch mới:<br>" +
                $"Dịch vụ: {Booking_Page6.finalChoose["ServiceName"]}<br>" +
                $"Ngày hẹn: {Booking_Page6.finalChoose["BookingDate"]}<br>" +
                $"Giờ hẹn: {Booking_Page6.finalChoose["BookingTime"]}<br>" +
                $"Bác sĩ: {Booking_Page6.finalChoose["DoctorName"]}<br>" +
                "</p>";
            mail.IsBodyHtml = true;

            // attach qrcode image
            string imagePath = Path.Combine(LoadTable.imagePath, "qrcode", $"{Booking_Page6.finalChoose["QRCode"]}.jpg");
            //string imagePath = $"SaveData/qrcode/{Booking_Page6.finalChoose["QRCode"]}.jpg";

            if (File.Exists(imagePath))
            {
                // Đọc tấm ảnh vào một đối tượng Attachment
                Attachment attachment = new Attachment(imagePath, MediaTypeNames.Image.Jpeg);

                // Đặt tên tệp tin đính kèm (tùy chọn)
                attachment.Name = "QRCode.jpg";

                // Thêm đính kèm vào email
                mail.Attachments.Add(attachment);
            }
            else
            {
                Console.WriteLine("Không tìm thấy tấm ảnh đính kèm.");
            }

            await smtp.SendMailAsync(mail);

            // update on database
            DataAccess.LoadTable.InsertBookingHistory(Booking_Page6.finalChoose);
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
            await Task.WhenAll(SendMail(Booking_Page4.choosedMail));
            
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
