using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice1.Models;
namespace practice1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student stud = new Student();
            stud.StudentId = 1;
            stud.StudentName = "Sagar";
            stud.isNewlyEnrolled = true;
            stud.Gender = "Male";
            stud.Grade = "A+";
            return View(stud);
        }
    }
}