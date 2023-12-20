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
            _IMessageDal.Delete(item);
        }

        public List<Message> TGetAll()
        {
            return _IMessageDal.GetList();
        }

        public Message TGetByID(int id)
        {
            return _IMessageDal.GetByID(id);
        }

        public void TUpdate(Message item)
        {
            _IMessageDal.Update(item);
        }
    }
}
