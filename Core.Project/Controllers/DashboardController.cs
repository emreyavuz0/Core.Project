using Core.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.v1 = c.blogs.Count().ToString();
            ViewBag.v2 = c.blogs.Where(x => x.WriterId == 1).Count();
            ViewBag.v3 = c.categories.Count();
            return View();
        }
    }
}
