using System;
//using System.Web.Http.Cors;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace WebAPIDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //MediaTypeFormatterPascal JsonMediaTypeFormatter
            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;
            settings.DateFormatString = "dd MMM yyyy";
            //settings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            
            //config.Formatters.Remove(config.Formatters.JsonFormatter);
            //EnableCorsAttribute enableCorsAttribute = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(enableCorsAttribute);
        }
    }
}
