using DentalService.Booking.Calender;
using DentalService.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Booking.Booking_Page3
{
    public partial class Booking_Page3 : UserControl
    {
        // Get instance
        private static Booking_Page3 instance;
        public static Booking_Page3 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Booking_Page3();
                }
                instance.Visible = true;
                return instance;
            }
        }

        public Booking_Page3()
        {
            InitializeComponent();
            instance = this; // pay attention
        }

        private void Booking_Page3_Load(object sender, EventArgs e)
        {
            DisplayDoctors();
        }

        private void DisplayDoctors()
        {
            var people = DataAccess.LoadTable.doctor_nurse;
            foreach (var person in people)
            {
                if (person.Position == "Bác sĩ")
                {
                    DoctorCell doctorCell = new DoctorCell();
                    fLPnContainer.Controls.Add(doctorCell);
                    doctorCell.LoadData(person.FullName, person.Gender);
                }
            }
        }

        // Get choosed Service
        public static string choosedDoctor;
        public void LbNotify_Update(string doctorName)
        {
            lbNotify.Visible = true;
            lbNotify.Text = "Bạn chọn Bác Sĩ: " + doctorName;
        }

        private void cBtnNext_Click(object sender, EventArgs e)
        {
            uctBooking.Container.Controls.Add(Booking_Page4.Instance);
            this.Visible = false;
        }

        private void cBtnBack_Click(object sender, EventArgs e)
        {
            Booking_Page2.Booking_Page2.Instance.Select();
            this.Visible = false;
        }
    }
}
