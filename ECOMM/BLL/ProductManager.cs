using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
   public static class ProductManager
    {
        public static List<Product> GetAllProduct()
        {
            List<Product> Product = new List<Product>();
            Product=ProductDAL.GetAll();
            return Product;
        }
    }
}
