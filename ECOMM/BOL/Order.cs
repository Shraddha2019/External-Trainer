using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BOL
{
    public class Order
    {
        [Required]
        public int orderid { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
    }
}