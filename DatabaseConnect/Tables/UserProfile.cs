using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalService.DataAccess
{
    internal class UserProfile
    {
        public int UserID { get; set; }
        public int ClinicID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public bool IsAdmin { get; set; }
    }
}
