using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var announcementList = _announcementService.List();
            //List<AnnouncementListDTOs> model = new List<AnnouncementListDTOs>();
            //foreach (var item in announcementList)
            //{
            //    AnnouncementListDTOs newModel = new AnnouncementListDTOs();
            //    newModel.AnnouncementID = item.AnnouncementID;
            //    newModel.Content = item.Content;
            //    newModel.Title = item.Title;

            //    model.Add(newModel);
            //} Bunun yerine AutoMapper kullanılır

            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.List());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO p)
        {
            if (ModelState.IsValid)
            {
                _announcementService.add(new Announcement()
                {
                    Content = p.Content,
                    Title = p.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.GetByID(id);
            _announcementService.delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDTO>(_announcementService.GetByID(id));

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDTO p)
        {
            if (ModelState.IsValid)
            {
                _announcementService.update(new Announcement()
                {
                    AnnouncementID = p.AnnouncementID,
                    Content = p.Content,
                    Title = p.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}
