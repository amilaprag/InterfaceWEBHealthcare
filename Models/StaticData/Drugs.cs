using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EHealthCareAPI.Models.StaticData
{
    public class Drugs
    {
        private int drugsID;
        private string drugsName;
        private string drugsCode;

        public int DrugsID { get => drugsID; set => drugsID = value; }
        public string DrugsName { get => drugsName; set => drugsName = value; }
        public string DrugsCode { get => drugsCode; set => drugsCode = value; }

        //Not Mapping details

        private string traceId;
        private string authkey;

        [NotMapped]
        public string TraceId { get => traceId; set => traceId = value; }
        [NotMapped]
        public string Authkey { get => authkey; set => authkey = value; }
        
    }
}
