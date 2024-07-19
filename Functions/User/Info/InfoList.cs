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
using System.Xml.Linq;

namespace DentalService.Info
{
    public partial class InfoList : UserControl
    {
        // Get instance
        private static InfoList instance;
        public static InfoList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InfoList();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        public InfoList()
        {
            InitializeComponent();
            instance = this;
        }

        // mouse click
        private void lbDentist_Click(object sender, EventArgs e)
        {
            MainForm.Container.Controls.Add(uctInfoDentist.Instance);
        }

        private void lbDoctorNurse_Click(object sender, EventArgs e)
        {
            MainForm.Container.Controls.Add(DoctorNurse.uctInfoDoctorNurse.Instance);
        }

        // hover
        private void Event_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Underline);
        }
        private void Event_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, label.Font.Style & ~FontStyle.Underline);
        }
    }
}
