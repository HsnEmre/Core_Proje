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
            throw new NotImplementedException();
        }

        public void TDelete(Service item)
        {
            throw new NotImplementedException();
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetList();
        }

        public Service TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service item)
        {
            throw new NotImplementedException();
        }
    }
}
