using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Project.Models
{
    //Requisite interface for StudentRepository class.
    public interface IStudentRepository
    {
        //Inserting a student to database.
        public bool Insert(Student s);

    }
}
