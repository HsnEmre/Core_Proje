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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio item)
        {
            _portfolioDal.Insert(item);
        }

        public void TDelete(Portfolio item)
        {
         _portfolioDal.Delete(item);  
        }

        public List<Portfolio> TGetAll()
        {
            return _portfolioDal.GetList();
        }

        public Portfolio TGetByID(int id)
        {
           return _portfolioDal.GetByID(id);
        }

        public void TUpdate(Portfolio item)
        {
           _portfolioDal.Update(item);
        }
    }
}
