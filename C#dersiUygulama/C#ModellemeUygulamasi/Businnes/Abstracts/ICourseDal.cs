using C_ModellemeUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Businnes.Abstracts
{
    public interface ICourseDal
    {
        List<Course>GetAll();
       
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);

        Course GetCourseById(int id);



    }
}
