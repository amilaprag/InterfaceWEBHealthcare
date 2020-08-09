//using EHealthCareAPI.Models.Appoinment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using EHealthCareAPI.Models.Treatments;
using System.ComponentModel.DataAnnotations.Schema;
using EHealthCareAPI.Models.StaticData;

namespace InterfaceWEBHealthcare.Models.Doctors
{
    public class Doctor
    {
        private int doctorID;
        private string password;
        private string username;
        private string userStatus;
      
        public int DoctorID { get => doctorID; set => doctorID = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string UserStatus { get => userStatus; set => userStatus = value; }

        // Relationsip between DoctorData
        public DoctorData DoctorData { get; set; }


        // Mapping AuthKey and TraceID
        private string authkey;
        private string traceId;
        [NotMapped]
        public string Authkey { get => authkey; set => authkey = value; }
        [NotMapped]
        public string TraceId { get => traceId; set => traceId = value; }
      
    }
}
