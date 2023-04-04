using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager comment = new CommentManager(new EfCommentDal());

        [HttpGet]
        public PartialViewResult CommentAdd()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult CommentAdd(Comment p)
        {
            p.CommentDate = DateTime.Now;
            p.CommentStatus = true;
            comment.add(p);
            return RedirectToAction("Index", "Destination");
        }
    }
}
