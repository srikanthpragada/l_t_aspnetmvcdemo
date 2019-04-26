using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMVCDemo.Models
{
    public class Discount
    {
        [Required(ErrorMessage ="Amount is missing!")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "Discount Rate is missing!")]
        [Range(5,50,ErrorMessage ="Invalid value for discount rate")]
        public double Rate { get; set; }

        public double Result { get; set; }
    }
}