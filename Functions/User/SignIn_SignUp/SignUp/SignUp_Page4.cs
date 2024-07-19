using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.SignIn_SignUp.SignUp
{
    public partial class SignUp_Page4 : UserControl
    {
        public SignUp_Page4()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        // Send notification about created a new account
        private void SendMail()
        {

        }

        // Back to Sign In
        uctSignIn uctSignIn;
        private void cbtnSignIn_Click(object sender, EventArgs e)
        {
            uctSignIn = new uctSignIn();
            this.Parent.Parent.Parent.Parent.Controls.Add(uctSignIn);
            this.Parent.Parent.Parent.Parent.Controls.Remove(this.Parent.Parent.Parent);
        }
    }
}
