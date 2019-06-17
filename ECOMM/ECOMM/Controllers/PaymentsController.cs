using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECOMM.CustomFilters;

namespace ECOMM.Controllers
{

       
    [HandleError]
[Log]
    public class PaymentsController : Controller
    {
        // GET: Payments
        [OutputCache(Duration = 100)]
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Pending()
        {

            // throw exception for demo
 
            throw new Exception("This is unhandled exception");
             return View();
        }
    }
}
