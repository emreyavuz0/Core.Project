using Core.BusinessLayer.Concrete;
using Core.BusinessLayer.ValidationRules;
using Core.DataAccessLayer.EntityFramework;
using Core.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact p)
		{
			ContactValidator cv = new ContactValidator();
			ValidationResult vr = cv.Validate(p);
			if (vr.IsValid)
			{
				p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				p.ContactStatus = true;
				cm.ContactAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in vr.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
