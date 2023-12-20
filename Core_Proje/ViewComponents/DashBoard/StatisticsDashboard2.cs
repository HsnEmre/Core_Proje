using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.DashBoard
{
    public class StatisticsDashboard2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {

            ViewBag.v1 = c.Portfolios.Count();
            ViewBag.v2 = c.Services.Count();
            ViewBag.v3 = c.Messasges.Count();

            return View();
        }

    }
}
