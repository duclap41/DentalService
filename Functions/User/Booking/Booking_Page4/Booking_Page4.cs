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
    public partial class Booking_Page4 : UserControl
    {
        // Get instanced Booking_Page1 uct or create new if not instance. And Asure just one Booking_Page1 is running
        private static Booking_Page4 instance;
        public static Booking_Page4 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Booking_Page4();
                }
                instance.Visible = true;
                return instance;
            }
        }

        uctCalender uctCalender;

        public Booking_Page4()
        {
            InitializeComponent();
            instance = this;

            uctCalender = new uctCalender();
            pnContainer.Controls.Add(uctCalender);

            // Init
            choosedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            choosedTime = DateTime.Now;

            //
            GetCurrentUser();
        }

        // prevent choose time picked
        private void hidePickedTime(Label sender)
        {
            Label lbTime = (Label)sender;
            var bookHistory = DataAccess.LoadTable.bookingHistory;
            foreach (var book in bookHistory)
            {
                if (book.BookingDate == choosedDate)
                {
                    DateTime time = DateTime.ParseExact(lbTime.Text.Trim(), "HH:mm", CultureInfo.InvariantCulture);
                    TimeSpan timeSpan = time.TimeOfDay;
                    if (book.BookingTime == timeSpan)
                    {
                        lbTime1.Visible = false;
                        break;
                    }
                }
            }

        }

        public void hideAllPickedTime()
        {
            hidePickedTime(lbTime1);
            hidePickedTime(lbTime2);
            hidePickedTime(lbTime3);
            hidePickedTime(lbTime4);
            hidePickedTime(lbTime5);
            hidePickedTime(lbTime6);
        }

        private void Booking_Page1_Load(object sender, EventArgs e)
        {
            // Picking time in day
            lbTime1.Click += new EventHandler(chooseTime);
            lbTime2.Click += new EventHandler(chooseTime);
            lbTime3.Click += new EventHandler(chooseTime);
            lbTime4.Click += new EventHandler(chooseTime);
            lbTime5.Click += new EventHandler(chooseTime);
            lbTime6.Click += new EventHandler(chooseTime);

            

            // Default value of label notification valid time
            string date = choosedDate.ToString(" 'ngày' dd 'thg' MM 'năm' yyyy");
            lbNotifyValidTime.Text = "Thời gian còn trống trong ngày" + date;

            //
            //
            if (currUser != null)
            {
                choosedMail = currUser.Email;
            }

            //
            hideAllPickedTime();
        }


        // Choose time in day
        private void chooseTime(object sender, EventArgs e)
        {
            preventManyPick();

            Label lbTime = (Label)sender;
            lbTime.Parent.BackColor = Color.LightGray;

            // Update choosed date time
            choosedTime = DateTime.ParseExact(lbTime.Text.Trim(), "HH:mm", CultureInfo.InvariantCulture);
        }

        // Preven choose many time at once
        private void preventManyPick()
        {
            foreach (Control cell in tblPnTime.Controls)
            {

                if (cell.BackColor == Color.LightGray)
                {
                    cell.BackColor = Color.AliceBlue;
                    break; // optimize
                }
            }
        }

        // Get choosed day, month, year
        public static DateTime choosedDate;
        public static DateTime choosedTime;
        // Get value from picked date
        public void lbNotifyValidTime_Update(DateTime dateTime)
        {
            string date = dateTime.ToString(" 'ngày' dd 'thg' MM 'năm' yyyy");
            lbNotifyValidTime.Text = "Thời gian còn trống trong ngày" + date;
        }

        // get user
        DataAccess.UserProfile currUser;
        private void GetCurrentUser()
        {
            var profiles = DataAccess.LoadTable.userProfile;
            foreach (var user in profiles)
            {
                if (user.UserID == SignIn_SignUp.uctSignIn.userID)
                {
                    currUser = user;
                    break;
                }
            }
        }

        public static string choosedMail = "";
        private void cBtnNext_Click(object sender, EventArgs e)
        {
            if (SignIn_SignUp.uctSignIn.userID != -1)
            {
                uctBooking.Container.Controls.Add(Booking_Page6.Instance);
                Booking_Page6.Instance.LoadData(
                    currUser.UserID,
                    Booking_Page2.Booking_Page2.choosedService,
                    currUser.FullName,
                    Booking_Page4.choosedDate,
                    Booking_Page4.choosedTime,
                    Booking_Page3.Booking_Page3.choosedDoctor,
                    currUser.Gender,
                    currUser.BirthDate,
                    currUser.Address
                    );
            }
            else
            {
                uctBooking.Container.Controls.Add(Booking_Page5.Instance);
            }
            this.Visible = false;
        }

        private void cBtnBack_Click(object sender, EventArgs e)
        {
            Booking_Page3.Booking_Page3.Instance.Select();
            this.Visible = false;
        }
    }
}
