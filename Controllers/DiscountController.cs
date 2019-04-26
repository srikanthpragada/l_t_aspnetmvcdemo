using AspNetMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Controllers
{
    public class DiscountController : Controller
    {
        [HttpGet]
        public ActionResult Calculate()
        {
            Discount model = new Discount();
            return View(model);
        }

        [HttpPost]
        public ActionResult Calculate(Discount model)
        {
            if (model.Amount > 1000000)
                ModelState.AddModelError("Amount","Very high amount!");

            if(ModelState.IsValid)
              model.Result = model.Amount * model.Rate / 100; 

            return View(model);
        }


    }
}