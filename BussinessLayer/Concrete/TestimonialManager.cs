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
    public class TestimonialManager : ITestimonialservice
    {
        ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonial)
        {
            _testimonialDal = testimonial;
        }

        public void TAdd(Testimonial item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial item)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetAll()
        {
            return _testimonialDal.GetList();
        }

        public Testimonial TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial item)
        {
            throw new NotImplementedException();
        }
    }
}
