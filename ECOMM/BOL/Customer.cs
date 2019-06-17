using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BOL
{

    //public enum Gender
    //{
    //    Male,
    //    Female
    //}

    //public class Customer
    //{
    //    [Required]
    //    public int custid { get; set; }
    //    public String custname { get; set; }
    //    public int mobno { get; set; }
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Email { get; set; }
    //    public string ContactNumber { get; set; }
    //    public string City { get; set; }

    //    public string Gender { get; set; }
    //    public Gender CustomerGender { get; set; }

    //    public int Age { get; set; }

    //    public bool isNewlyJoined { get; set; }
    //    public string username { get; set; }
    //    public string password { get; set; }

    //}
    public class Customer
    {
        public int Id { get; set; }

        [DisplayName("Full Name")]
        public string Name { get; set; }



        public string Email { get; set; }

        [DisplayName("Registration Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }
        public string Membership { get; set; }
        public string Location { get; set; }

        [DisplayName("Most Valueable Customer")]
        public bool isMVC { get; set; }

    }
}