using AspNetMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        [OutputCache(Duration = 60 , VaryByParam ="cat")]
        public ActionResult List()
        {
            ViewBag.Timestamp = DateTime.Now.ToLongTimeString();
            return View(StudentDAL.GetStudents());
        }

        
        public ActionResult Add()
        {
            var courses = new List<SelectListItem>();
            courses.Add(new SelectListItem { Text = "MS.Net", Value = "1" });
            courses.Add(new SelectListItem { Text = "Java", Value = "2" });
            courses.Add(new SelectListItem { Text = "Python", Value = "3" });

            AddViewModel model = new AddViewModel();
            model.Student = new Student();
            model.Courses = courses;
            return View(model);

        }
        [HttpPost]
        public ActionResult Add(Student model)  
        {
            // add to Students table
            if (ModelState.IsValid)
            {
                return RedirectToAction("List");
            }

            return View(model);
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            ViewBag.User = User.Identity.Name;
            // delete student with given id 
            // ViewBag.Message = "Deleted student with id : " + id;
            // Session["Message"] = "Deleted student with id : " + id;
            bool done = StudentDAL.DeleteStudent(id);
            if ( done )
                  TempData["Message"] = "Deleted student with id : " + id;
            else
                  TempData["Message"] = "Sorry! Could not delete student with id : " + id;

            return RedirectToAction("List");

        }

        public ActionResult Search()
        {
            return View();
        }


        public ActionResult DoSearch(string sname)
        {
            var students = StudentDAL.SearchStudents(sname);
            return PartialView("SearchResult", students);
        }

    }


}