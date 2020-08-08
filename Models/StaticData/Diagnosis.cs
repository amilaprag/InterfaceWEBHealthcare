using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EHealthCareAPI.Models.StaticData
{
    public class Diagnosis
    {

        private int diagnosisID;

        private string diagnosisName;

        public int DiagnosisID { get => diagnosisID; set => diagnosisID = value; }

        public string DiagnosisName { get => diagnosisName; set => diagnosisName = value; }

        private string traceId;
        private string authkey;
        [NotMapped]
        public string TraceId { get => traceId; set => traceId = value; }
        [NotMapped]
        public string Authkey { get => authkey; set => authkey = value; }
       
    }
}
