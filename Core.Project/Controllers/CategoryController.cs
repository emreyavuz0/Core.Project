using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
