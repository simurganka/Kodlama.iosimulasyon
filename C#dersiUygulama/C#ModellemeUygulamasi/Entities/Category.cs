using C_ModellemeUygulamasi.Businnes.Concerets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Entities
{
    public class Category
    {
      

        
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> category { get; set; }
    }
}
