using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
