using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.MemberDashBoard
{
    public class PlatformSettings : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
