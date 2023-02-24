using Core.BusinessLayer.Concrete;
using Core.DataAccessLayer.EntityFramework;
using Core.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p) 
        {
            p.WriterStatus = true;
            p.WriterAbout = "Deneme Test";
            wm.WriterAdd(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
