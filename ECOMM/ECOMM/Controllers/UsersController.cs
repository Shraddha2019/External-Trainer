using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECOMM.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/


        public ActionResult Index()
        {
            return View();
        }

        // eg: /users/5
       [Route("users/{id:int}")]
        public ActionResult GetUserById(int id)
        {
            return View();
        }

        // eg: users/ken
        [Route("users/{name}:string")]
        public ActionResult GetUserByName(string name)
        {

            return View();
        }
    }
}
