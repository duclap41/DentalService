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

namespace DentalService.Info
{
    public partial class uctInfoDentist : UserControl
    {
        public uctInfoDentist()
        {
            InitializeComponent();
            instance = this;
            LoadData();
        }

        // Get instance
        private static uctInfoDentist instance;
        public static uctInfoDentist Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new uctInfoDentist();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        //
        public void LoadData()
        {

            var dentry = DataAccess.LoadTable.dentalClinic.First();
            rTxtInfo.Text = dentry.Description;
            rTxtContact.Text = "Email: " + dentry.Email + "\nHotline: " + dentry.Phone + "\nFacebook: " + dentry.Facebook;
            TxtAddress.Text = dentry.Address;
        }
    }
}
