using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.MemberDashBoard
{
    public class GuideList : ViewComponent
    {
        GuideManager guide = new GuideManager(new EfGuideDal());

        public IViewComponentResult Invoke()
        {
            var list = guide.List();
            return View(list);
        }
    }
}
