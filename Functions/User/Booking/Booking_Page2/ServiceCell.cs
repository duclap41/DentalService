using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Booking.Booking_Page2
{
    public partial class ServiceCell : UserControl
    {
        public ServiceCell()
        {
            InitializeComponent();
        }

        private void lbPnCell_Click(object sender, EventArgs e)
        {
            preventManyPick();
            cPnCell.BackColor = Color.LightGray;

            // Save choosed value
            Booking_Page2.choosedService = lbPnCell.Text;
            Booking_Page2.Instance.LbNotify_Update(Booking_Page2.choosedService);
        }

        // Prevent can pick many day at once time
        private void preventManyPick()
        {
            foreach (Control cell in this.Parent.Controls)
            {
                if (cell.Controls[0].BackColor == Color.LightGray)
                {
                    cell.Controls[0].BackColor = SystemColors.Control;
                    break;
                }
            }
        }

        //
        public void LoadData(string name)
        {
            lbPnCell.Text = name;
        }
    }
}
