using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Service
{
    public partial class ServiceName : UserControl
    {
        public ServiceName()
        {
            InitializeComponent();
        }

        public void LoadData(string nameService)
        {
            lbName.Text = nameService;
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            // load that service in service form
            MainForm.Container.Controls.Add(uctService.Instance);
            uctService.Instance.LoadData(lbName.Text);
        }

        private void lbName_MouseEnter(object sender, EventArgs e)
        {
            lbName.Font = new Font(lbName.Font, FontStyle.Underline);
        }

        private void lbName_MouseLeave(object sender, EventArgs e)
        {
            lbName.Font = new Font(lbName.Font, lbName.Font.Style & ~FontStyle.Underline);
        }
    }
}
