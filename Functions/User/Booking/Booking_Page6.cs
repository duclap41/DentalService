using DentalService.Booking.Calender;
using DentalService.CustomControls;
using DentalService.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Booking
{
    public partial class Booking_Page6 : UserControl
    {
        // Get instance
        private static Booking_Page6 instance;
        public static Booking_Page6 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Booking_Page6();
                }
                instance.Visible = true;
                return instance;
            }
        }

        public Booking_Page6()
        {
            InitializeComponent();
            instance = this; // pay attention
        }

        private void cBtnAppoint_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                uctBooking.Container.Controls.Clear(); // free memmory
                uctBooking.Container.Controls.Add(Booking_Page7.Booking_Page7.Instance);
            }
        }

        Dictionary<string, string> dayOfWeekMapping = new Dictionary<string, string>
        {
            { "Monday", "Thứ Hai" },
            { "Tuesday", "Thứ Ba" },
            { "Wednesday", "Thứ Tư" },
            { "Thursday", "Thứ Năm" },
            { "Friday", "Thứ Sáu" },
            { "Saturday", "Thứ Bảy" },
            { "Sunday", "Chủ Nhật" }
        };

        public static Dictionary<string, object> finalChoose;
        public void LoadData(int userID, string serviceName, string userName, DateTime date, DateTime time, string doctorName, string gender, DateTime birthDate, string address)
        {
            lbServiceName.Text = serviceName;
            lbUserName.Text = userName;
            lbDate.Text = dayOfWeekMapping[date.ToString("dddd")] + date.ToString(", dd \\t\\h\\g MM, yyyy");
            lbTime.Text = time.ToString("HH:mm:ss");
            lbDoctorName.Text = doctorName;
            if (gender == "Male")
            {
                lbGender_Age.Text = $"Nam, {DateTime.Now.Year - birthDate.Year}";
            }
            else { lbGender_Age.Text = $"Nữ, {DateTime.Now.Year - birthDate.Year}"; }
            lbAddress.Text = address;

            // Save to up database

            QrCode.genQrCode genQrCode = new QrCode.genQrCode();
            string newQrCode = genQrCode.GenerateQRCodeImage(200, Path.Combine(LoadTable.imagePath, "qrcode"));
            // load final
            finalChoose = new Dictionary<string, object>()
            {
                { "UserID",  userID},
                { "BookingDate", date.ToString("yyyy-MM-dd")},
                { "BookingTime", time.ToString("HH:mm:ss")},
                { "ServiceName", serviceName},
                { "DoctorName", doctorName},
                { "QRCode", newQrCode },
                { "Status", "Booked" },
            };
        }
    }
}
