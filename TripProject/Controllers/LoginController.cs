using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripProject.Models;

namespace TripProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel p)
        {

            AppUser newUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                UserName = p.UserName,

            };
            if (ModelState.IsValid)
            {
                var result = await _userManager.CreateAsync(newUser, p.Password);
                return RedirectToAction("SignIn");
            }


            return View(p);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Destination",new { area="Member"});
                }
                
            }
            return View(p);
        }
    }
}
