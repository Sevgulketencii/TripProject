using BusinessLayer.Abstract;
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
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var list = _destinationService.List();
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
            _destinationService.add(p);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteDestination(int id)
        {
            var value= _destinationService.GetByID(id);
            _destinationService.delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.GetByID(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination p)
        {
            _destinationService.update(p);
            return RedirectToAction("Index");
        }

    }
}
