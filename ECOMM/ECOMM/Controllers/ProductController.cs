using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;
namespace ECOMM.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            //retrive data from application variables
            //List<Product> products = (List<Product>)this.HttpContext.Application["catalog"];
            List<Product> products = ProductManager.GetAllProduct();
            return View(products);

         
        }
        public ActionResult Details(int id)
        {
            Product foundProduct = null;
           // List<Product> products = (List<Product>)this.HttpContext.Application["catalog"];
            List<Product> products = ProductManager.GetAllProduct();
            //foreach (Product product in products)
            //{
            //    if (product.ID == id)
            //    {
            //        foundProduct = product;
            //    }
            //}
            //return View(foundProduct);
            foreach (Product product in products)
            {
                if (product.ID == id)
                {
                    foundProduct = product;
                }
            }
            return View(foundProduct);
        }

        [Route("{productId:int}/{productTitle}")]
        public ActionResult Show(int productId)
        {
            return View();
        }

        // eg: /flowers
        // eg: /flowers/1430210079
        [Route("flowers/{isbn ?}")]
        public ActionResult Show(string isbn)
        {
            if (!String.IsNullOrEmpty(isbn))
            {
                return View("OneFlower", GetProduct(isbn));
            }
            return View("Allflowers", GetProducts());
        }


        List<Product> GetProduct(string isbn)
        {
            return null;

        }

        List<Product> GetProducts()
        {
            List<Product> products = (List<Product>)this.HttpContext.Application["catalog"];
            return products;
        }
    }
}
