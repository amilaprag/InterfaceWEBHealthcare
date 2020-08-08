 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWEBHealthcare.Models.Patient.PatientResponse
{
     public class  PatientResponse
    {
        private PatientDetails patientDetails;

        public PatientDetails PatientDetails { get => patientDetails; set => patientDetails = value; }
    }
     public class PatientDetails
    {
            private int patientID;
            private string username;

            private PatientResponseData patientData;
            public string Username { get => username; set => username = value; }
            public int PatientID { get => patientID; set => patientID = value; }
            public PatientResponseData PatientData { get => patientData; set => patientData = value; }
    }
     public class PatientResponseData
    {
            //private string PatientID
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
        }
     public class PatientSucessResponse
    {
        private string status;

        private string statusMessage;

        public string Status { get => status; set => status = value; }
        public string StatusMessage { get => statusMessage; set => statusMessage = value; }
    }

}
