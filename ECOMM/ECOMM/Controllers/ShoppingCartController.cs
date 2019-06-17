using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using ECOMM.ViewModel;
using BLL;
namespace ECOMM.Controllers
{
    public class ShoppingCartController : Controller
    {
        //
        // GET: /ShoppingCart/

        public ActionResult Shoppingview()
        {


            ShoppingViewModel ShoppingViewModel = new ShoppingViewModel()
              {
                  // List<Customer> customers = (List<Customer>)this.HttpContext.Application["catlog1"];
                  //    Customer customers = (List<Customer>)this.HttpContext.Application["catlog1"],

                  customers = (List<Customer>)HttpContext.Application["catlog1"],
                  products = (List<Product>)HttpContext.Application["catlog"],

              };
            ShoppingViewModel ShoppingView = new ShoppingViewModel();
            ShoppingView.products = (List<Product>)HttpContext.Application["catalog"];
            ShoppingView.customers = (List<Customer>)HttpContext.Application["catlog1"];




            return View(ShoppingView);
        }
        List<Product> productss = new List<Product>();

        public ActionResult AddToCart(int id = 0)
        {
            Product ProdFound = null;
            List<Product> Pprod = new List<Product>();
        //    List<Product> products = (List<Product>)this.HttpContext.Application["catalog"];
            List<Product> products = ProductManager.GetAllProduct();
            foreach (Product prod in products)
            {
                if (prod.ID == id)
                {
                    ProdFound = prod;
                }
            }
            if (Session["ProductList"] != null)
            {
                productss = (List<Product>)(Session["ProductList"]);
                if (!productss.Contains(ProdFound))
                {
                    if (ProdFound != null)
                        productss.Add(ProdFound);
                }
            }
            else
            {
                productss.Add(ProdFound);
                Session["ProductList"] = productss;
            }
            if (TempData["ProductList"] != null)
            {
                productss = (List<Product>)(TempData["ProductList"]);
                productss.Add(ProdFound);
            }
            else
            {
                productss.Add(ProdFound);
                TempData["ProductList"] = productss;
                TempData.Keep("ProductList");
            }
            return View(productss);
        }
        public ActionResult RemoveItem(int id)
        {
            productss = (List<Product>)(Session["ProductList"]);

            foreach (BOL.Product prod in (List<Product>)Session["ProductList"])
            {
                if (prod.ID == id)
                {
                    var ind = productss.Find(c => c.ID == id);
                    productss.Remove(ind);
                    break;
                }
            }
            Session["ProductList"] = productss;
            return RedirectToAction("AddToCarT", new { id = 0 });
        }
        //public ActionResult RemoveItem(int id)
        //{
        //    productss = (List<Product>)(Session["ProductList"]);

        //    foreach (BOL.Product prod in (List<Product>)Session["ProductList"])
        //    {
        //        if (prod.ID == id)
        //        {
        //            var ind = productss.Find(c => c.ID == id);
        //            productss.Remove(ind);
        //            break;
        //        }
        //    }
        //    Session["ProductList"] = productss;
        //    return RedirectToAction("AddToCard", new { id = 0 });
        //}
        //public ActionResult Index()
        //{
        //    ShoppingCart theCart = this.Session["cart"] as ShoppingCart;
        //    return View(theCart);
        //}

        //[HttpGet]
        //public ActionResult AddToCart(int id)
        //{
        //    Item theItem = new Item { ProductID = id, Quantity = 0 };
        //    return View(theItem);
        //}

        //[HttpPost]
        //public ActionResult AddToCart(Item theItem)
        //{
        //    ShoppingCart theCart = this.Session["cart"] as ShoppingCart;
        //    theCart.AddToCart(theItem);
        //    return RedirectToAction("index");
        //}

        //[HttpGet]
        public ActionResult RemoveFromCart(int id)
        { //Logic for removing item from Shopping cart kept in session
            ShoppingCart theCart = this.Session["cart"] as ShoppingCart;
            return RedirectToAction("index");
        }

    
}
}
