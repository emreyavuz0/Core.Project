using Core.DataAccessLayer.Abstract;
using Core.DataAccessLayer.Concrete;
using Core.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccessLayer.Repository
{
    public class BlogRepository : IBlogDAL
    {
        
        public void AddBlog(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
