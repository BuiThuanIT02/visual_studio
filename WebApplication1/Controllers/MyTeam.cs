﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class MyTeam : Controller
    {
        public IActionResult Index()
        {
            Console.Write("Helllo world");
            return View();
        }
    }
}
