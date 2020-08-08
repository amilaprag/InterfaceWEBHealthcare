using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealthCareAPI.Models.StaticData
{
    public class StaticDataResponse
    {
        private string operation;

        private string status;

        private string statusMessage;

        public string Operation { get => operation; set => operation = value; }
        public string Status { get => status; set => status = value; }
        public string StatusMessage { get => statusMessage; set => statusMessage = value; }
    }
}
