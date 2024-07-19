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

namespace DentalService.Booking
{
    public partial class Booking_Page1 : UserControl
    {
        // Get instance
        private static Booking_Page1 instance;
        public static Booking_Page1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Booking_Page1();
                }
                instance.Visible = true;
                return instance;
            }
        }

        public static string fullName;

        public Booking_Page1()
        {
            InitializeComponent();
            instance = this; // pay attention
        }

        private void cBtnNext_Click(object sender, EventArgs e)
        {
            fullName = cTxtLastName.Text + cTxtFirstName.Text;

            uctBooking.Container.Controls.Add(Booking_Page2.Booking_Page2.Instance);
            this.Visible = false;
        }
    }
}
