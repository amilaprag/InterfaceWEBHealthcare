using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InterfaceWEBHealthcare.Models;
using System.Net.Http;
using InterfaceWEBHealthcare.Models.Patient;
using InterfaceWEBHealthcare.Models.StaticData;
using InterfaceWEBHealthcare.Models.Doctors;
using InterfaceWEBHealthcare.Models.Appoinment;
using InterfaceWEBHealthcare.Models.Treatments;

namespace InterfaceWEBHealthcare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static string UserNm ;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public PatientResponse PatientResponseDetails()
        {
            using (var client = new HttpClient())
            {
                PatientResponse PatientResponseReturnObj = new PatientResponse();
                client.BaseAddress = new Uri("https://localhost:5001/EHealthCareAPI/");

                PatientMasterData PatientMasterDataObj = new PatientMasterData();
                PatientMasterDataObj.Authkey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5Njg4NDgxNCwiZXhwIjoxNjAxNjg0ODE0LCJpYXQiOjE1OTY4ODQ4MTQsImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.VtV9yxsVvGhOyfB55L0H3R0yvifVJOe-D28bpT_KpqM";
                PatientMasterDataObj.Username = "prageeth1@gmail.com";
                PatientMasterDataObj.Password = "123abcd";
                PatientMasterDataObj.TraceId = "123456";
                UserNm = PatientMasterDataObj.Username;

                var postTask = client.PostAsJsonAsync<PatientMasterData>("Patient/ValidatePatientRS", PatientMasterDataObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsAsync<PatientResponse>();
                    response.Wait();

                    PatientResponseReturnObj = response.Result;
                    return PatientResponseReturnObj;
                }
                return PatientResponseReturnObj;
            }
        }

        public IActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5001/EHealthCareAPI/");

                PatientMasterData PatientMasterDataObj = new PatientMasterData();
                PatientMasterDataObj.Authkey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5Njg4NDgxNCwiZXhwIjoxNjAxNjg0ODE0LCJpYXQiOjE1OTY4ODQ4MTQsImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.VtV9yxsVvGhOyfB55L0H3R0yvifVJOe-D28bpT_KpqM";
                PatientMasterDataObj.Username = "prageeth1@gmail.com";
                PatientMasterDataObj.Password = "123abcd";
                PatientMasterDataObj.TraceId = "123456";
                UserNm = PatientMasterDataObj.Username;

                var postTask = client.PostAsJsonAsync<PatientMasterData>("Patient/ValidatePatientRS", PatientMasterDataObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsAsync<PatientResponse>();
                    response.Wait();

                    ViewBag.Message  = response.Result;
                    ViewBag.Feedback = "Ok";
                    return View();
                }
            }
      
            return View();
        }

        public IActionResult PostAppoinment()
        {
            using (var client = new HttpClient())
            {
                AppoinmentSucessResponse AppoinmentSucessResponse = new AppoinmentSucessResponse();
                Appoinments AppoinmentObj = new Appoinments();
                Doctor DoctorObj = new Doctor();
                Hospital HospitalObj = new Hospital();
                PatientMasterData PatientMasterDataObj = new PatientMasterData();

                PatientMasterDataObj.PatientMasterDataID = 3002;
                HospitalObj.HospitalID = 1002;
                DoctorObj.DoctorID = 1009;

                AppoinmentObj.TraceId = "455";
                AppoinmentObj.TimeSlot = "evening";
                AppoinmentObj.Doctor = DoctorObj;
                AppoinmentObj.ProblemBrief = "";
                AppoinmentObj.AppoinmentDate = Convert.ToDateTime("2020-11-05");
                AppoinmentObj.Age = "29";
                AppoinmentObj.Hospital = HospitalObj;
                AppoinmentObj.Patient = PatientMasterDataObj;
                AppoinmentObj.Authkey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5Njg4NDgxNCwiZXhwIjoxNjAxNjg0ODE0LCJpYXQiOjE1OTY4ODQ4MTQsImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.VtV9yxsVvGhOyfB55L0H3R0yvifVJOe-D28bpT_KpqM";

                client.BaseAddress = new Uri("https://localhost:5001/EHealthCareAPI/");
                //HTTP GET
                var postTask = client.PostAsJsonAsync<Appoinments>("Appoinment", AppoinmentObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<AppoinmentSucessResponse>();
                    readTask.Wait();
                    AppoinmentSucessResponse = readTask.Result;
                }
            }
            ViewBag.Message = PatientResponseDetails();
            return View();
        }
        public IActionResult Appoinment()
        {
            ViewBag.Message = PatientResponseDetails();
            return View();
        }
        public IActionResult Hospitals()
        {
            List<Hospital> HospitalList = null;
            using (var client = new HttpClient())
            {
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
            ViewBag.Message = PatientResponseDetails();
            return View(HospitalList);
        }

        public IActionResult Doctors()
        {
            List<DoctorData> DoctorDataList = null;
            using (var client = new HttpClient())
            {
             
                string i = UserNm;
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
            ViewBag.Message = PatientResponseDetails();
            return View(DoctorDataList);
        }

        public IActionResult MyAppoinments()
        {
            List<Appoinments> AppoinmentsList = null;
            using (var client = new HttpClient())
            {
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
            ViewBag.Message = PatientResponseDetails();
            return View(AppoinmentsList);
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
                //HTTP GET
                var responseTask = client.GetAsync("treatMenthistory/"+PatientMasterID + "/" + TraaceId + "/" + AuthKey);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Prescription>>();
                    readTask.Wait();

                    PrescriptionsList = readTask.Result;
                }
            }
            ViewBag.Message = PatientResponseDetails();
            return View(PrescriptionsList);
        }

        public IActionResult MedicineList(int GetPrescriptionID)
        {
            List<Medicine> MedicineList = new List<Medicine>();
            PrescriptionResponse PrescriptionsObj = new PrescriptionResponse();

            using (var client = new HttpClient())
            {
                string TraaceId = "1123";
                int PrescriptionID = GetPrescriptionID;
                PrescriptionID = 50012;
                string AuthKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFtaWxhcHJhZ2VldGhAZ21haWwuY29tIiwibmFtZWlkIjoiYW1pbGFwcmFnZWV0aEBnbWFpbC5jb20iLCJyb2xlIjoicGF0aWVudCIsIm5iZiI6MTU5MTY0NDUzOSwiZXhwIjoxNTk2NDQ0NTM5LCJpYXQiOjE1OTE2NDQ1MzksImlzcyI6Imh0dHA6Ly9teXNpdGUuY29tIiwiYXVkIjoiaHR0cDovL215YXVkaWVuY2UuY29tIn0.kuxSi6EkCIH50fO9C6o2-KHWvZ3G6C_1nrcCSV-FRic";

                client.BaseAddress = new Uri("https://localhost:5001/EHealthCareAPI/Treatments/");
                //HTTP GET
                var responseTask = client.GetAsync(PrescriptionID + "/" + TraaceId + "/" + AuthKey);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<PrescriptionResponse>();
                    readTask.Wait();

                    PrescriptionsObj = readTask.Result;
                      foreach (var Mitem in PrescriptionsObj.Medicine)
                        {
                            Medicine MedicineObj = new Medicine();
                            MedicineObj.Strength = Mitem.Strength;
                            MedicineObj.Form = Mitem.Form;
                            MedicineObj.Route = Mitem.Route;
                            MedicineObj.Quantity = Mitem.Quantity;
                            MedicineObj.Dosage = Mitem.Dosage;
                            MedicineObj.Frequency = Mitem.Frequency;
                            MedicineObj.StartDate = Mitem.StartDate;
                            MedicineObj.EndDate = Mitem.EndDate;
                            MedicineObj.Instructions = Mitem.Instructions;
                            MedicineObj.InstructionsNotes = Mitem.InstructionsNotes;
                            MedicineObj.Status = Mitem.Status;
                            MedicineList.Add(MedicineObj);
                      }
                }
            }
            ViewBag.Message = PatientResponseDetails();
            return View(MedicineList);
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
