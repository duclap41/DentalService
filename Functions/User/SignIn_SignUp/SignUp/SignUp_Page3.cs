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
    public partial class SignUp_Page3 : UserControl
    {
        public SignUp_Page3()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        SignUp_Page4 page4;
        private void cbtnDone_Click(object sender, EventArgs e)
        {
            page4 = new SignUp_Page4();
            this.Parent.Controls.Add(page4);
            this.Parent.Controls.Remove(this);
        }
    }
}
