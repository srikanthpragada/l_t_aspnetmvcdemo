using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Models
{
    public class AddViewModel
    {
        public Student Student;
        public List<SelectListItem> Courses;
    }
}