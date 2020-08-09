using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWEBHealthcare.Models.Treatments
{
    public class Medicine
    {
        private int medicineID;
        private string strength;
        private string form;
        private string route;
        private string quantity;
        private string dosage;
        private string frequency;
        private string startDate;
        private string endDate;
        private string instructions;
        private string instructionsNotes;
        private string status;


        public string Strength { get => strength; set => strength = value; }
        public string Form { get => form; set => form = value; }
        public string Route { get => route; set => route = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Dosage { get => dosage; set => dosage = value; }
        public string Frequency { get => frequency; set => frequency = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string Instructions { get => instructions; set => instructions = value; }
        public string InstructionsNotes { get => instructionsNotes; set => instructionsNotes = value; }
        public string Status { get => status; set => status = value; }

        public int MedicineID { get => medicineID; set => medicineID = value; }


        //RelationShip between Doctor
        public int PrescriptionID { get; set; }
        public Prescription Prescription { get; set; }
    }
}
