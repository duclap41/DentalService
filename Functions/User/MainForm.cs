using DentalService.Booking;
using DentalService.Homepage;
using DentalService.SignIn_SignUp;
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

namespace DentalService
{
    public partial class MainForm : Form
    {
        // Constant
        static readonly Color COLOR_BUTTON_ENTER = Color.MintCream;
        static readonly Color COLOR_BUTTON_LEAVE = Color.Transparent;

        // Get instance
        private static MainForm instance;
        public static MainForm Instance
        {
            get
            {
                return instance;
            }
        }

        // Get panel container
        private static Panel container;
        public static Panel Container
        {
            get
            {
                clearButKeepDropBox(container, needToKeep); // free memmory
                dropBoxKeeper.Visible = false;
                return container;
            }
        }

        static CustomTableLayoutPanel dropBoxKeeper;
        static Control[] needToKeep;
        // change back color
        static Label label01 = new Label();
        static Label label02 = new Label();
        public MainForm()
        {
            InitializeComponent();
            instance = this;
            // Homepage in default
            pnContainer.Controls.Add(uctHomepage.Instance);
            // call pnContainer
            container = pnContainer;
            // Load all data
            DataAccess.LoadTable data = new DataAccess.LoadTable();
            data.LoadData();

            // save
            dropBoxKeeper = tLPnDropBox; // because you can make it instantly hiding after click
            dropBoxKeeper.MouseLeave += dropBoxKeeper_MouseLeave;
            needToKeep = new Control[] { picQrScan, pnContainChat, picOpenChat, dropBoxKeeper };

            //for change color when click
            label01 = lbButtonService;
            label02 = lbButtonInfo;
            // init user id
            SignIn_SignUp.uctSignIn.userID = -1;
            // 
            pnContainChat.Controls.Add(Chat.uctChat.Instance);
        }

        // show profile section
        public void ShowUserProfile()
        {
            lbButtonUserProfile.Visible = true;
        }
        // hide cBtnSignIn
        public void HideBtnSignIn()
        {
            cBtnSignIn.Visible = false;
        }

    // free memmory for dropbox
    static void clearButKeepDropBox(Panel panel, Control[] controls)
        {
            label01.BackColor = COLOR_BUTTON_LEAVE;
            label02.BackColor = COLOR_BUTTON_LEAVE;
            foreach (Control control in panel.Controls)
            {
                if (!controls.Contains(control))
                {
                    panel.Controls.Remove(control);
                }
            }
        }

        #region->Click Event
        // Homepage Click
        private void lbButtonHomepage_Click(object sender, EventArgs e)
        {
            Container.Controls.Add(uctHomepage.Instance);
        }

        // User Profile Click
        private void lbButtonUserProfile_Click(object sender, EventArgs e)
        {
            Container.Controls.Add(UserProfile.uctUserProfile.Instance);
        }

        // SignIn/ SignUp Click
        private void cBtnSignIn_Click(object sender, EventArgs e)
        {
            Container.Controls.Add(uctSignIn.Instance);
        }

        private void cBtnBooking_Click(object sender, EventArgs e)
        {
            Container.Controls.Add(uctBooking.Instance);
        }

        // qr scan
        private void picQrScan_Click(object sender, EventArgs e)
        {
            QrCode.QrScan.Instance.Select();
        }

        // open chat
        private void picOpenChat_Click(object sender, EventArgs e)
        {
            pnContainChat.Visible = true;
        }
        // close chat
        private void picCloseChat_Click(object sender, EventArgs e)
        {
            pnContainChat.Visible = false;
        }
        #endregion

