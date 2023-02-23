using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
