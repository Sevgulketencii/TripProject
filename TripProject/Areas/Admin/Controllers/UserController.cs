using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {

        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.List();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var delete = _appUserService.GetByID(id);
            _appUserService.delete(delete);
            return RedirectToAction("Index");
        }

        public IActionResult UserReservation(int id)
        {
            var values = _reservationService.GetListActiveReservations(id);
            return View(values);
        }
    }
}
