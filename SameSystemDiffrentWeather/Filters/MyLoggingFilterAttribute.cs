﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SameSystemDiffrentWeather.Filters
{
    public class MyLoggingFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var req = filterContext.HttpContext.Request;
            //TODO add custom logging logic

            base.OnActionExecuted(filterContext);
        }
    }
}