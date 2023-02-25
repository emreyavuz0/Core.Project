using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLayer.Concrete
{
    public class NewsletterManager:INewsletterService
    {
        INewsletterDAL _newsDAL;

        public NewsletterManager(INewsletterDAL newsDAL)
        {
            _newsDAL = newsDAL;
        }

        public void AddNewsLetter(Newsletter newsletter)
        {
            _newsDAL.Insert(newsletter);
        }
    }
}
