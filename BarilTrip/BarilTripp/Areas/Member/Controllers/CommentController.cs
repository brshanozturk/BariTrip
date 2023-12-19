using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
