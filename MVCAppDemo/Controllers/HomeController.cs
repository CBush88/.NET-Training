using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppDemo.Models;

namespace MVCAppDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public string Index()
        //{
        //    return "Welcome to my first ASP.NET MVC application";
        //}
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowData()
        {
            Student s1= new Student();
            s1.StudentId= 101;
            s1.StudentName = "Samantha";
            s1.StudentCourse = "Java";

            Student s2 = new Student();
            s2.StudentId = 102;
            s2.StudentName = "John";
            s2.StudentCourse = "Python";

            Student s3 = new Student();
            s3.StudentId = 103;
            s3.StudentName = "Samuel";
            s3.StudentCourse = ".NET";

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);


            return View(students);
        }
    }
}