using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.Default
{
    public class CommentAdd : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
