using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDemo.Filters
{
    public class FooterFilterAttribute : ActionFilterAttribute 
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //base.OnResultExecuted(filterContext);
            HttpContext.Current.Response.Write("<p><hr/>Srikanth Technologies</p>");
        }
    }
}