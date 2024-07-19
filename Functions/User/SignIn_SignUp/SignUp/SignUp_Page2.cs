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
    public partial class SignUp_Page2 : UserControl
    {
        public SignUp_Page2()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        SignUp_Page3 page3;

        private void cbtnNext_Click(object sender, EventArgs e)
        {
            page3 = new SignUp_Page3();
            this.Parent.Controls.Add(page3);
            this.Parent.Controls.Remove(this);
        }
    }
}
