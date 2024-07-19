using SqlKata.Execution;
using SqlKata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalService.Chat;

namespace DentalService.SignIn_SignUp
{
    public partial class uctSignIn : UserControl
    {
        // Get instance
        private static uctSignIn instance;
        public static uctSignIn Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new uctSignIn();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        public uctSignIn()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

        }

        // when succes login
        public static int userID;

        // Create new account
        SignUp.uctSignUp uctSignUp;
        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uctSignUp = new SignUp.uctSignUp();
            this.Parent.Controls.Add(uctSignUp);
            this.Parent.Controls.Remove(this);
        }

        // Login
        private void cBtnSignIn_Click(object sender, EventArgs e)
        {
            var userprofile = DataAccess.LoadTable.userProfile;

            foreach (var user in userprofile)
            {
                if (cTxtEmail.Texts == user.Email)
                {
                    if (cTxtPwd.Texts == user.Pwd)
                    {
                        MainForm.Container.Controls.Add(Homepage.uctHomepage.Instance);
                        MainForm.Instance.ShowUserProfile();
                        userID = user.UserID;

                        // hide button
                        MainForm.Instance.HideBtnSignIn();
                        uctChat.Instance.ChangeMessage();

                        break;
                    }
                }
            }
            lbWarning.Visible = true;
        }

        private void lLbForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgetPwd.Instance.Select();
        }
    }
}
