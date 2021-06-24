using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Project.Models
{
    //Student model.
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //For storing student name.
        public string Std_Name { get; set; }

        //For storing student class.
        public int Std_Class { get; set; }

        //For storing student roll no.
        public int Std_Roll { get; set; }

        //For storing student school.
        public string Std_School { get; set; }

        //For storing student gender.
        public string Std_Gender { get; set; }



    }
}
