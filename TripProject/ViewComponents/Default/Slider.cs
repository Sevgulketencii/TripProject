using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.Default
{
    public class Slider : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
