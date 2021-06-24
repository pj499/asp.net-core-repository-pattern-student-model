using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Project.Models
{
    //Implementing repository pattern.
    public class StudentRepository:IStudentRepository
    {
        private StudentContext context;

        public StudentRepository(StudentContext context)
        {
            //Initialising the context object.
            this.context = context;
        }


        //Defining the insert function.
        public bool Insert(Student s)
        {
            var query = from st in context.Students
                        where st.Std_Name == s.Std_Name
                        && st.Std_Roll == s.Std_Roll
                        select st;

            //Checking for existence of duplicate records.
            if (query.Count() >= 1)
                return false;
            else
            {
                //Saving things to database.
                context.Students.Add(s);
                context.SaveChanges();
                return true;
            }
        }
    }
}
