using C_ModellemeUygulamasi.Businnes.Abstracts;
using C_ModellemeUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Businnes.Managers
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseDal.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _courseDal.GetCourseById(id);
        }


        public void AddCourse(Course course)
        {
            _courseDal.Add(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseDal.Update(course);
        }

        public void DeleteCourse(int id)
        {
            _courseDal.Delete(id);
        }

    }
}

