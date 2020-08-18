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
        public IActionResult Index(IFormCollection FormData)
        {
            var userType = FormData[""];
            if (userType=="patient")
            {
                return RedirectToAction();
            }
            else if (userType == "doctor")
            {
                return RedirectToAction();
            }
            else if (userType == "Admin")
            {
                return RedirectToAction();
            }
            return View();
        }
    }
}
