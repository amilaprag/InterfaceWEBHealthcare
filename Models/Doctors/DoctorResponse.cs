using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWEBHealthcare.Models.Doctors
{
    public class DoctorResponse
    {
        private DoctorDetails doctorDetails;

        public DoctorDetails DoctorDetails { get => doctorDetails; set => doctorDetails = value; }
    }
    public class DoctorDetails
    {
        private int doctorID;
        private string username;
        private DoctorResponseData doctorResponseData;
        public int DoctorID { get => doctorID; set => doctorID = value; }
        public string Username { get => username; set => username = value; }
        public DoctorResponseData DoctorResponseData { get => doctorResponseData; set => doctorResponseData = value; }
    }

    public class DoctorResponseData
    {
        private string surname;
        private string name;
        private string dateOfBirth;
        private string gender;
        private string homeAddress;
        private string department;
        private int mobileNumber;
        private int homeNumber;
        private int officeNumber;
        private string profileImageUrl;
        private string email;
        private string alias;
        private int doctorDataID;
        private int hospitalID;
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string HomeAddress { get => homeAddress; set => homeAddress = value; }
        public string Department { get => department; set => department = value; }
        public int MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public int HomeNumber { get => homeNumber; set => homeNumber = value; }
        public int OfficeNumber { get => officeNumber; set => officeNumber = value; }
        public string ProfileImageUrl { get => profileImageUrl; set => profileImageUrl = value; }
        public string Email { get => email; set => email = value; }
        public string Alias { get => alias; set => alias = value; }
        public int DoctorDataID { get => doctorDataID; set => doctorDataID = value; }
        public int HospitalID { get => hospitalID; set => hospitalID = value; }
    }
    public class DoctorSucessResponse
    {
        private string status;

        private string statusMessage;

        public string Status { get => status; set => status = value; }
        public string StatusMessage { get => statusMessage; set => statusMessage = value; }
    }
}
