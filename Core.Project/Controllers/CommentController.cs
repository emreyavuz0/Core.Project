﻿using Core.BusinessLayer.Concrete;
using Core.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id) 
        {
            
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}