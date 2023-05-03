using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var list = _commentService.TGetCommentWithDestination();
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            var comment = _commentService.GetByID(id);
            _commentService.delete(comment);
            return RedirectToAction("Index");
        }
    }
}
