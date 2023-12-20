using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class UserMessageManager:IUserMessageService
    {
        IUserMessageDal _userMessageDal;
        private DataAccessLayer.EntityFramework.EFUSerMessagDal eFUserMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public UserMessageManager(DataAccessLayer.EntityFramework.EFUSerMessagDal eFUserMessageDal)
        {
            this.eFUserMessageDal = eFUserMessageDal;
        }

        public void TAdd(UserMessage item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage item)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetAll()
        {
            return _userMessageDal.GetList();
        }

        public UserMessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserMessage item)
        {
            throw new NotImplementedException();
        }
    }
}
