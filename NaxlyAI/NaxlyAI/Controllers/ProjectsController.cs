﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Project_Details()
        {
            return View();
        }
    }
}
