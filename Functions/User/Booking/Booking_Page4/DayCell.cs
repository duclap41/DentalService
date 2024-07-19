using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Booking.Calender
{
    public partial class DayCell : UserControl
    {
        public DayCell()
        {
            InitializeComponent();

            Booking_Page4.Instance.hideAllPickedTime();
        }

        public void showDay(int numDay, bool strikeout = false)
        {
            lbDay.Text = numDay.ToString();
            if (strikeout)
            {
                lbDay.Font = new Font(lbDay.Font, FontStyle.Strikeout);
                lbDay.ForeColor = Color.LightGray;
            }
        }

        public bool clickAble = true;
        private void lbDay_Click(object sender, EventArgs e)
        {
            if (clickAble) 
            {
                preventManyPick();
                this.BackColor = Color.LightGray;

                // Update save variable
                Booking_Page4.choosedDate = new DateTime(Booking_Page4.choosedDate.Year,
                                                    Booking_Page4.choosedDate.Month,
                                                    Convert.ToInt32(lbDay.Text));
                Booking_Page4.Instance.lbNotifyValidTime_Update(Booking_Page4.choosedDate);

                Booking_Page4.Instance.hideAllPickedTime();
            }
        }

        // Prevent can pick many day at once time
        private void preventManyPick()
        {
            foreach (Control cell in this.Parent.Controls)
            {
                if (cell.BackColor == Color.LightGray)
                {
                    cell.BackColor = Color.Transparent;
                    break;
                }
            }
        }
    }
}
