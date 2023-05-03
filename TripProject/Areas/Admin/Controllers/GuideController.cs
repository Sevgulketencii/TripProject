using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntitiyLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.List();
            return View(values);
        }

        [HttpGet]
        public IActionResult GuideAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuideAdd(Guide p)
        {
            GuideValidator validator = new GuideValidator();
            ValidationResult result = validator.Validate(p);
            if (result.IsValid)
            {
                _guideService.add(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        [HttpGet]
        public IActionResult GuideEdit(int id)
        {
            var guide = _guideService.GetByID(id);
            return View(guide);
        }

        [HttpPost]
        public IActionResult GuideEdit(Guide p)
        {
            _guideService.update(p);
            return RedirectToAction("Index");
        }

        public IActionResult ActiveGuide(int id)
        {
            return RedirectToAction("Index");
        }

        public IActionResult PassiveGuide(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
