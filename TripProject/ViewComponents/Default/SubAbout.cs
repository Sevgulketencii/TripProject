using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.Default
{
    public class SubAbout : ViewComponent
    {
        SubAboutManager subAbout = new SubAboutManager(new EfSubAboutDal());

        public IViewComponentResult Invoke()
        {
            var list = subAbout.List();
            return View(list);
        }
    }
}
