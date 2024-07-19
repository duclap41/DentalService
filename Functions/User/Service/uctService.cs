using DentalService.Booking;
using SqlKata;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DentalService.Service
{
    public partial class uctService : UserControl
    {
        public uctService()
        {
            InitializeComponent();
            instance = this;

            this.Dock = DockStyle.Fill;
        }

        // Get instance
        private static uctService instance;
        public static uctService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new uctService();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        //
        public void LoadData(string serviceName)
        {
            var services = DataAccess.LoadTable.services;
            foreach (var service in services)
            {
                if (service.ServiceName == serviceName)
                {
                    lbName.Text = service.ServiceName;
                    rTxtServiceInfo.Text = service.ServiceInfo;
                    cPicImage.Image = Image.FromFile(Path.Combine(DataAccess.LoadTable.imagePath, service.ServiceImage));
                    lbCost.Text = "Chi phí chỉ từ " + service.Cost.ToString() + " đồng!";
                    foreach (var item in service.ServiceAdvantages.Split(';'))
                    {
                        lBAdvantages.Items.Add("- " + item);
                    }
                    foreach (var item in service.Doctors.Split(';'))
                    {
                        lBDoctors.Items.Add("- " + item);
                    }

                }
            }
        }

        private void cBtnBooking_Click(object sender, EventArgs e)
        {
            MainForm.Container.Controls.Add(Booking.uctBooking.Instance);
        }
    }
}
