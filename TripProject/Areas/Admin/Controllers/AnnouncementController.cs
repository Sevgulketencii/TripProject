using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
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

            var values = _mapper.Map<List<AnnouncementListDTOs>>(_announcementService.List());
            return View(values);
        }

    }
}
