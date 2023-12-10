using Microsoft.AspNetCore.Mvc;

namespace BarilTrip.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }

    }
}
