using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.ViewComponents.AdminDashboard
{
    public class _AdminGuideList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
