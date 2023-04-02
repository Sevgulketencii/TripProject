using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.Default
{
    public class Feature1 : ViewComponent
    {
        FeatureManager feature = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var list = feature.List();
            return View(list);
        }
    }
}
