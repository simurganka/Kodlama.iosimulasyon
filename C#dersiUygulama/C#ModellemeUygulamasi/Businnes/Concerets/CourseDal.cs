using C_ModellemeUygulamasi.Businnes.Abstracts;
using C_ModellemeUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Businnes.Concerets
{
       
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        private readonly ICourseDal _courseDal;

        public CourseDal() 
        
        {

            

            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı";
            course1.Description = "";
            course1.Price= 10;
            course1.CategoryId = 1;
            course1.InstructorId = 1;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Yazılım Geliştirici Yetiştirme Kampı";
            course2.Description = "";
            course2.Price = 20;
            course2.CategoryId = 2;
            course2.InstructorId = 2;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course3.Description = "";
            course3.Price = 30;
            course3.CategoryId = 3;
            course3.InstructorId = 3;

            Course course4 = new Course();
            course4.Id = 4;
            course4.Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course4.Description = "";
            course4.Price = 40;
            course4.CategoryId = 4;
            course4.InstructorId = 4;

            courses = new List<Course> { course1, course2, course3, course4 };
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
        }



        public void Update(Course course)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetCourseById(int id)
        {
            throw new NotImplementedException();
        }
    }

}
