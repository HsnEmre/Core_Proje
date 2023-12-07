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
    public class ExperienceManager:IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience item)
        {
            _experienceDal.Insert(item);
        }

        public void TDelete(Experience item)
        {
            
            _experienceDal.Delete(item);
        }

        public List<Experience> TGetAll()
        {
            return _experienceDal.GetList();
        }

        public Experience TGetByID(int id)
        {
           return _experienceDal.GetByID(id);
        }

        public void TUpdate(Experience item)
        {
            _experienceDal.Update(item);
        }
    }
}