        #region->Window Control
        // Window button
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picZoom_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                picZoom.Image = Properties.Resources.zoom_in;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                picZoom.Image = Properties.Resources.zoom_out;
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Move window
        private bool isDragging = false;
        private Point dragStartPoint = Point.Empty;
        private void pnWindowControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void pnWindowControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPosition = PointToScreen(e.Location);
                Location = new Point(currentScreenPosition.X - dragStartPoint.X, currentScreenPosition.Y - dragStartPoint.Y);
            }
        }

        private void pnWindowControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        #endregion

        #region->Mouse Hover
        // underline selection
        private void lbButtonHomepage_MouseEnter(object sender, EventArgs e)
        {
            lbButtonHomepage.BackColor = COLOR_BUTTON_ENTER;
            lbButtonHomepage.Font = new Font(lbButtonHomepage.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void lbButtonHomepage_MouseLeave(object sender, EventArgs e)
        {
            lbButtonHomepage.BackColor = COLOR_BUTTON_LEAVE;
            lbButtonHomepage.Font = new Font(lbButtonHomepage.Font, lbButtonHomepage.Font.Style & ~FontStyle.Underline);
        }


        private void lbButtonUserProfile_MouseEnter(object sender, EventArgs e)
        {
            lbButtonUserProfile.BackColor = COLOR_BUTTON_ENTER;
            lbButtonUserProfile.Font = new Font(lbButtonUserProfile.Font, FontStyle.Underline | FontStyle.Bold);
        }


        private void lbButtonUserProfile_MouseLeave(object sender, EventArgs e)
        {
            lbButtonUserProfile.BackColor = COLOR_BUTTON_LEAVE;
            lbButtonUserProfile.Font = new Font(lbButtonUserProfile.Font, lbButtonUserProfile.Font.Style & ~FontStyle.Underline);
        }

        // Show and hide Dropbox
        private void lbButtonService_MouseEnter(object sender, EventArgs e)
        {
            lbButtonInfo.BackColor = COLOR_BUTTON_LEAVE;
            lbButtonService.BackColor = COLOR_BUTTON_ENTER;
            lbButtonService.Font = new Font(lbButtonService.Font,FontStyle.Underline | FontStyle.Bold);

            DropBox_Load(dropBoxKeeper, "service", true);
        }

        private void lbButtonService_MouseLeave(object sender, EventArgs e)
        {
            if (!lbButtonService.ClientRectangle.Contains(lbButtonService.PointToClient(Cursor.Position)) &&
                !dropBoxKeeper.ClientRectangle.Contains(dropBoxKeeper.PointToClient(Cursor.Position)))
            {
                lbButtonService.BackColor = COLOR_BUTTON_LEAVE;
                lbButtonService.Font = new Font(lbButtonService.Font, lbButtonService.Font.Style & ~FontStyle.Underline);

                DropBox_Load(dropBoxKeeper, "service", false);
            }
        }

        private void lbButtonInfo_MouseEnter(object sender, EventArgs e)
        {
            lbButtonService.BackColor = COLOR_BUTTON_LEAVE;
            lbButtonInfo.BackColor = COLOR_BUTTON_ENTER;
            lbButtonInfo.Font = new Font(lbButtonInfo.Font, FontStyle.Underline | FontStyle.Bold);

            DropBox_Load(dropBoxKeeper, "info", true);
        }

        private void lbButtonInfo_MouseLeave(object sender, EventArgs e)
        {
            if (!lbButtonInfo.ClientRectangle.Contains(lbButtonInfo.PointToClient(Cursor.Position)) &&
                !dropBoxKeeper.ClientRectangle.Contains(dropBoxKeeper.PointToClient(Cursor.Position)))
            {
                lbButtonInfo.BackColor = COLOR_BUTTON_LEAVE;
                lbButtonInfo.Font = new Font(lbButtonInfo.Font, lbButtonInfo.Font.Style & ~FontStyle.Underline);

                DropBox_Load(dropBoxKeeper, "info", false);
            }
        }

        private void dropBoxKeeper_MouseLeave(object sender, EventArgs e)
        {
            var mousePosition = Cursor.Position;
            if (!lbButtonService.RectangleToScreen(lbButtonService.ClientRectangle).Contains(mousePosition) &&
                !dropBoxKeeper.RectangleToScreen(dropBoxKeeper.ClientRectangle).Contains(mousePosition))
            {
                lbButtonService.BackColor = COLOR_BUTTON_LEAVE;
                lbButtonService.Font = new Font(lbButtonService.Font, lbButtonService.Font.Style & ~FontStyle.Underline);
                DropBox_Load(dropBoxKeeper, "service", false);
            }

            if (!lbButtonInfo.RectangleToScreen(lbButtonInfo.ClientRectangle).Contains(mousePosition) &&
                !dropBoxKeeper.RectangleToScreen(dropBoxKeeper.ClientRectangle).Contains(mousePosition))
            {
                lbButtonInfo.BackColor = COLOR_BUTTON_LEAVE;
                lbButtonInfo.Font = new Font(lbButtonInfo.Font, lbButtonInfo.Font.Style & ~FontStyle.Underline);
                DropBox_Load(dropBoxKeeper, "info", false);
            }
        }

        // Droplist
        private void DropBox_Load(CustomTableLayoutPanel dropBox, string section = null, bool isLoad = true)
        {
            dropBox.Controls.Clear();
            if (!isLoad)
            {
                dropBox.Visible = false;
            }
            else // Add new drop list
            {
                dropBox.Visible = true;
                dropBox.BringToFront();
                if (section == "service")
                {
                    dropBox.Controls.Add(Service.ServiceList.Instance, 2, 0);
                    Service.ServiceList.Instance.Margin = new Padding(5, 0, 0, 1);
                    Service.ServiceList.Instance.BackColor = COLOR_BUTTON_ENTER;
                }
                else if (section == "info")
                {
                    dropBox.Controls.Add(Info.InfoList.Instance, 1, 0);
                    Info.InfoList.Instance.Margin = new Padding(5, 0, 5, 1);
                    Info.InfoList.Instance.BackColor = COLOR_BUTTON_ENTER;
                }
            }
        }

        #endregion

        
    }
}
