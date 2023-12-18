using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
