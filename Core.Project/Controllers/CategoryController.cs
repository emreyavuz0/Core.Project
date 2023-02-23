using Core.BusinessLayer.Concrete;
using Core.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
