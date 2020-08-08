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


namespace InterfaceWEBHealthcare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

                var postTask = client.PostAsJsonAsync<PatientMasterData>("Patient/ValidatePatientRS", PatientMasterDataObj);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsAsync<PatientResponse>();
                    response.Wait();

                    ViewBag.Message  = response.Result;
                    return View();
                }
            }
            return View();
        }
        
        public IActionResult Appoinment()
        {
            return View();
        }
        public IActionResult Hospitals()
        {
            return View();
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
