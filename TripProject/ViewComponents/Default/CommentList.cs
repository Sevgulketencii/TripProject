using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.ViewComponents.Default
{
    public class CommentList : ViewComponent
    {
        CommentManager comment=new CommentManager(new EfCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            var list = comment.GetFilterList(id);
            return View(list);
        }
    }
}
