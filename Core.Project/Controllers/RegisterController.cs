using Core.BusinessLayer.Concrete;
using Core.BusinessLayer.ValidationRules;
using Core.DataAccessLayer.EntityFramework;
using Core.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class RegisterController : Controller
    {
       
        CitiesManager cm = new CitiesManager(new EfCitiesRepository());
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var cty = cm.GetList();
            ViewBag.Cities = cty;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            
           
            WriterValidator vm = new WriterValidator();
            ValidationResult results = vm.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "Deneme Test";
                wm.TAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
 
      
    }
}
