using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _IcontactDal;
        public ContactManager(IContactDal ıcontactDal)
        {
            _IcontactDal = ıcontactDal;
        }

        public void TAdd(Contact item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact item)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetAll()
        {
            return _IcontactDal.GetList();
        }

        public Contact TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact item)
        {
            throw new NotImplementedException();
        }
    }
}
