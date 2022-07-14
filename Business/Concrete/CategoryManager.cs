using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
            Console.WriteLine("Kategori eklendi! " + category.CategoryName);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
            Console.WriteLine("Kategori silindi! " + category.CategoryName);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
            Console.WriteLine("Kategori güncellendi! " + category.CategoryName);
        }
    }
}
