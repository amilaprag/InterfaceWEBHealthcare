using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InterfaceWEBHealthcare.Models;
using System.Net.Http;
using InterfaceWEBHealthcare.Models.StaticData;
using InterfaceWEBHealthcare.Models.Doctors;
using InterfaceWEBHealthcare.Models.Appoinment;
using InterfaceWEBHealthcare.Models.Treatments;

namespace InterfaceWEBHealthcare.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public DoctorController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public DoctorResponseData DoctorResponseDetails()
        {
            using (var client = new HttpClient())
            {
                DoctorResponseData DoctorDetailsReturnObj = new DoctorResponseData();
                DoctorResponse DoctorDetailsobj = new DoctorResponse();

                client.BaseAddress = new Uri("https://localhost:5001/EHealthCareAPI/");

                Doctor DoctorObj = new Doctor();
                DoctorObj.Authkey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5ODEyMDIxNiwiZXhwIjoxNjAyOTIwMjE2LCJpYXQiOjE1OTgxMjAyMTYsImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.3AhOM-XP1oSMdODPGX6sjMHqdUFeexOqQInRu1l9a-o";
                DoctorObj.Username = "Doctor2@gmail.com";
                DoctorObj.Password = "123@#";
                DoctorObj.TraceId = "123456";

                var postTask = client.PostAsJsonAsync<Doctor>("Doctor/ValidateDoctortRS", DoctorObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsAsync<DoctorResponse>();
                    response.Wait();

                    DoctorDetailsobj = response.Result;
                }
                DoctorDetailsReturnObj= DoctorDetailsobj.DoctorDetails.DoctorResponseData;
                return DoctorDetailsReturnObj;
            }
        }

        public IActionResult Index()
        {
            List<Appoinments> AppoinmentsList = null;
            using (var client = new HttpClient())
            {
                string TraaceId = "1123";
                int DoctorID = 1013;
                string AuthKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5Njk4MzEwOCwiZXhwIjoxNjAxNzgzMTA4LCJpYXQiOjE1OTY5ODMxMDgsImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.9DwOuSeERmBuKNRzm-Tyu51I3UjlG2GZFAPleLdkr5U";

                client.BaseAddress = new Uri("https://localhost:5001/EHealthCareAPI/Doctor/MyAppoinment/");
                //HTTP GET
                var responseTask = client.GetAsync(TraaceId + "/" + DoctorID + "/" + AuthKey);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Appoinments>>();
                    readTask.Wait();

                    AppoinmentsList = readTask.Result;
                }
            }
            ViewBag.Message = DoctorResponseDetails();
            return View(AppoinmentsList);
        }
        
        public IActionResult Appoinment()
        {
            return View();
        }
        public IActionResult Hospitals()
        {
            using (var client = new HttpClient())
            {
                List<Hospital> HospitalList = null;

                string TraaceId = "455";
                double Latitude = 455555.2;
                double Longitude = 455555.2;
                string AuthKey= "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5Njg4NDgxNCwiZXhwIjoxNjAxNjg0ODE0LCJpYXQiOjE1OTY4ODQ4MTQsImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.VtV9yxsVvGhOyfB55L0H3R0yvifVJOe-D28bpT_KpqM";
                
                client.BaseAddress = new Uri("https://localhost:5001/");
                //HTTP GET
                var responseTask = client.GetAsync("EHealthCareAPI/Patient/" + TraaceId + "/"+ Latitude +"/"+ Longitude+"/"+ AuthKey);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Hospital>>();
                    readTask.Wait();

                    HospitalList = readTask.Result;
                }
            }
            return View();
        }

        public IActionResult Doctors()
        {
            using (var client = new HttpClient())
            {
                List<DoctorData> DoctorDataList = null;

                string TraaceId = "1123";
                int DoctorID = 1002;
                string AuthKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5Njg4NDgxNCwiZXhwIjoxNjAxNjg0ODE0LCJpYXQiOjE1OTY4ODQ4MTQsImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.VtV9yxsVvGhOyfB55L0H3R0yvifVJOe-D28bpT_KpqM";

                client.BaseAddress = new Uri("https://localhost:5001/EHealthCareAPI/Doctor/");
                //HTTP GET
                var responseTask = client.GetAsync(TraaceId + "/" + DoctorID + "/" + AuthKey);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<DoctorData>>();
                    readTask.Wait();

                    DoctorDataList = readTask.Result;
                }
            }
            return View();
        }

        public IActionResult MyAppoinmets()
        {
            using (var client = new HttpClient())
            {
                List<Appoinments> AppoinmentsList = null;

                string TraaceId = "1123";
                int PatientMasterID = 3001;
                string AuthKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5Njk4MzEwOCwiZXhwIjoxNjAxNzgzMTA4LCJpYXQiOjE1OTY5ODMxMDgsImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.9DwOuSeERmBuKNRzm-Tyu51I3UjlG2GZFAPleLdkr5U";

                client.BaseAddress = new Uri("https://localhost:5001/EHealthCareAPI/Appoinment/");
                //HTTP GET
                var responseTask = client.GetAsync(TraaceId + "/" + PatientMasterID + "/" + AuthKey);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Appoinments>>();
                    readTask.Wait();

                    AppoinmentsList = readTask.Result;
                }
            }
            return View();
        }

        public IActionResult Prescriptions()
        {
            List<Prescription> PrescriptionsList = null;
            using (var client = new HttpClient())
            {
                string TraaceId = "1123";
                int PatientMasterID = 3001;
                string AuthKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5MTY0NDUzOSwiZXhwIjoxNTk2NDQ0NTM5LCJpYXQiOjE1OTE2NDQ1MzksImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.kuxSi6EkCIH50fO9C6o2-KHWvZ3G6C_1nrcCSV-FRic";

                client.BaseAddress = new Uri("https://localhost:5001/EHealthCareAPI/Treatments/");
             
                var responseTask = client.GetAsync("treatMenthistory/" + PatientMasterID + "/" + TraaceId + "/" + AuthKey);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Prescription>>();
                    readTask.Wait();

                    PrescriptionsList = readTask.Result;
                }
            }

            //Prescription PrescriptionObj= new Prescription();
            //List<Medicine> MedicineObj = new List<Medicine>();

            //PrescriptionObj.Medicine = MedicineObj;
            //ViewBag.Medicine = PrescriptionObj;
            ViewBag.Message = DoctorResponseDetails();
            return View(PrescriptionsList);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
