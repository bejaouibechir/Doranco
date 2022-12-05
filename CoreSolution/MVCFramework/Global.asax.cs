using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCFramework
{
    public class MvcApplication : System.Web.HttpApplication
    {

        static public int nbHits;
        public static int nbUsers;
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            nbHits = 0;
            nbUsers = 0;

            Debug.WriteLine("Demarage de l'application");
        }


        protected void Application_End()
        {
            ;
        }

        protected void Application_BeginRequest()
        {
            Debug.WriteLine($"Debut de requête à {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
            nbHits++;
        }

        protected void Application_EndRequest()
        {
            Debug.WriteLine($"Fin de requête à {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
        }

        protected void Session_Start(Object sender, EventArgs e)
        {
            nbUsers++;
        }
        protected void Session_End(Object sender, EventArgs e)
        {
            nbUsers--;
        }


    }
}
