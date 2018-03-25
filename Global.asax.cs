using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Sitecore.Web;
namespace SitecoreCookbook
{
    public class MvcApplication : Sitecore.Web.Application
    {
        protected void Application_Start()
        {
  		   AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
