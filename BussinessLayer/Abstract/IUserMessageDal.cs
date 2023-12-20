using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IUserMessageDal:IGenericDal<UserMessage>
    {
        public List<UserMessage> GetUserMessagesWithUser();
    }
}
