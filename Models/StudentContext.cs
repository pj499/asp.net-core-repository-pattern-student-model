using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Project.Models
{

    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
