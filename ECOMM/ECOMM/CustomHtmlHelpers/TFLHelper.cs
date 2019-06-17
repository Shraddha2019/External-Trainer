using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECOMM.CustomHtmlHelpers
{
    public static class TFLHelper
    {
        public static IHtmlString Format(string Content)
        {
             string LableStr = "<label style=\'background-color:blue;color:yellow;font-size:24px\'>{" + Content+ "}</label>";

            // string LableStr = $"<label style=\"background-color:blue;color:yellow;font-size:24px\">{Content}</label>";
            return new HtmlString(LableStr);
        }

        public static IHtmlString PunchLineFor(this HtmlHelper helper,
             string content)
        {
            string LableStr = "<label style=\"background-color:lightblue;color:red;font-size:24px\">{content}</label>";
            return new HtmlString(LableStr);
        }
    }
}