using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination p)
        {
            destination.add(p);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteDestination(int id)
        {
            var value=destination.GetByID(id);
            destination.delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = destination.GetByID(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination p)
        {
            destination.update(p);
            return RedirectToAction("Index");
        }

    }
}
