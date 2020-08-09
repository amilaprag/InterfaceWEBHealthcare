using EHealthCareAPI.Models.StaticData;
using InterfaceWEBHealthcare.Models.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWEBHealthcare.Models.Doctors
{
    public class DoctorData
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
        private string doctorImageUrl;

        public int DoctorDataID { get => doctorDataID; set => doctorDataID = value; }
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
        public string DoctorImageUrl { get => doctorImageUrl; set => doctorImageUrl = value; }

        // Relationsip 
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }

        // Relationsip between Hospital
        public Hospital Hospital { get; set; }
        public int HospitalID { get; set; }
       
    }
}
