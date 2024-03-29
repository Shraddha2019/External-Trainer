﻿using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Linq;
//using System.Web.Mvc.Routing;

namespace ECOMM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            //var constraintsResolver = new DefaultInlineConstraintResolver();
            //constraintsResolver.ConstraintMap.Add("values", typeof(ValuesConstraint));
            //routes.MapMvcAttributeRoutes(constraintsResolver);


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

//    public class ValuesConstraint : IRouteConstraint
//    {
//        private readonly string[] validOptions;
//        public ValuesConstraint(string options)
//        {
//            validOptions = options.Split('|');
//        }

//        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
//        {
//            object value;
//            if (values.TryGetValue(parameterName, out value) && value != null)
//            {
//                return validOptions.Contains(value.ToString(), StringComparer.OrdinalIgnoreCase);
//            }
//            return false;
//        }
//    }

//}
