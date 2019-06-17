using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECOMM.Controllers
{
    public class FlowersController : Controller
    {
        //
        // GET: /Flowers/

     
              // GET: Payments
        [OutputCache(Duration = 100)]
        public ActionResult Index()
        {
            return View();
        }
        }

    }

