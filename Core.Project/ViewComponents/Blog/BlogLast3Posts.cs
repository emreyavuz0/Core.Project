using Core.BusinessLayer.Concrete;
using Core.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.ViewComponents.Blog
{
    public class BlogLast3Posts:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        
        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast3Blog();
            return View(values);
        }
    }
}
