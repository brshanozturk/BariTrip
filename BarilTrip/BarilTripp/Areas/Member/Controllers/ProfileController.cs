using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
