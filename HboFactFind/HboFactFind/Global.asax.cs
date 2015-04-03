﻿using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HboFactFind
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest()
        {
            var info = new CultureInfo(Thread.CurrentThread.CurrentCulture.ToString())
            {
                DateTimeFormat = {ShortDatePattern = "dd/MM/yyyy"}
            };
            Thread.CurrentThread.CurrentCulture = info;
        }
    }
}