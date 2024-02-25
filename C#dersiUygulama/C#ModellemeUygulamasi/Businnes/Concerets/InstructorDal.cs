using C_ModellemeUygulamasi.Businnes.Abstracts;
using C_ModellemeUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Businnes.Concerets
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor(1,"Engin","Demiroğ","engindemirog@gmail.io");
            instructor1.Id = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demiroğ";
            instructor1.Email = "engindemiro@gmail.io";

            Instructor instructor2 = new Instructor(2,"Halit Enes","Kalaycı","halitkalaycı@gmail.io");
            instructor2.Id = 2;
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "Kalaycı";
            instructor2.Email = "halitkalaycı@gmail.io";

            instructors = new List<Instructor> { instructor1, instructor2 };
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Remove(Instructor instructor)
        {
            Instructor instructorToRemove = instructors.SingleOrDefault(i => i.Id == instructor.Id);
            if (instructorToRemove != null)
            {
                instructors.Remove(instructorToRemove);
            }
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = instructors.SingleOrDefault(i => i.Id == instructor.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.FirstName = instructor.FirstName;
                instructorToUpdate.LastName = instructor.LastName;
            }
        }
    }
}
