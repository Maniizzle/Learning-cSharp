using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAspTestWork.Areas.Admin.Models;

namespace MyAspTestWork.Areas.Admin.Controllers
{   //area attribute must be applied to the class
    [Area("Admin")]
    public class HomeController : Controller
    {
        private Person[] people = new Person[]
                                {
                                    new Person { Name = "Paul", City = "Lobo" },
                                    new Person {Name= "Taiwo", City= "Loco" }
                                };
        public IActionResult Index()
        {
            return View(people);
        }
    }
}