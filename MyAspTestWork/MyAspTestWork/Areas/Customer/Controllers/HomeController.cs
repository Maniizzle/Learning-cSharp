using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyAspTestWork.Areas.Admin.Models;

namespace MyAspTestWork.Areas.Customer.Controllers
{   
    [Area("Customer")]
    [Authorize]
    public class HomeController : Controller
    {
        private Person[] people = new Person[]
                               {
                                    new Person { Name = "Paul", City = "Mumbai" },
                                    new Person {Name= "Taiwo", City= "Toronto" }
                               };
        public IActionResult Index()
        {
            return View(people);
        }
       
    }
}