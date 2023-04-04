using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destination = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var list = destination.List();
            return View(list);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            ViewBag.id = id;
            var list = destination.GetByID(id);
            return View(list);
        }
    }
}
