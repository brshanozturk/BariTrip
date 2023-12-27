using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.ViewComponents.MemberLayout
{
    public class _MemberLayoutSearch : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
