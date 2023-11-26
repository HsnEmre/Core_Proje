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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature item)
        {
            _featureDal.Insert(item);
        }

        public void TDelete(Feature item)
        {
            _featureDal.Delete(item);
        }

        public List<Feature> TGetAll()
        {
           return _featureDal.GetList();
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public void TUpdate(Feature item)
        {
            _featureDal.Update(item);
        }

    }
}
