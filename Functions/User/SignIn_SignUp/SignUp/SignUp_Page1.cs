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
    public partial class SignUp_Page1 : UserControl
    {
        public SignUp_Page1()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        SignUp_Page2 page2;
        private void cbtnNext_Click(object sender, EventArgs e)
        {
            page2 = new SignUp_Page2();
            this.Parent.Controls.Add(page2);
            this.Parent.Controls.Remove(this);
        }
    }
}
