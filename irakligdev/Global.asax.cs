using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using irakligdev.DBEntities;

namespace irakligdev
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //    DeleteScoreData();

        }
        public void DeleteScoreData()
        {
            using (var context = new ScoreContext())
            {
                context.Score.RemoveRange(context.Score);
                context.SaveChanges();
            }
        }
    }
}
