using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {

        ContactManager contactManager=new ContactManager(new EFContactDal());

        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetAll();

            return View(values);
        }

    }
}
