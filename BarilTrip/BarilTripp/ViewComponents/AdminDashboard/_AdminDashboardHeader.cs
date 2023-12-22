using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
