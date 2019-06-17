using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace ECOMM.CustomFilters
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogEntry("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogEntry("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            LogEntry("OnResultExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogEntry("OnResultExecuting ", filterContext.RouteData);
        }

        private void LogEntry(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = String.Format("{0}- controller:{1} action:{2}", methodName,
                                                                        controllerName,
                                                                        actionName);
            Debug.WriteLine(message);
        }
    }
}