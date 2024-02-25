﻿using C_ModellemeUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ModellemeUygulamasi.Businnes.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);
        void Remove(Instructor instructor);
        void Update(Instructor instructor);


    }
}
