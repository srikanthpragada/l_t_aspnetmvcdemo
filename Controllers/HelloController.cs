using AspNetMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Controllers
{
    public class HelloController : Controller
    {
        public string Welcome()
        {
            return "Welcome To Asp.Net MVC";
        }

        public ActionResult Wish(string name)
        {
            Message model = new Message();
            model.Title = "Hello!";
            if (name == null)
                model.Name = "Unknown";
            else
                model.Name = name;

            return View(model);
        }

    }
}