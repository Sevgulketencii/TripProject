using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.AdminDashBoard
{
    public class CardStatistic1 : ViewComponent
    {
        Context connect = new Context();
       
        public IViewComponentResult Invoke()
        {
            ViewBag.tourCount = connect.DestinationDbSet.Count();
            ViewBag.userCount = connect.Users.Count();
            return View();
        }
    }
}
