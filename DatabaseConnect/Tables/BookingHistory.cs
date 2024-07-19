using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalService.DataAccess
{
    internal class BookingHistory
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan BookingTime { get; set; }
        public string ServiceName { get; set; }
        public string DoctorName { get; set; }
        public string QRCode { get; set; }
        public string Status { get; set; }
    }
}
