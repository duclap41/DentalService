using DentalService.Booking.Calender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DentalService.Booking
{
    public partial class uctBooking : UserControl
    {
        // Get instance
        private static uctBooking instance;
        public static uctBooking Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new uctBooking();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                instance.OpenPage();
                return instance;
            }
        }


        public uctBooking()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            // get panel container
            container = pnContainer;
        }

        // open page
        private void OpenPage()
        {
            pnContainer.Controls.Clear();
            if (SignIn_SignUp.uctSignIn.userID != -1)
            {
                pnContainer.Controls.Add(Booking_Page2.Booking_Page2.Instance);
            }
            else { pnContainer.Controls.Add(Booking_Page1.Instance); }
        }


        // Get panel container
        private static Panel container;
        public static Panel Container
        {
            get
            {
                return container;
            }
        }
    }
}
