using InterfaceWEBHealthcare.Models.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceWEBHealthcare.Models.Patient;
using InterfaceWEBHealthcare.Encryption;
using System.ComponentModel.DataAnnotations.Schema;
using InterfaceWEBHealthcare.Models.Appoinment;

namespace InterfaceWEBHealthcare.Models.Treatments
{
    public class Prescription
    {
        private int prescriptionID;

        private DateTime prescriptionDate;

        private string diagnosis;

        //public string PatientName { get ; set; }
        //public string DoctorName { get; set; }



        public int PrescriptionID { get => prescriptionID; set => prescriptionID = value; }
        public DateTime PrescriptionDate { get => prescriptionDate; set => prescriptionDate = value; }
        public string Diagnosis { get => diagnosis; set => diagnosis = value; }

        //RelationShip between Medicine
        public List<Medicine> Medicine { get; set; }


        //RelationShip between Doctor
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }

        //RelationShip between Patient
        public PatientMasterData Patient { get; set; }

        //RelationShip between Key
        public KeyInfo KeyInfo { get; set; }

        //RelationShip between Key
        public Appoinments Appoinment { get; set; }

        // Mapping AuthKey and TraceID
        private string authkey;
        private string traceId;
        [NotMapped]
        public string Authkey { get => authkey; set => authkey = value; }
        [NotMapped]
        public string TraceId { get => traceId; set => traceId = value; }
       
    }
}
