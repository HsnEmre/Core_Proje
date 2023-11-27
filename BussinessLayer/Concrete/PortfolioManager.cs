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
            throw new NotImplementedException();
        }

        public void TDelete(Portfolio item)
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> TGetAll()
        {
            return _portfolioDal.GetList();
        }

        public Portfolio TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio item)
        {
            throw new NotImplementedException();
        }
    }
}
