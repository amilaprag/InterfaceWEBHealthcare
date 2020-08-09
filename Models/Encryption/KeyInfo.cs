using InterfaceWEBHealthcare.Models.Treatments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWEBHealthcare.Encryption
{
    public class KeyInfo
    {

        private int keyInfoId;

        private int sercueKeyId;

        private string pkey;

        private string dkey;

        public string Dkey { get => dkey; set => dkey = value; }
        public string Pkey { get => pkey; set => pkey = value; }
        public int KeyInfoId { get => keyInfoId; set => keyInfoId = value; }
        public int SercueKeyId { get => sercueKeyId; set => sercueKeyId = value; }

        //relationship Between Prescription
        public int PrescriptionID { get; set; }

        public Prescription Prescription { get; set; }
    }
}
