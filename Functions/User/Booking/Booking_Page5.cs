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
    public partial class Booking_Page5 : UserControl
    {
        // Get instance
        private static Booking_Page5 instance;
        public static Booking_Page5 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Booking_Page5();
                }
                instance.Visible = true;
                return instance;
            }
        }

        public Booking_Page5()
        {
            InitializeComponent();
            instance = this; // pay attention

            // Combo box month
            cbBMonth.SelectedIndex = 0;
        }

        private void cBtnNext_Click(object sender, EventArgs e)
        {
            uctBooking.Container.Controls.Add(Booking_Page6.Instance);
            this.Visible = false;
        }

        private void cBtnBack_Click(object sender, EventArgs e)
        {
            Booking_Page5.Instance.Select();
            this.Visible = false;
        }
    }
}
