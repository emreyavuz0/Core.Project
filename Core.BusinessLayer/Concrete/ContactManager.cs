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
	public class ContactManager : IContactService
	{
		IContactDAL _contactDAL;

		public ContactManager(IContactDAL contactDAL)
		{
			_contactDAL = contactDAL;
		}

		public void ContactAdd(Contact contact)
		{
			_contactDAL.Insert(contact);
		}
	}
}
