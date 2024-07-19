using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Info.DoctorNurse
{
    public partial class DoctorNurseBar : UserControl
    {
        public DoctorNurseBar()
        {
            InitializeComponent();
        }

        public void LoadData(Image ava, string name, string position,string description, string education, string hobby)
        {
            picAvatar.Image = ava;
            lbName.Text = $"{position}: {name}";
            lbDescription.Text = description;

            List<string> eduList = education.Split(';').ToList();
            foreach (string edu in eduList)
            {
                lBoxEducation.Items.Add("- " + edu);
            }

            List<string> hobbyList = hobby.Split(';').ToList();
            foreach (string hob in hobbyList)
            {
                lBoxHobby.Items.Add("- " + hob);
            }
        }
    }
}
