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
        public ActionResult List()
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students", con);
            SqlDataReader dr = cmd.ExecuteReader();
            var students = new List<Student>();

            while(dr.Read())
            {
                students.Add(new Student
                {
                    Id = dr["StudentID"].ToString(),
                    Name = dr["Fullname"].ToString(),
                    Email = dr["Email"].ToString(),
                    Course = Int32.Parse(dr["Course"].ToString())
                }
                );
            }
            return View(students);
        }

        
        public ActionResult Add()
        {
            Student s = new Student();
            return View(s);

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


        public ActionResult Delete(int id)
        {
            // delete student with given id 

            return RedirectToAction("List");

        }
    }
}