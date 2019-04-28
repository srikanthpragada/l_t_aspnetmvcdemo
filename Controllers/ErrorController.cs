using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public string Index(string v)
        {
            int n = Int32.Parse(v);
            return "Value = " + v;
        }

        protected override void OnException(ExceptionContext exc)
        {
            exc.ExceptionHandled = true;
            HttpContext.Response.Write("Sorry!");
        }
    }
}