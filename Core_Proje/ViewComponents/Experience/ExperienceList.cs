using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experianceManager = new ExperienceManager(new EFExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = experianceManager.TGetAll();

            return View(values);
        }
    }
}
