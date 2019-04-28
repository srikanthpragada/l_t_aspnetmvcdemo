using AspNetMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetMVCDemo.Controllers
{
    public class StudController : ApiController
    {
        public List<Student> Get()
        {
            return StudentDAL.GetStudents();
        }

        public Student Get(int id)
        {
            Student s = StudentDAL.GetStudent(id);
            if (s == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            else
                return s; 
        }

        public void Post(Student s)
        {
            bool done = StudentDAL.AddStudent(s);
            if (!done)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
        }

        public void Put(int id, Student s)
        {
            
        }

        public void Delete(int id)
        {

        }
    }
}
