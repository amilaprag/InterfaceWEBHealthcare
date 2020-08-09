using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWEBHealthcare.Models.Appoinment
{
    public class AppoinmentResponse
    {

    }

    public class AppoinmentSucessResponse
    {
        private string status;

        private string statusMessage;

        public string Status { get => status; set => status = value; }
        public string StatusMessage { get => statusMessage; set => statusMessage = value; }
    }
}
