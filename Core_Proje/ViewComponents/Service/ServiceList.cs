using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager servicemanager=new ServiceManager(new EFServiceDal());
            

        public IViewComponentResult Invoke()
        {
            var values = servicemanager.TGetAll();

            return View(values);
        }
    }
}
