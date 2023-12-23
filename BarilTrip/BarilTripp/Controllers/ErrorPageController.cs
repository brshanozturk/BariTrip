using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
