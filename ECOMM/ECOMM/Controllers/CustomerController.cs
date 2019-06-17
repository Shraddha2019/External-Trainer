using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
namespace ECOMM.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            //retrive data from application variables
            List<Customer> customers = (List<Customer>)this.HttpContext.Application["catlog1"];


            return View(customers);
        }
        public ActionResult Details(int id)
        {
            Customer foundProduct = null;
            List<Customer> customers = (List<Customer>)this.HttpContext.Application["catlog1"];
            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                {
                    foundProduct = customer;
                }
            }
            return View(foundProduct);
        }


    }
}
