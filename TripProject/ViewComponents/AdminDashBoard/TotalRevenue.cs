using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.AdminDashBoard
{
    public class TotalRevenue: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
