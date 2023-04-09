using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destination = new DestinationManager(new EfDestinationDal());
        ReservationManager reservation = new ReservationManager(new EfReservationDal());
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> OldReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = user.Id;

            var list = reservation.GetListOldReservation(user.Id);
            return View(list);
        }

        public async Task<IActionResult> ActiveReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var list = reservation.GetListActiveReservations(user.Id);
            return View(list);
        }

        public async Task<IActionResult> WaitReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var list = reservation.GetListWaitReservation(user.Id);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Reservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = user.Id;
            List<SelectListItem> value = (from x in destination.List()
                                          select new SelectListItem
                                          {
                                              Text = x.City,
                                              Value = x.DestinationID.ToString()
                                          }).ToList();
            ViewBag.dropdown = value;
            return View();
        }

        [HttpPost]
        public IActionResult Reservations(Reservation p)
        {
            p.ReservationStatus = "Onay Bekliyor";
            reservation.add(p);
            return RedirectToAction("Index", "Destination", new { area = "Member" });
        }

       
    }
}
