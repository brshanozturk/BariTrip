using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.ViewComponents.MemberDashboard
{
    public class _MemberStatistic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
