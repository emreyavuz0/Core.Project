﻿using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDAL _blogDal;

		public BlogManager(IBlogDAL blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}
		public List<Blog> GetBlogById(int id)
		{
			return _blogDal.GetListAll(x=>x.BlogId== id);
		}

		public List<Blog> GetList()
		{
			return _blogDal.GetListAll();
		}
	}
}