﻿using Microsoft.AspNetCore.Mvc;

namespace AuthServer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
