using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Booking.Calender
{
    public partial class uctCalender : UserControl
    {
        

        public uctCalender()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            DisplayDaysOfMonth();
        }

        // Display all days of month, year
        DateTime now = DateTime.Now;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        private void DisplayDaysOfMonth()
        {
            // check condition
            if (month > 12)
            {
                month = 1;
                year++;
            }
            else if (month < 1)
            {
                month = 12;
                year--;
            }

            // Update lb Month Year
            lbMonthYear.Text = $"Thg {month} Năm {year}"; 

            // get first day of month
            DateTime startOfMonth = new DateTime(year, month, 1);
            
            // Convert to interger
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

            // Add day blank cell to ignore previous
            for (int i = 0; i < dayOfWeek; i++)
            {
                System.Windows.Forms.Label blankCell = new System.Windows.Forms.Label();
                blankCell.Size = new Size(47, 35);
                blankCell.BackColor = Color.Transparent;
                fLPnDayContainer.Controls.Add(blankCell);
            }

            // add day number
            for (int i = 0; i < days; i++)
            {
                DayCell dayCell = new DayCell();
                dayCell.showDay(i);
                fLPnDayContainer.Controls.Add(dayCell);

                if (i == now.Day & month == now.Month & year == now.Year)
                {
                    dayCell.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (i < now.Day & month == now.Month & year == now.Year)
                {
                    dayCell.showDay(i, true);
                    dayCell.clickAble = false;
                }
            }
        }


        // Button process
        private void cPicButtonNext_Click(object sender, EventArgs e)
        {
            fLPnDayContainer.Controls.Clear(); // Clear old cell
            month++;
            DisplayDaysOfMonth();
            cPicButtonBack.Image = Properties.Resources.blue_back;

            // Update choosed date
            Booking_Page4.choosedDate = new DateTime(year, month, Booking_Page4.choosedDate.Day);
        }

        private void cPicButtonBack_Click(object sender, EventArgs e)
        {
            if (year == now.Year)
            {
                if (month > now.Month)
                {
                    fLPnDayContainer.Controls.Clear(); // Clear old cell
                    month--;
                    DisplayDaysOfMonth();
                }
                if (month == now.Month) // Change color when cannot roll back
                {
                    cPicButtonBack.Image = Properties.Resources.gray_back;
                }
            }
            else if (year > now.Year)
                {
                    fLPnDayContainer.Controls.Clear(); // Clear old cell
                    month--;
                    DisplayDaysOfMonth();
                }

            // Update choosed date
            Booking_Page4.choosedDate = new DateTime(year, month, Booking_Page4.choosedDate.Day);
        }
    }
}
