using bai2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetByNameList()
        {

            List<Student> lstStudent = new List<Student>();
            Student objStudent = new Student();
            objStudent.Id = 01;
            objStudent.Name = "Quang flo";
            objStudent.Age = 22;
            lstStudent.Add(objStudent);


            objStudent = new Student();
            objStudent.Id = 02;
            objStudent.Name = "Van Quang";
            objStudent.Age = 21;
            lstStudent.Add(objStudent);
            return View(lstStudent);
        }


        public ActionResult GetByNameId(int id)
        {
            return View();
        }
        private ActionResult GetDataAndResult(int id, bool sortAscending)
        {
            return View();
        }
        public ActionResult DetailsValType(int id, bool sortAscending)
        {
            return GetDataAndResult(id, sortAscending);
        }

       
    }
}