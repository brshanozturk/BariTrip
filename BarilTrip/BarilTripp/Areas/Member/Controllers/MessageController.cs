﻿using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
