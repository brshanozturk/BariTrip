using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BarilTripp.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
       

    }
}
