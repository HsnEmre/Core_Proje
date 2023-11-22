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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)//Kurucu
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About item)
        {
           _aboutDal.Insert(item);
        }

        public void TDelete(About item)
        {
            _aboutDal.Delete(item);
        }

        public List<About> TGetAll()
        {
            return _aboutDal.GetList();
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public void TUpdate(About item)
        {
            _aboutDal.Update(item);
        }
    }
}
