using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.Default
{
    public class Statistic : ViewComponent
    {
        Context baglan = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.rotaCount = baglan.DestinationDbSet.Count();
            ViewBag.guideCount = baglan.GuideDbSet.Count();
            ViewBag.testCount = "285";

            return View();
        }
    }
}
