using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyAspTestWork.Controllers
{
    
        [Authorize]
        [Route("[controller]/[action]")]
        public class ProtectedController : Controller
        {
            // GET: /<controller>/
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }
        }
    
}