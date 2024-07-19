using DentalService.Booking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Homepage
{
    public partial class uctHomepage : UserControl
    {
        public uctHomepage()
        {
            InitializeComponent();
            instance = this;

            this.Dock = DockStyle.Fill;
        }

        // Get instance
        private static uctHomepage instance;
        public static uctHomepage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new uctHomepage();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        private void cBtnSignUp_Click(object sender, EventArgs e)
        {
            MainForm.Container.Controls.Add(Booking.uctBooking.Instance);
            Booking.uctBooking.Instance.BringToFront();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            MainForm.Container.Controls.Add(Booking.uctBooking.Instance);
        }
    }
}
