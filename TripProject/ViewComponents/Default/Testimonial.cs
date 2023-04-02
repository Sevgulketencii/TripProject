using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.Default
{
    public class Testimonial : ViewComponent
    {

        TestimonialManager testimonial = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var list = testimonial.List();
            return View(list);
        }
    }
}
