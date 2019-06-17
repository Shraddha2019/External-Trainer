using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOL
{

    public enum Gender
    {
        Male,
        Female
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public string City { get; set; }

        public string Gender { get; set; }
        public Gender EmployeeGender { get; set; }

        public int Age { get; set; }

        public bool isNewlyJoined { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    //    private List<Customer> cust=new List<Customer>();
    //    public Employee()
    //    {}
    //    public void Register(Customer thecust)
    //    {cust.Add(thecust);}
    //    public List<Customer> getdetails()
    //    {return cust;}

        public string Name { get; set; }
    }
}