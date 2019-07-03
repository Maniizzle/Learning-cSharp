using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MyAspTestWork.Models;

namespace MyAspTestWork.Controllers
{
     [Route("[controller]/[action]")] 
    public class AuthController : Controller
    {
        private readonly static string username = "olamide";
        private readonly static string password = "olamide";
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        { TempData["Failed"] = null;
            if (!ModelState.IsValid)
            {
                TempData["Failed"] = "Failed";
                model.Password = "";
                return View(model);
            }
            if (!username.Equals(model.Username,StringComparison.InvariantCultureIgnoreCase) || !password.Equals(model.Password))
            {
                ModelState.AddModelError("Error", "Invalid Username or Password");
                TempData["Failed"] = "Failed";
                model.Password = "";
                return View(model);
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, model.Username),
                new Claim("Fullname", model.Username),
                new Claim(ClaimTypes.Role, model.Username),
            };
            var clainsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(clainsIdentity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                principal, new AuthenticationProperties
                {
                    IsPersistent = true
                });
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