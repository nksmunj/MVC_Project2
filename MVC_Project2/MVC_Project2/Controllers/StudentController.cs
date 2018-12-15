using MVC_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        [HttpGet]
        public ActionResult Index()
        {
            var studentList = new List<Student>{
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
                        };
            // Get the students from the database in the real application

            return View(studentList);
        }

        
        public ActionResult MethodNew()
        {
            return RedirectToAction("Index");
        }


        [ActionName("find1")]
        public ActionResult GetById()
        {
            // get student from the database 
            return View();
        }

        [ActionName("find")]
        public ActionResult GetById(int id)
        {
            // get student from the database 
            return View();
        }

    }
}