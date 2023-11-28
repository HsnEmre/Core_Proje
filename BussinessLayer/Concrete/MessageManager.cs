using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class MessageManager:IMessageServices
    {
        IMessageDal _IMessageDal;

        public MessageManager(IMessageDal ıMessageDal)
        {
            _IMessageDal = ıMessageDal;
        }

        public void TAdd(Message item)
        {
           _IMessageDal.Insert(item);
        }

        public void TDelete(Message item)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Message TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message item)
        {
            throw new NotImplementedException();
        }
    }
}
