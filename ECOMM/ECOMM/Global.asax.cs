using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using BOL;
using BLL;


namespace ECOMM
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        //protected void Application_Start()
        //{
        //    AreaRegistration.RegisterAllAreas();

        //    WebApiConfig.Register(GlobalConfiguration.Configuration);
        //    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //    List<Product> products = new List<Product>();
            

        //    products.Add(new Product { ID = 12, Title = "Gerbera", Description = "Wedding flower", UnitPrice = 12 });
        //    products.Add(new Product { ID = 13, Title = "Rose", Description = "Valentine flower", UnitPrice = 24 });
        //    products.Add(new Product { ID = 14, Title = "Louts", Description = "Worship flower", UnitPrice = 45 });
        //    products.Add(new Product { ID = 15, Title = "Marigold", Description = "Festival flower", UnitPrice = 67 });
        //    this.Application.Add("catalog", products);
        //   
        //List<Customer> customers = new List<Customer>();
        //    customers.Add(new Customer { custid = 1, custname = "ssp", mobno = 34232222 });
        //    customers.Add(new Customer { custid = 2, custname = "shweta", mobno = 637755 }); 
        //    customers.Add(new Customer { custid = 3, custname = "manali", mobno = 234522 });
        //    this.Application.Add("catlog1", customers);
        //}
        //protected void Session_Start()
        //{
        //    Employee empl = new Employee();
        //    this.Session.Add("empname",empl);

        //}
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            List<Product> products = new List<Product>();
            this.Application.Add("catalog", products);

            products.Add(new Product { ID = 12, Title = "Gerbera", Description = "Wedding flower", UnitPrice = 12 });
            products.Add(new Product { ID = 13, Title = "Rose", Description = "Valentine flower", UnitPrice = 24 });
            products.Add(new Product { ID = 14, Title = "Louts", Description = "Worship flower", UnitPrice = 45 });
            products.Add(new Product { ID = 15, Title = "Marigold", Description = "Festival flower", UnitPrice = 67 });


            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Nihilent", Email = "shiv.khera@nihilent.com", RegistrationDate = DateTime.Parse("9/2/2015"), isMVC = true, Location = "Mumbai", Membership = "Gold" });
            customers.Add(new Customer { Id = 2, Name = "IBM", Email = "sarang.sharma@ibm.com", RegistrationDate = DateTime.Parse("12/2/2016"), isMVC = false, Location = "Delhi", Membership = "Silver" });
            customers.Add(new Customer { Id = 3, Name = "Rational", Email = "patrik.s@rational.in", RegistrationDate = DateTime.Parse("8/3/2012"), isMVC = true, Location = "Mumbai", Membership = "Platinum" });
         
            this.Application.Add("catlog1", customers);
        
        }

        protected void Session_Start()
        {
            ShoppingCart theCart = new ShoppingCart();
            /*
           Item item1 = new Item { ProductID = 12, Quantity = 40 };
           Item item2 = new Item { ProductID = 15, Quantity = 1400 };
           Item item3 = new Item { ProductID = 17, Quantity = 400 };

           Item item4 = new Item { ProductID = 20, Quantity = 30 };
           theCart.AddToCart(item1);
           theCart.AddToCart(item2);
           theCart.AddToCart(item3);
           theCart.AddToCart(item4);

           */

            this.Session.Add("cart", theCart);
            //by default items are not stored in session.
            //IT is empty first time when user interacts with 
            // web application


        }
        //fired when session starts on each new user requesting a page.


        protected void Application_AuthenticateRequest()
        {

        }







        protected void Application_Error()
        {/*
            //trapping runttime  Exceptions 

            // Code that runs when an unhandled error occurs
      Exception objErr = Server.GetLastError().GetBaseException();
            string err = "Error in: " + Request.Url.ToString() +
                              ". Error Message:" + objErr.Message.ToString();



            var body = "<p>Email From: {0} ({1})Message:</p><p>{2}</p>";
            var message = new System.Net.Mail.MailMessage();
            //message.To.Add(new MailAddress("recipient@gmail.com"));  // replace with valid value 
            message.To.Add(new MailAddress("haha")); // replace with valid value 
                                                     //message.From = new MailAddress("sender@outlook.com");  // replace with valid value
            message.From = new MailAddress("hahaha"); // replace with valid value,you cannot commend it, since it's required
            message.Subject = "Runtime excpetion from ESTore";
            message.Body = string.Format(body, err);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "emailAddress", // replace with valid value
                    Password = "yourPassword" // Password = "password"  // replace with valid value
                };
                //smtp.Credentials = credential;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("ravi.tambade@transflower.in", "Password"); //You will be receive email from this email address
                                                                                                      //smtp.Host = "smtp-mail.outlook.com";
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);

            }*/

        }



        // – fired when an error occurs.
        protected void Session_End()
        {
            ShoppingCart theCart = this.Session["cart"] as ShoppingCart;

        }
        //– fired when the session of a user ends.
        protected void Application_End()
        {

        }

        // fired when the web application ends.
        protected void Application_Disposed()
        {

        }

    }
}