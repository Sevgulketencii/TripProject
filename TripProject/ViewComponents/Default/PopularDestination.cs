﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.Default
{
    public class PopularDestination: ViewComponent
    {
        DestinationManager destination = new DestinationManager(new EfDestinationDal());

        public IViewComponentResult Invoke()
        {
            var list = destination.List();
            return View(list);
        }
    }
}
