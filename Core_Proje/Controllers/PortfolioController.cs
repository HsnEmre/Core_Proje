using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDal());
        public IActionResult Index()
        {
            var values = portfolioManager.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {

            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Ekleme";

            #region FluentValidation
            PortfolioValidator validator = new PortfolioValidator();//portfolio validatordan nesne türet metoda ulaş
            ValidationResult result = validator.Validate(p);//result ile kontrol et geçerliliği

            if (result.IsValid)
            {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            #endregion
            return View();
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Ekleme";

            var values = portfolioManager.TGetByID(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio port)
        {
            #region Validation
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult res = validations.Validate(port);

            if (res.IsValid)
            {
                portfolioManager.TUpdate(port);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in res.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    
                }

               
            }
            return View();
            #endregion


        }

    }
}
