using Microsoft.AspNetCore.Mvc;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList: ViewComponent
    {

        FeatureManager featureManager = new FeatureManager(new EFFeatureDal());


        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetAll();
            return View(values);
        }
    }
}
