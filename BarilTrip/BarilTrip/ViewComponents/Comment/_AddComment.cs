using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BarilTrip.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
          public IViewComponentResult Invoke()
        {  
            return View(); 
        }
    }
}
