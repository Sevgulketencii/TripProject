using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var list = _contactUsService.GetStatusTrueList();
            return View(list);
        }

        public IActionResult ChangeStatus(int id)
        {
            _contactUsService.ContactUsStatusChangeFalse(id);
            return RedirectToAction("Index");
        }
    }
}
