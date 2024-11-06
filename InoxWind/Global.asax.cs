using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace InoxWind
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            // Capture the last error
            Exception exception = Server.GetLastError();

            // Log the exception (optional)
            // e.g., LogError(exception);

            // Redirect to GeneralError.aspx
            Server.ClearError();
            Response.Redirect("~/Error/GeneralError.aspx");
        }
    }
}