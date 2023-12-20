using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.DashBoard
{
    public class ProjectList:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var val = portfolioManager.TGetAll();

            return View(val);
        }

    }
}
