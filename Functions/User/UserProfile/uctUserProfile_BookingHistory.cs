using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;
using MySqlConnector;
using SqlKata;
using DentalService.Service;

namespace DentalService.UserProfile
{
    public partial class uctUserProfile_BookingHistory : UserControl
    {

        // Get instance
        private static uctUserProfile_BookingHistory instance;
        public static uctUserProfile_BookingHistory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new uctUserProfile_BookingHistory();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        public uctUserProfile_BookingHistory()
        {
            InitializeComponent();
            instance = this;
            this.Dock = DockStyle.Fill;

            GetCurrentUser();
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

        private void BookingHistory_Load(object sender, EventArgs e)
        {
            // Load all booking in initial
            LoadData("all");
            dGVHistory.Columns[0].Visible = false;

            vScrollBar1_Setup();

            // Make link cell clickable
            dGVHistory.CellContentClick += new DataGridViewCellEventHandler(dGVHistory_CellLinkClick);
            // Make scrollable by mouse wheel
            dGVHistory.MouseWheel += new MouseEventHandler(dGVHistory_MouseWheel);
        }

        void LoadData(string action, int idRow=-1)
        {
            // Clear recent rows
            dGVHistory.Rows.Clear();

            // Connect Database
            QueryFactory db = MySQLConnector.Database("dentalservice");
            Query query = db.Query("bookinghistory"); // table

            // Actions
            if (action == "search") // Search
            {
                if (cTxtSearch.Text.Trim().Length > 0)
                {
                    query = query.Where("ServiceName", cTxtSearch.Text.Trim()).OrWhere("ServiceName", cTxtSearch.Text.Trim());
                }
            }
            else if (action == "cancel") // Cancel booking
            {
                if (idRow == -1)
                    MessageBox.Show("Need id row that you want to cancel!");
                else
                {
                    query = query.Where("BookingID", idRow).AsUpdate(new
                    {
                        Status = "Cancelled",
                    });
                }
            }
            else if (action == "all") // Load add booking in table
            {
                // just keep stable
            }
            else if (action == "recent") // Load new booking
            {
                query = query.Where("BookingDate", ">" , DateTime.Now);
            }

            // Load data after choose action
            IEnumerable<DataAccess.BookingHistory> result = query.Get<DataAccess.BookingHistory>();
            foreach (var booking in result)
            {
                if (booking.UserID == currUser.UserID)
                {
                    dGVHistory.Rows.Add(new object[]
                    {
                        booking.BookingID,
                        booking.BookingDate,
                        booking.BookingTime,
                        booking.ServiceName,
                        booking.DoctorName,
                        booking.Status
                    });
                }
            }
        }

        // Search
        private void SearchEvent(object sender, EventArgs e)
        {
            LoadData("search");
        }

        // Cancel booking
        private void dGVHistory_CellLinkClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if cell is link cell
            if (dGVHistory.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                int idRow = (int)dGVHistory["Column1", e.RowIndex].Value;
                DateTime bookingDate = DateTime.Now;
                // check if date is valid
                var bookingHistory = DataAccess.LoadTable.bookingHistory;
                foreach (var booking in bookingHistory)
                {
                    if (booking.BookingID == idRow)
                    {
                        bookingDate = booking.BookingDate;
                        break;
                    }
                }
                TimeSpan difference = bookingDate - DateTime.Now;
                int daysDifference = Math.Abs(difference.Days);
                if (daysDifference < 2)
                {
                    DialogResult cancel = MessageBox.Show("Bạn chắc chắn muốn hủy chứ?", "Hủy lịch đặt!", MessageBoxButtons.OKCancel);
                    if (cancel == DialogResult.OK)
                    {
                        LoadData("cancel", idRow);
                        LoadData("all"); // reload
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không thể hủy lịch đặt này", "Cảnh báo", MessageBoxButtons.OK);
                }

                
            }
        }

        // mouse wheel scroll
        private void dGVHistory_MouseWheel(object sender, MouseEventArgs e)
        {
            int newValue = vScrollBar1.Value;

            // Scroll up
            if (e.Delta > 0)
            {
                newValue -= vScrollBar1.SmallChange;
                if (newValue < vScrollBar1.Minimum)
                {
                    newValue = vScrollBar1.Minimum;
                }
            }
            // Scroll down
            else if (e.Delta < 0)
            {
                newValue += vScrollBar1.SmallChange;
                if (newValue > vScrollBar1.Maximum - vScrollBar1.LargeChange + 1)
                {
                    newValue = vScrollBar1.Maximum - vScrollBar1.LargeChange + 1;
                }
            }

            // Set new value to prevent over scroll
            vScrollBar1.Value = newValue;

            // Make sure grid view scroll depend on scroll bar
            dGVHistory.FirstDisplayedScrollingRowIndex = dGVHistory.Rows[vScrollBar1.Value].Index;
        }

        // prevent selection
        private void dGVHistory_SelectionChanged(object sender, EventArgs e)
        {
            dGVHistory.ClearSelection();
        }

        private void cBtnAll_Click(object sender, EventArgs e)
        {
            LoadData("all");
        }

        private void cBtnRecent_Click(object sender, EventArgs e)
        {
            LoadData("recent");
        }


        // Scroll Bar
        private void vScrollBar1_Setup()
        {
            vScrollBar1.Minimum = 0;
            vScrollBar1.SmallChange = 1;
            vScrollBar1.Maximum = dGVHistory.RowCount - 1;
            vScrollBar1.LargeChange = dGVHistory.DisplayedRowCount(false);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dGVHistory.FirstDisplayedScrollingRowIndex = dGVHistory.Rows[vScrollBar1.Value].Index;
        }

        
    }
}
