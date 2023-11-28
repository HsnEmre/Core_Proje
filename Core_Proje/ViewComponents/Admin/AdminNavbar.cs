using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Admin
{
    public class AdminNavbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}
