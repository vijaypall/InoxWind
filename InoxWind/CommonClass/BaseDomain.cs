using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InoxWind.CommonClass
{
    public static class BaseDomain
    {
        public static string GetBaseDomain(HttpRequest Request)
        {
            string baseDomain = Request.ServerVariables["HTTP_HOST"];
            string protocol = Request.IsSecureConnection ? "https://" : "http://";
            return protocol + baseDomain;
        }
    }
}