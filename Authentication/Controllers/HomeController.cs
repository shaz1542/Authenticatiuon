﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Authentication.Models;
using Microsoft.AspNetCore.Authorization;

namespace Authentication.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "ContactManagers")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "ContactAdministrators")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
