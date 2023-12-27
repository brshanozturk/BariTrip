using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguages : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
