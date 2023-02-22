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
    public class CategoryRepository : ICategoryDAL
    {
        Context c = new Context();
        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return c.categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
