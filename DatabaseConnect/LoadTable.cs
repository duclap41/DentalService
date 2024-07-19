using SqlKata.Execution;
using SqlKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace DentalService.DataAccess
{
    internal class LoadTable
    {
        public static string imagePath = @"../../SaveData";

        static QueryFactory db;

        public void LoadData()
        {
            db = MySQLConnector.Database("dentalservice");
            DentryLoad();
            ServicesLoad();
            DoctorNurseLoad();
            UserProfileLoad();
            BookingHistoryLoad();
        }

        // Dentry
        public static IEnumerable<DentalClinic> dentalClinic;
        private void DentryLoad()
        {
            Query query = db.Query("dentalclinic");
            dentalClinic = query.Get<DentalClinic>();
        }

        // Service list
        public static IEnumerable<Service> services;
        private void ServicesLoad()
        {
            Query query = db.Query("service");
            services = query.Get<Service>();
        }

        // Doctor Nurse
        public static IEnumerable<DoctorNurse> doctor_nurse;
        private void DoctorNurseLoad()
        {
            Query query = db.Query("doctornurse");
            doctor_nurse = query.Get<DoctorNurse>();
        }

        // User profile
        public static IEnumerable<UserProfile> userProfile;
        private void UserProfileLoad()
        {
            Query query = db.Query("UserProfile");
            userProfile = query.Get<UserProfile>();
        }
        public static void UpdateUserProfile(int userID, DateTime birthDate, string address,
                                            string phone, string email, string pwd)
        {
            int affectedRows = db.Query("UserProfile")
                         .Where("UserID", userID)
                         .Update(new
                         {
                             BirthDate = birthDate,
                             Address = address,
                             Phone = phone,
                             Email = email,
                             Pwd = pwd
                         });
        }
        public static void UpdatePassword(int userID, string pwd)
        {
            int affectedRows = db.Query("UserProfile")
                         .Where("UserID", userID)
                         .Update(new
                         {
                             Pwd = pwd
                         });
        }

        // Booking History
        public static IEnumerable<BookingHistory> bookingHistory;
        private void BookingHistoryLoad()
        {
            Query query = db.Query("BookingHistory");
            bookingHistory = query.Get<BookingHistory>();
        }
        public static void InsertBookingHistory(Dictionary<string, object> dict)
        {
            Query query = db.Query("BookingHistory").AsInsert(dict);
            int affectedRows = db.Execute(query);
        }
    }
}
