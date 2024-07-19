using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalService.DataAccess
{
    internal class Service
    {
        public int ServiceID { get; set; }
        public int ClinicID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceImage { get; set; }
        public string ServiceInfo { get; set; }
        public string ServiceAdvantages { get; set; }
        public string Doctors { get; set; }
        public decimal Cost { get; set; }
    }
}
