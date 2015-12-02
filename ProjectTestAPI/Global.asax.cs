using ProjectTestAPI.Areas.v1.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjectTestAPI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            //Configuration configuration = WebConfigurationManager.OpenWebConfiguration("~");
            //CustomErrorsSection customErrorsSection = (CustomErrorsSection)configuration.GetSection("system.web/customErrors");

            //CustomError error = customErrorsSection.Errors.Get("404");
            //if (error == null)
            //{
            //     set as required
            //    customErrorsSection.Mode = CustomErrorsMode.On;

            //    error = new CustomError(404, "NotFoundPage.aspx");
            //    customErrorsSection.Errors.Add(error);
            //    configuration.Save(ConfigurationSaveMode.Modified);
            //}



            //WebException ex = new WebException();
            //if ()
            //{
            //    var resp = (HttpWebResponse)ex.Response;
            //    if (resp.StatusCode == HttpStatusCode.NotFound)
            //    {
            //         Do something
            //    }
            //    else
            //    {
            //         Do something else
            //    }
            //}
            //else
            //{
            //     Do something else
            //}

        }
        protected void Application_Error(object sender, EventArgs e)
        {
        //    var exception = HttpContext.Current.Server.GetLastError();

        //    if (null != exception)
        //    {
        //        // by default 500
        //        var statusCode = (int)HttpStatusCode.InternalServerError;

        //        if (exception is HttpException)
        //        {
        //            statusCode = new HttpException(null, exception).GetHttpCode();
        //        }
        //        else if (exception is UnauthorizedAccessException)
        //        {
        //            // to prevent login prompt in IIS
        //            // which will appear when returning 401.
        //            statusCode = (int)HttpStatusCode.Forbidden;
        //        }

        //        if ((LogHttpNotFound && statusCode == 404) || statusCode != 404)
        //        {
        //            if (null != _loggerFunc)
        //            {
        //                LoggerFunc(string.Format("ASP.NET Error Captured, Request URL: {0}, Exception:",
        //                    HttpContext.Current.Request.Url), exception);
        //            }
        //        }

        //        ExceptionInfo = exception.Message;
        //        _statusCode = statusCode;

        //    }
        }

    }
}