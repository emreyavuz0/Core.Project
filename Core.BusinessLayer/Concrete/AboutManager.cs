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
	public class AboutManager : IAboutService
	{
		IAboutDAL _aboutDAL;

		public AboutManager(IAboutDAL aboutDAL)
		{
			_aboutDAL = aboutDAL;
		}

		public List<About> GetList()
		{
			return _aboutDAL.GetListAll();
		}
	}
}
