using Microsoft.AspNetCore.Mvc;

namespace BarilTrip.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
