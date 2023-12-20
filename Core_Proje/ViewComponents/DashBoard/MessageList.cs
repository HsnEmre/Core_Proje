using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.DashBoard
{
    public class MessageList:ViewComponent
    {

       UserMessageManager messageManager=new UserMessageManager(new EFUSerMessagDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.TGetAll();
            return View(values);

        }
    }
}
