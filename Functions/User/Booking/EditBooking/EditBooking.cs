using DentalService.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Booking
{
    public partial class EditBooking : UserControl
    {
        // Get instance
        private static EditBooking instance;
        public static EditBooking Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EditBooking();
                }
                instance.Visible = true;
                return instance;
            }
        }

        public EditBooking()
        {
            InitializeComponent();
            instance = this;
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
        public void LoadData(string serviceName, string userName, DateTime date, TimeSpan time, string doctorName, string gender, DateTime birthDate, string address)
        {
            lbServiceName.Text = serviceName;
            lbUserName.Text = userName;
            datetime = date;
            lbDate.Text = dayOfWeekMapping[date.ToString("dddd")] + date.ToString(", dd \\t\\h\\g MM, yyyy");
            lbTime.Text = time.ToString(@"hh\:mm");
            lbDoctorName.Text = doctorName;
            if (gender == "Male")
            {
                lbGender_Age.Text = $"Nam, {DateTime.Now.Year - birthDate.Year}";
            }
            else { lbGender_Age.Text = $"Nữ, {DateTime.Now.Year - birthDate.Year}"; }
            lbAddress.Text = address;
        }

        DateTime datetime;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // check if date is valid
            TimeSpan difference = datetime - DateTime.Now;
            int daysDifference = Math.Abs(difference.Days);
            if (daysDifference < 2)
            {
                DialogResult cancel = MessageBox.Show("Bạn chắc chắn muốn hủy chứ?", "Hủy lịch đặt!", MessageBoxButtons.OKCancel);
                if (cancel == DialogResult.OK)
                {
                    MainForm.Container.Controls.Add(Homepage.uctHomepage.Instance);
                    //LoadData("cancel", idRow);
                    //LoadData("all"); // reload
                }
            }
            else
            {
                MessageBox.Show("Bạn không thể hủy lịch đặt này", "Cảnh báo", MessageBoxButtons.OK);
            }
        }
    }
}
