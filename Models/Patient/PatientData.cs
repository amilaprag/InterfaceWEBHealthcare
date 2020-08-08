using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWEBHealthcare.Models.Patient
{
    public class PatientData
    {
        private int patientDataID;
        private string surname;
        private string name;
        private string dateOfBirth;
        private string gender;
        private string homeAddress;
        private string workAdderss;
        private string mobileNumber;
        private string homeNumber;
        private string officeNumber;
        private string depentes;
        private string imageUrl;
        private string email;
        private string officeEmail;
        private string alias;


        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string HomeAddress { get => homeAddress; set => homeAddress = value; }
        public string Depentes { get => depentes; set => depentes = value; }
        public string WorkAdderss { get => workAdderss; set => workAdderss = value; }
        public string MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public string HomeNumber { get => homeNumber; set => homeNumber = value; }
        public string OfficeNumber { get => officeNumber; set => officeNumber = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public string OfficeEmail { get => officeEmail; set => officeEmail = value; }
        public string Email { get => email; set => email = value; }
        public string Alias { get => alias; set => alias = value; }
        public int PatientDataID { get => patientDataID; set => patientDataID = value; }

        //Relationship between PatientMasterData
        public int PatientMasterDataID { get; set; }
        public PatientMasterData Patients { get; set; }
    }

    public class PatientFeedbackData {

        private int patientDataID;

        private int patientFeedbackHospital;

        private int patientFeedbackDoctor;

        private int prescriptionID;

        public int PatientDataID { get => patientDataID; set => patientDataID = value; }
        public int PatientFeedbackHospital { get => patientFeedbackHospital; set => patientFeedbackHospital = value; }
        public int PatientFeedbackDoctor { get => patientFeedbackDoctor; set => patientFeedbackDoctor = value; }
        public int PrescriptionID { get => prescriptionID; set => prescriptionID = value; }


        private string authkey;
        private string traceId;
        private string feedbackHospital;
        private string feedbackDoctor;

        [NotMapped]
        public string Authkey { get => authkey; set => authkey = value; }
        [NotMapped]
        public string TraceId { get => traceId; set => traceId = value; }
        [NotMapped]
        public string FeedbackHospital { get => feedbackHospital; set => feedbackHospital = value; }
        [NotMapped]
        public string FeedbackDoctor { get => feedbackDoctor; set => feedbackDoctor = value; }
    }
}
