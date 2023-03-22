using Core.DataAccessLayer.Abstract;
using Core.DataAccessLayer.Concrete;
using Core.DataAccessLayer.Repository;
using Core.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c=new Context())
            {
                return c.blogs.Include(x=>x.Category).ToList();
            }
        }

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.blogs.Include(x => x.Category).Where(x=>x.WriterId==id).ToList();
            }
        }
    }
}
