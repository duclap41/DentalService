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

namespace DentalService.Booking.Booking_Page2
{
    public partial class Booking_Page2 : UserControl
    {
        // Get instance
        private static Booking_Page2 instance;
        public static Booking_Page2 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Booking_Page2();
                }
                instance.Visible = true;
                return instance;
            }
        }

        public Booking_Page2()
        {
            InitializeComponent();
            instance = this; // pay attention
        }

        private void Booking_Page2_Load(object sender, EventArgs e)
        {
            DisplayServices();
        }

        private void DisplayServices()
        {
            var service = DataAccess.LoadTable.services;
            foreach (var s in service)
            {
                ServiceCell cell = new ServiceCell();
                fLpnContainer.Controls.Add(cell);
                cell.LoadData(s.ServiceName);
            }
        }

        // Get choosed Service
        public static string choosedService;
        public void LbNotify_Update(string serviceName)
        {
            lbNotify.Visible = true;
            lbNotify.Text = "Bạn đã chọn dịch vụ: " + serviceName;
        }

        private void cBtnNext_Click(object sender, EventArgs e)
        {
            uctBooking.Container.Controls.Add(Booking_Page3.Booking_Page3.Instance);
            this.Visible = false;
        }

        private void cBtnBack_Click(object sender, EventArgs e)
        {
            Booking_Page1.Instance.Select();
            this.Visible = false;
        }
    }
}
