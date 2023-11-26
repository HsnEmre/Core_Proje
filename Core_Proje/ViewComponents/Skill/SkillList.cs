using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BussinessLayer.Concrete;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EFSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetAll();

            return View(values);
        }

    }
}
