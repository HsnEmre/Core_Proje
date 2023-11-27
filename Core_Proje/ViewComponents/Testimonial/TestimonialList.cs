using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager manager = new TestimonialManager(new EFTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = manager.TGetAll();
            return View(values);    
        }
    }
}
