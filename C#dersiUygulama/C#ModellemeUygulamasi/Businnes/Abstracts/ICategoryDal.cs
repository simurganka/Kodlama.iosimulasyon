using C_ModellemeUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Businnes.Abstracts
{
    public interface ICategoryDal
    {

        Category FirstOrDefault(Func<Category, bool> predicate);
        List<Category> GetAll();
        void Add(Category category);
        void Remove(Category category);
        void Update(Category category);

    }
}
