using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;


namespace InterfaceWEBHealthcare.Models.StaticData
{
   // [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Hospital
    {
        //Not Mapping details
        private double distance;
        private string traceId;
        private string authkey;

        private int    hospitalID;
        private string hospitalName;
        private string hospitalImage;
        private string email;
        private string hospitalAddress;
        private string telephoneNumber;
        private double longitude;
        private double latitude;
        private int positiveFeedbacks;
        private int negativeFeedbacks;
       
        public int HospitalID { get => hospitalID; set => hospitalID = value; }
        public string HospitalName { get => hospitalName; set => hospitalName = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public int PositiveFeedbacks { get => positiveFeedbacks; set => positiveFeedbacks = value; }
        public int NegativeFeedbacks { get => negativeFeedbacks; set => negativeFeedbacks = value; }
        public string HospitalAddress { get => hospitalAddress; set => hospitalAddress = value; }
        public string TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }
        public string Email { get => email; set => email = value; }

        [NotMapped]
        public double Distance { get => distance; set => distance = value; }
        [NotMapped]
        public string TraceId { get => traceId; set => traceId = value; }
        [NotMapped]
        public string Authkey { get => authkey; set => authkey = value; }
        public string HospitalImage { get => hospitalImage; set => hospitalImage = value; }
    }
}
