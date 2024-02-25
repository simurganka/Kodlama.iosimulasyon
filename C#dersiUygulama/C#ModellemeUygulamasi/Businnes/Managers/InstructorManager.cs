using C_ModellemeUygulamasi.Businnes.Abstracts;
using C_ModellemeUygulamasi.Businnes.Concerets;
using C_ModellemeUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Businnes.Managers
{
    public class InstructorManager : IInstructorDal
    {

        List<Instructor> _instructors;
        public InstructorManager(IInstructorDal instructorDal)
        {

            instructorDal = instructorDal;

            Instructor inst1 = new Instructor(1, "Engin", "Demirog", "engindemiro@gmail.io");
            inst1.Id = 1;
            inst1.FirstName = "Engin";
            inst1.LastName = "Demirog";
            inst1.Email = "engindemiro@gmail.io";

            Instructor inst2 = new Instructor(2,"Halit Enes","Kalaycı","halitkalayci@gmail.io");
            inst2.Id = 2;
            inst2.FirstName = "Halit Enes";
            inst2.LastName = "Kalaycı";
            inst2.Email = "halitkalaycı@gmail.io";

            _instructors = new List<Instructor> { inst1, inst2 };


        }
       

        public List<Instructor> GetAll()
        {
            return _instructors;
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }



        public void Remove(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}
