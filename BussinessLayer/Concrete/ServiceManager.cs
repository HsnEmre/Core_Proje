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
    public class ServiceManager:IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service item)
        {
           _serviceDal.Insert(item);
        }

        public void TDelete(Service item)
        {
            _serviceDal.Delete(item);
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetList();
        }

        public Service TGetByID(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public void TUpdate(Service item)
        {
            _serviceDal.Update(item);
        }
    }
}
