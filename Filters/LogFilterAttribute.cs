using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Filters
{
    public class LogFilterAttribute : ActionFilterAttribute 
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // base.OnActionExecuting(filterContext);
            HttpContext.Current.Response.Write
                ($"About to execute action -> {filterContext.ActionDescriptor.ActionName} <p/>");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            // base.OnActionExecuting(filterContext);
            HttpContext.Current.Response.Write("Executed action <p/>");
        }
    }
}