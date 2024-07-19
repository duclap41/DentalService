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

namespace DentalService.UserProfile
{
    public partial class uctUserProfile_Info : UserControl
    {
        
        public uctUserProfile_Info()
        {
            InitializeComponent();
            instance = this;
            this.Dock = DockStyle.Fill;
 
            GetCurrentUser();
            LoadData();
        }

        // Get instance
        private static UserProfile.uctUserProfile_Info instance;
        public static UserProfile.uctUserProfile_Info Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserProfile.uctUserProfile_Info();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
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

        private void LoadData()
        {
            txtEmail.Texts = currUser.Email;
            txtPhone.Texts = currUser.Phone;
            txtDay.Texts = currUser.BirthDate.Day.ToString();
            cBMonth.Texts = "Tháng " + currUser.BirthDate.Month.ToString();
            txtYear.Texts = currUser.BirthDate.Year.ToString();
            txtAddress.Texts = currUser.Address;
        }

        Dictionary<string, int> monthMapping = new Dictionary<string, int>()
        {
            { "Tháng 1", 1 },
            { "Tháng 2", 2 },
            { "Tháng 3", 3 },
            { "Tháng 4", 4 },
            { "Tháng 5", 5 },
            { "Tháng 6", 6 },
            { "Tháng 7", 7 },
            { "Tháng 8", 8 },
            { "Tháng 9", 9 },
            { "Tháng 10", 10 },
            { "Tháng 11", 11 },
            { "Tháng 12", 12 }
        };
        // Update profile
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPwd1.Texts != null)
            {
                if (txtPwd2.Texts != txtPwd1.Texts)
                {
                    lbWarning.Visible = true;
                }
                else
                {
                    currUser.Pwd = txtPwd1.Texts;
                }
            }
            // updating
            DataAccess.LoadTable.UpdateUserProfile(
                currUser.UserID,
                new DateTime(int.Parse(txtYear.Texts.Trim()), monthMapping[cBMonth.Texts.Trim()], int.Parse(txtDay.Texts.Trim())),
                txtAddress.Texts.Trim(),
                txtPhone.Texts.Trim(),
                txtEmail.Texts.Trim(),
                currUser.Pwd
                );

        }
    }
}
