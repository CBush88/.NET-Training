﻿using System.Web;
using System.Web.Mvc;

namespace ProgrammingPractice_EF_CodeFirst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
