using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFAboutDal:GenericRepository<About>,IAboutDal
    {
        //crud operasyonları dışında ayrı bir işlem gerçekleştirmem gerekirse ıaboutdal'ı kullanıyorum
    }
}
