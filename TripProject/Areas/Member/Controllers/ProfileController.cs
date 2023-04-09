using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TripProject.Areas.Member.Models;

namespace TripProject.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditModel p = new UserEditModel()
            {
                name = user.Name,
                surname = user.Surname,
                phone = user.PhoneNumber,
                gender = user.Gender,
                imageurl = user.Image,
                mail = user.Email,
                password = user.PasswordHash
            };
            return View(p);
        }


        [HttpPost]
        public async Task<IActionResult> Index(UserEditModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UsersProfile/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);

                await p.image.CopyToAsync(stream);
                user.Image = imagename;

            }
            user.Name = p.name;
            user.Surname = p.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            user.PhoneNumber = p.phone;
            user.Gender = p.gender;
            user.Email = p.mail;
            
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Destination");
            }

            return View(p);
        }
    }
}
