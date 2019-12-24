using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Hooshyar.IocConfig;
using Newtonsoft.Json;

namespace Hooshyar.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
	        var container = SmObjectFactory.Container;
	        GlobalConfiguration.Configuration.Services.Replace(
		        typeof(IHttpControllerActivator), new StructureMapHttpControllerActivator(container));

			// Web API configuration and services
			// Web API routes
			config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

	        //config.Formatters.Clear();
	        //config.Formatters.Add(new JsonMediaTypeFormatter());
	        //config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
	        //config.Formatters.JsonFormatter.Indent = true;
		}
    }
}
