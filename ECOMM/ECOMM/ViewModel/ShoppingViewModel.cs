using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;

namespace ECOMM.ViewModel
{
    public class ShoppingViewModel
    {
        public List<Product> products { get; set; }
        public string Title { get; set; }

        public List<Customer> customers { get; set; }
        public string custname { get; set; }
    }
}