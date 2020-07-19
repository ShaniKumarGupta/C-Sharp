using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentList = new List<StudentDetails>{
                            new StudentDetails() { stuId = 1, stuName = "John", stuCollege = "GLA", stuBranch = "CSE", stuAge = 18 } ,
                            new StudentDetails() { stuId = 2, stuName = "Steve", stuCollege = "ABES", stuBranch = "ME",  stuAge = 21 } ,
                            new StudentDetails() { stuId = 3, stuName = "Bill", stuCollege = "BHU", stuBranch = "CE",  stuAge = 25 } ,
                            new StudentDetails() { stuId = 4, stuName = "Ram" , stuCollege = "GLA", stuBranch = "CSE", stuAge = 20 } ,
                            new StudentDetails() { stuId = 5, stuName = "Ron" , stuCollege = "GLA", stuBranch = "CSE", stuAge = 31 } ,
                            new StudentDetails() { stuId = 4, stuName = "Chris" , stuCollege = "BHU", stuBranch = "EE", stuAge = 17 } ,
                            new StudentDetails() { stuId = 4, stuName = "Rob" , stuCollege = "ABES", stuBranch = "EC", stuAge = 19 }
                        };
            // Get the students from the database in the real application

            return View(studentList);
        }

       /* public string Index()
        {
            return "This is the INdex method of StudentController";
        } */

        public ActionResult stuDetails()
        {
            StudentDetails stu = new StudentDetails();
            stu.stuId = 101;
            stu.stuName = "Shani Kumar Gupta";
            stu.stuCollege = "GLA University, Mathura";
            stu.stuBranch = "Computer Science and Engineering";
            stu.stuAge = 21;

            return View(stu);

        }

        public ActionResult RegisterUser()
        {
            return View();
        }



        public ActionResult Create(StudentDetails stu)
        {
            ViewBag.stuId = stu.stuId;
            ViewBag.stuName = stu.stuName;
            ViewBag.stuCollege = stu.stuCollege;
            ViewBag.stuBranch = stu.stuBranch;
            ViewBag.stuAge = stu.stuAge;
            return View("stuDetails", stu);
        }

        /*public ActionResult stuCreate(StudentDetails studentDetails)
        {
            return View("stuDetails",studentDetails);
        }*/
    }
}