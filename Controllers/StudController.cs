using Asp_Core_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Project.Controllers
{
    public class StudController : Controller
    {
        //obj variable would be used to access StudentRepository class.
        private readonly IStudentRepository obj;

        public StudController(IStudentRepository student)
        {
            obj = student;
        }
        
        //Action to get details.
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //Action to save data into database.
        [HttpPost]
        public IActionResult Add(Student student)
        {
            bool result = obj.Insert(student);
            if (result == true)
                ViewBag.Message = "Student Added Successfully";
            else
                ViewBag.Message = "Failed to Add Student Details";
            return View();
        }


        
    }
}
