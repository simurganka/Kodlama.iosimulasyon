using C_ModellemeUygulamasi.Businnes.Abstracts;
using C_ModellemeUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Businnes.Concerets
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> category;

        public CategoryDal()
        {
            Category category1= new Category();
            category1.Id = 1;
            category1.Name = "Tümü";

            Category category2= new Category();
            category2.Id = 2;
            category2.Name = "Programlama(8)";

            category = new List<Category> { category1, category2 };
        }
        public Category FirstOrDefault(Func<Category, bool> predicate)
        {
            return category.FirstOrDefault(predicate);
        }
        public List<Category> GetAll()
        {
           return category;
        }
        public void Add(Category category)
        {
            //category.Add(category) ;
        }

        

        public void Remove(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
        

         
           
}
