﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace AspNetMVCDemo.Models
{
    public class Database
    {
        public static string ConnectionString
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            }
        }
    }
}