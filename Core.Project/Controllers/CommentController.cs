using Core.BusinessLayer.Concrete;
using Core.DataAccessLayer.EntityFramework;
using Core.EntityLayer.Concrete;
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
        
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.CommentStatus = true;
            p.CommentDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogId = 2;
            cm.CommentAdd(p);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id) 
        {
            
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
