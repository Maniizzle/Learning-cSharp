using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAspTestWork.Models;

namespace MyAspTestWork.Controllers
{
     [Route("[controller]/[action]")] 
    public class AuthController : Controller
    {
        private readonly static string Username = "olamide";
        private readonly static string password = "olamide";
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        { TempData["Failed"] = null;
            if (!ModelState.IsValid)
            {
                TempData["Failed"] = "Failed";
                model.Password = "";
                return View(model);
            }
            if (!(Username.Equals(model.Username,StringComparison.InvariantCultureIgnoreCase) || password.Equals(model.Password)))
            {
                ModelState.AddModelError("Error", "Invalid Username or Password");
                TempData["Failed"] = "Failed";
                model.Password = "";
                return View(model);
            }
            return RedirectToAction("Index", "Home", new { area = "Customer" });
        }


        // GET: /<controller>/
        [HttpGet]
        public IActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }

    }
}