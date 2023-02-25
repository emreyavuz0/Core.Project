using Core.BusinessLayer.Concrete;
using Core.DataAccessLayer.EntityFramework;
using Core.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core.Project.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManager nm = new NewsletterManager(new EfNewsletterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }  
        [HttpPost]
        public PartialViewResult SubscribeMail(Newsletter p)
        {
           
            p.MailStatus = true;
            nm.AddNewsLetter(p);
            return PartialView();
        }
    }
}
