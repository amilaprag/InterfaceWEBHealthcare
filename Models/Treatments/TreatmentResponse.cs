using InterfaceWEBHealthcare.Models.Doctors;
using InterfaceWEBHealthcare.Models.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWEBHealthcare.Models.Treatments
{
    public class TreatmentResponse
    {
        public PrescriptionResponse PrescriptionResponse { get;set;}
    }

    public class PrescriptionResponse
    {
        private int prescriptionID;

        private DateTime prescriptionDate;

        private int  doctorID;
        private string doctorName;
        private string doctoremail;
        private string hospital;


        public int PrescriptionID { get => prescriptionID; set => prescriptionID = value; }
        public DateTime PrescriptionDate { get => prescriptionDate; set => prescriptionDate = value; }


        public List<Medicine> Medicine { get; set; }
        // public Doctor Doctor { get; set; }
        public PatientMasterData Patient { get; set; }
        public int DoctorID { get => doctorID; set => doctorID = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string Doctoremail { get => doctoremail; set => doctoremail = value; }
        public string Hospital { get => hospital; set => hospital = value; }
    }
    public class TreatmentSucessResponse
    {
        private string status;

        private string statusMessage;

        public string Status { get => status; set => status = value; }
        public string StatusMessage { get => statusMessage; set => statusMessage = value; }
    }
}
