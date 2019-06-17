using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BOL
{
    public class Staff
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(18, 56)]
        public int Age { get; set; }
     
    }
}