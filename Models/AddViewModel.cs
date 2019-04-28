using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Models
{

    public class AddViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public List<SelectListItem> Courses;
    }
}