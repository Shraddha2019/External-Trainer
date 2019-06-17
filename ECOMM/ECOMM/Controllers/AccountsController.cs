using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using System.Web.Security;
namespace ECOMM.Controllers
{
    public class AccountsController : Controller
    {
        //
        // GET: /Accounts/
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(string userName, string password)
        //{
        //    if (userName == "neova" && password == "neova123")
        //    {
        //        return this.RedirectToAction("index", "Orders");
        //    }
        //    return View();
        //}
        [HttpPost]
        public ActionResult Login(string username, string password, string returnUrl)
        {   //if(Username=="swati" && Password=="ganvir")
            if (AccountManager.Validate(username, password))
            {
                //return this.RedirectToAction("Orders","Orders");
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnUrl ?? Url.Action("Index", "Home"));
            }
            return View();

        }
    }
}
