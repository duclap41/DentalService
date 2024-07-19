using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalService.DataAccess
{
    internal class DoctorNurse
    {
        public int DoctorNurseID { get; set; }
        public int ClinicID { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Description { get; set; }
        public string Hobby { get; set; }
    }
}
