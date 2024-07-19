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

namespace DentalService.UserProfile
{
    public partial class uctUserProfile : UserControl
    {
        // Get instance
        private static UserProfile.uctUserProfile instance;
        public static UserProfile.uctUserProfile Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserProfile.uctUserProfile();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        public uctUserProfile()
        {
            InitializeComponent();
            instance = this;
            this.Dock = DockStyle.Fill;

            PnContainer.Controls.Add(uctUserProfile_Info.Instance);
        }

        private void cbtnInfo_Click(object sender, EventArgs e)
        {
            PnContainer.Controls.Clear();
            PnContainer.Controls.Add(uctUserProfile_Info.Instance);
        }

        private void cbtnHistoryBooking_Click(object sender, EventArgs e)
        {
            PnContainer.Controls.Clear();
            PnContainer.Controls.Add(uctUserProfile_BookingHistory.Instance);
        }
    }
}
