using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.DashBoard
{
    public class LastFiveProjects : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
