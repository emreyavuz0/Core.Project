using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.EntityFramework;
using Core.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly EfCategoryRepository efCategoryRepositorys;
        public CategoryManager()
        {
            efCategoryRepositorys= new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCategoryRepositorys.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepositorys.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepositorys.Update(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepositorys.GetByID(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepositorys.GetListAll();
        }
    }
}
