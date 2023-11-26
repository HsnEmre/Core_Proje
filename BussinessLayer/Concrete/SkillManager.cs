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
    public class SkillManager:ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Skill item)
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetAll()
        {
            return _skillDal.GetList();
        }

        public Skill TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill item)
        {
            throw new NotImplementedException();
        }
    }
}
