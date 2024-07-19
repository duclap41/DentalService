using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Booking.Booking_Page3
{
    public partial class DoctorCell : UserControl
    {
        public DoctorCell()
        {
            InitializeComponent();
        }

        private void DoctorCell_Load(object sender, EventArgs e)
        {
            AllControls_Click();
        }

        // When click on any controls in cTbLPnCell
        private void AllControls_Click()
        {
            cPicAvatar.Click += new EventHandler(EventClick);
            lbName.Click += new EventHandler(EventClick);
            lbMajor.Click += new EventHandler(EventClick);
            cTbLPnCell.Click += new EventHandler(EventClick);
        }

        // create event click can use for any controls
        private void EventClick(object sender, EventArgs e)
        {
            preventManyPick();
            Control control = sender as Control;
            cTbLPnCell.BackColor = Color.LightGray;

            // Save choosed doctor
            Booking_Page3.choosedDoctor = lbName.Text.Split(',')[0];
            Booking_Page3.Instance.LbNotify_Update(Booking_Page3.choosedDoctor);
        }

        // Prevent can pick many day at once time
        private void preventManyPick()
        {
            foreach (Control cell in this.Parent.Controls)
            {
                if (cell.Controls[0].BackColor == Color.LightGray)
                {
                    cell.Controls[0].BackColor = SystemColors.Control;
                    break;
                }
            }
        }

        //
        public void LoadData(string name, string gender)
        {
            lbName.Text = name;
            if (gender == "Male" )
            {
                cPicAvatar.Image = Properties.Resources.doctor_male;
            }
            else { cPicAvatar.Image = Properties.Resources.doctor_female; }
        }
    }
}
