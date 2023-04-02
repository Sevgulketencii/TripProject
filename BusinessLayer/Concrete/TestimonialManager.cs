using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonial;

        public TestimonialManager(ITestimonialDal testimonial)
        {
            _testimonial = testimonial;
        }

        public void add(Testimonial t)
        {
            _testimonial.add(t);
        }

        public void delete(Testimonial t)
        {
            _testimonial.delete(t);
        }

        public Testimonial GetByID(int id)
        {
            return _testimonial.GetByID(id);
        }

        public List<Testimonial> List()
        {
            return _testimonial.list();
        }

        public void update(Testimonial t)
        {
            _testimonial.update(t);
        }
    }
}
