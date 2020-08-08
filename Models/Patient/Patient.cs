using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using EHealthCareAPI.Models.Appoinment;

namespace InterfaceWEBHealthcare.Models.Patient
{
    public class PatientMasterData
    {
        private int patientMasterDataID;
        private string password;
        private string username;
        private string userStatus;


        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public int PatientMasterDataID { get => patientMasterDataID; set => patientMasterDataID = value; }
        public string UserStatus { get => userStatus; set => userStatus = value; }

        // PatientData Relationship
        public PatientData PatientData { get; set; }
        public PatientData PatientDataID;

        // Mapping AuthKey and TraceID
        private string authkey;
        private string traceId;
        [NotMapped]
        public string Authkey { get=> authkey; set=> authkey=value; }
        [NotMapped]
        public string TraceId { get => traceId; set => traceId = value; }

    }
}


