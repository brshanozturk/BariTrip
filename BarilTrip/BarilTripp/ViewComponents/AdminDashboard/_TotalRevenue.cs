﻿using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.ViewComponents.AdminDashboard
{
    public class _TotalRevenue : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
