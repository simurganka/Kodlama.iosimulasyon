using C_ModellemeUygulamasi.Businnes.Abstracts;
using C_ModellemeUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Businnes.Managers
{
    public class CategoryManager : ICategoryDal
    {
        private readonly ICategoryDal _categoryDal;

        public void AddCategory(Category category)
        {
            _categoryDal.Add(category);
        }
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void UpdateCategory(Category category)
        {
            if (category != null)
            {
                var existingCategory = _categoryDal.FirstOrDefault(c => c.Id == category.Id);
                if (existingCategory != null)
                {
                    existingCategory.Name = category.Name;
                    // diğer özellikleri de güncelle
                }
            }

        }

        public void DeleteCategory(int id)
        {
            var category = _categoryDal.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _categoryDal.Remove(category);
            }
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.FirstOrDefault(c => c.Id == id);
        }

        

        public List<Category> GetAll()
        {
            var categories = _categoryDal.GetAll(); 
            return categories.ToList();
        }

        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void Remove(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        public Category FirstOrDefault(Func<Category, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
