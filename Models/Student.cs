using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMVCDemo.Models
{
    public class Student
    {
        public string Id { get; set; }
        [StringLength(30, MinimumLength =5, ErrorMessage ="Invalid Length For Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
    }
}