﻿using System.Web;
using System.Web.Http;

namespace WebAPI_v4
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
