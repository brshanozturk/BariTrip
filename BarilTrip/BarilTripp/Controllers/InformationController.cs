﻿using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
