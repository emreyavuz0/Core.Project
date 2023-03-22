using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
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

        private readonly ICategoryDAL _categoryDal;
        public CategoryManager(ICategoryDAL categoryDal)
        {   
            _categoryDal = categoryDal;
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetByID(id);
        }
        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }
        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }
        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }

        //public void CategoryAdd(Category category)
        //{
        //    _categoryDal.Insert(category);
        //}

        //public void CategoryDelete(Category category)
        //{
        //    _categoryDal.Delete(category);
        //}

        //public void CategoryUpdate(Category category)
        //{
        //    _categoryDal.Update(category);
        //}


  
    }
}
