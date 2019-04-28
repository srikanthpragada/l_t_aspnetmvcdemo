using AspNetMVCDemo.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Controllers
{
    //[FooterFilter]
    public class TestController : Controller
    {
        [LogFilter(Order =1)]
        //[TestFilter(Order = 2)]
        public ActionResult Index()
        {
            HttpContext.Response.Write("Executing Index<p/>");
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(string feedback)
        {
            HttpContext.Response.Write("Executing Index<p/>");
            return View();
        }

        public String  About()
        {
            HttpContext.Response.Write("Executing About...<p/>");
            return "";
        }
    }
}