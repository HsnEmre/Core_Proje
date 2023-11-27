using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new EFPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = portfoliomanager.TGetAll();

            return View(values);
        }
    }
}
