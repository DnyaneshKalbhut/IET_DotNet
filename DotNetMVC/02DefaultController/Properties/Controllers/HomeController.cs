﻿using Microsoft.AspNetCore.Mvc;

namespace _02DefaultController.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}