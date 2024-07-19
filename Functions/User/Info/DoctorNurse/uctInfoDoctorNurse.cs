using DentalService.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Info.DoctorNurse
{
    public partial class uctInfoDoctorNurse : UserControl
    {
        // Get instance
        private static uctInfoDoctorNurse instance;
        public static uctInfoDoctorNurse Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new uctInfoDoctorNurse();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        public uctInfoDoctorNurse()
        {
            InitializeComponent();
            instance = this;
            //this.Dock = DockStyle.Fill;

            LoadData();
        }


        // Add data
        private void LoadData()
        {
            var list = DataAccess.LoadTable.doctor_nurse;

            foreach (var item in list)
            {
                DoctorNurseBar doctorNurseBar = new DoctorNurseBar();
                fLPnContainer.Controls.Add(doctorNurseBar);
                doctorNurseBar.LoadData(
                    Image.FromFile(Path.Combine(DataAccess.LoadTable.imagePath, item.Avatar)),
                    item.FullName,
                    item.Position,
                    item.Description,
                    item.Education,
                    item.Hobby
                    );
            }
        }
    }
}
