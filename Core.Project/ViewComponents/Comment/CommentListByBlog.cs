using Core.BusinessLayer.Concrete;
using Core.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Core.EntityLayer.Concrete;
namespace Core.Project.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        
        public IViewComponentResult Invoke(int id)
        { 
            
            var values = cm.GetList(id);
            ViewBag.CommentCount = values.Count;
            return View(values);
        }
    }
}
