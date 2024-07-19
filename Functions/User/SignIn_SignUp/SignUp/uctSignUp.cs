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
    public partial class uctSignUp : UserControl
    {
        static uctSignUp instance;
        public static uctSignUp Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new uctSignUp();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        SignUp_Page1 page1;

        public uctSignUp()
        {
            InitializeComponent();
            instance = this;

            this.Dock = DockStyle.Fill;
            page1 = new SignUp_Page1();
            pnContent.Controls.Add(page1);
        }
    }
}
