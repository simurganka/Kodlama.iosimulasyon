using C_ModellemeUygulamasi.Businnes.Abstracts;
using C_ModellemeUygulamasi.Businnes.Concerets;
using C_ModellemeUygulamasi.Businnes.Managers;
using C_ModellemeUygulamasi.Entities;
using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main()
        {
            CourseManager courseManager = new CourseManager(new CourseDal());
            List<Course> courses = courseManager.GetAll();
            foreach (Course course in courses)
            {
                Console.WriteLine($"Course ID: {course.Id}, Name: {course.Name}");
            }



            InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            List<Instructor> instructors = instructorManager.GetAll();
            foreach (Instructor instructor in instructors)
            {
                Console.WriteLine($"Instructor ID: {instructor.Id}, Name: {instructor.FirstName} {instructor.LastName}");
            }



            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            List<Category> categories = categoryManager.GetAll();
            foreach (Category category in categories)
            {
                Console.WriteLine($"Category ID: {category.Id}, Name: {category.Name}");
            }



            var category1 = new List<Category>(); // Örnek olarak bir liste oluşturuldu, sizin durumunuza göre farklılık gösterebilir

            foreach (var category in category1)
            {
                Console.WriteLine(category.Id + " = " + category.Name);
            }



        }
    }
}
