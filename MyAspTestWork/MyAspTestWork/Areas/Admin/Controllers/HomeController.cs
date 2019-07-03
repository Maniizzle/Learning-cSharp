using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyAspTestWork.Areas.Admin.Models;

namespace MyAspTestWork.Areas.Admin.Controllers
{   //area attribute must be applied to the class
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}