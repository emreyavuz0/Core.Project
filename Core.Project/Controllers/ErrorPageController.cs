using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
