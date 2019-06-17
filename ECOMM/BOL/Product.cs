using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace BOL
{
    public class Product
    {
        [Required]
        public int ID { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        [Range(10, 25)]
        public int UnitPrice { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public int Likes { get; set; }
    }
}