using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
