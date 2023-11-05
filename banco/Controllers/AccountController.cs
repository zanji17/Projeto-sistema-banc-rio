using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace banco.Controllers
{
    public class AccountController : Controller
    {
        [Route("Account")]
        [Route("Account/Index")]

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Account(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}