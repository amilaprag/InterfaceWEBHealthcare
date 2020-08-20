using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceWEBHealthcare.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection FormData)
        {
            var userType = FormData["exampleFormControlSelect"];
            if (userType == "Patient")
            {
                return RedirectToAction("Index", "Home");
            }
            else if (userType == "Doctor")
            {
                return RedirectToAction("Index", "Doctor");
            }
            else if (userType == "Admin")
            {
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }
    }
}
