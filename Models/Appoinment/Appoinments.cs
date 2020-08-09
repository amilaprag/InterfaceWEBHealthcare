using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using InterfaceWEBHealthcare.Models.Doctors;
using InterfaceWEBHealthcare.Models.Patient;
using EHealthCareAPI.Models.StaticData;
using InterfaceWEBHealthcare.Models.StaticData;

namespace InterfaceWEBHealthcare.Models.Appoinment
{
    public class Appoinments
    {
        //RelationShip between Patiens
        public PatientMasterData Patient { get; set; }

        //RelationShip between Doctor
        public Doctor Doctor { get; set; }

        // Relationsip between Hospital
        public Hospital Hospital { get; set; }


        [Key]
        public int AppoinmentsID { get => appoinmentsID; set => appoinmentsID = value; }
        public string TimeSlot { get => timeSlot; set => timeSlot = value; }
        public string Age { get => age; set => age = value; }
        public string ProblemBrief { get => problemBrief; set => problemBrief = value; }
        public DateTime AppoinmentDate { get => appoinmentDate; set => appoinmentDate = value; }
        public string AppoinmentsStatus { get => appoinmentsStatus; set => appoinmentsStatus = value; }

        private string appoinmentsStatus;

        private int appoinmentsID;

        private string timeSlot;

        private string age;

        private string problemBrief;

        private DateTime appoinmentDate;

        // Mapping AuthKey and TraceID
        private string authkey;
        private string traceId;
        [NotMapped]
        public string Authkey { get => authkey; set => authkey = value; }
        [NotMapped]
        public string TraceId { get => traceId; set => traceId = value; }
        
    }
}
