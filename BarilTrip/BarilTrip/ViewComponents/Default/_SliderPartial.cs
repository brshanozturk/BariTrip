using Microsoft.AspNetCore.Mvc;

namespace BarilTrip.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 

        }
    }
}
