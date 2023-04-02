using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.Default
{
    public class Feature2 : ViewComponent
    {

        Feature2Manager feature2 = new Feature2Manager(new EfFeature2Dal());
        
        public IViewComponentResult Invoke()
        {
            var list = feature2.List();
            return View(list);
        }
    }
}
