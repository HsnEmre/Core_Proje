using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.DashBoard
{
    public class FeatureStatistics:ViewComponent
    {
        Context c=new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();//kaç değer var
            ViewBag.v2=c.Messasges.Where(x=>x.Status==false).Count();//message sayısı
            ViewBag.v3=c.Messasges.Where(x=>x.Status==true).Count();
            ViewBag.v4=c.Experiences.Count();
            return View();  
        }

    }
}
