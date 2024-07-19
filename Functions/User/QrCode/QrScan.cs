using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using DentalService.Booking.Booking_Page7;
using ZXing; 

namespace DentalService.QrCode
{
    public partial class QrScan : Form
    {
        

        // Get instance
        private static QrScan instance;
        public static QrScan Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new QrScan();
                }
                instance.ShowDialog();
                return instance;
            }
        }

        public QrScan()
        {
            InitializeComponent();
            instance = this;
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //
            //genQrCode genQrCode = new genQrCode();
            //picCamera.Image = genQrCode.GenerateQRCodeImage(15);
        }


        #region->Qr Scan
        // get camera
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private void BtnScan_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += videoSource_NewFrame;
            videoSource.Start();
            timer1.Enabled = true;
            timer1.Start();

            //timer1.Stop();
            //stream.Stop();
        }
        public void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            picCamera.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var bookingHistory = DataAccess.LoadTable.bookingHistory;
            var userProfile = DataAccess.LoadTable.userProfile;

            Bitmap img = (Bitmap)picCamera.Image;
            if (img != null)
            {
                ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                Result result = Reader.Decode(img);
                try
                {
                    if (result != null)
                    {
                        string decoded = result.ToString().Trim();
                        textBox1.Text = decoded;
                        foreach (var booking in  bookingHistory)
                        {
                            if (booking.QRCode == decoded)
                            {
                                string name = "";
                                string gender = "Male";
                                DateTime birthDate = DateTime.Now;
                                string address = "";
                                foreach (var user in userProfile)
                                {
                                    if (user.UserID == booking.UserID)
                                    {
                                        name = user.FullName;
                                        gender = user.Gender;
                                        birthDate = user.BirthDate;
                                        address = user.Address;
                                        break;
                                    }
                                }

                                MainForm.Container.Controls.Add(Booking.EditBooking.Instance);
                                Booking.EditBooking.Instance.LoadData(
                                    booking.ServiceName,
                                    name,
                                    booking.BookingDate,
                                    booking.BookingTime,
                                    booking.DoctorName,
                                    gender,
                                    birthDate,
                                    address
                                    );
                                break;
                            }
                        }

                        // free memmory
                        this.Close();
                        timer1.Stop();
                        videoSource.Stop();
                    }
                    img.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }

            }
        }
        #endregion

        #region->Window Control
        // Window button
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

            // dispose cam
            timer1.Stop();
            if (videoSource != null)
                videoSource.Stop();
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
    }
}
