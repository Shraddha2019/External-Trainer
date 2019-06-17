using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOL;
namespace BLL
{
    public class listdetails
    {
        List<Employee> employees = new List<Employee>();
        public static List<Employee> GetAllEmployees()
        {

            List<Employee> employees = new List<Employee>();
            //employees.Add(new Employee { Id = 1, FirstName = "Manoj", LastName = "Tambade", City = "Nagpur", ContactNumber = "9881735806", Email = "manoj.tambade@transflower.in" });
            //employees.Add(new Employee { Id = 1, FirstName = "Manisha", LastName = "Jadhav", City = "Delhi", ContactNumber = "9881735861", Email = "manisha.jadhav@transflower.in" });
            //employees.Add(new Employee { Id = 2, FirstName = "Ravi", LastName = "Pant", City = "Mumbai", ContactNumber = "9881735441", Email = "ravi.pant@transflower.in" });
            //employees.Add(new Employee { Id = 3, FirstName = "Rajiv", LastName = "Gore", City = "Mumbai", ContactNumber = "9881735856", Email = "rajiv.gore@transflower.in" });
            //employees.Add(new Employee { Id = 4, FirstName = "Gokul", LastName = "Varma", City = "Kanpur", ContactNumber = "9881735236", Email = "gokul.varma@transflower.in" });
            //employees.Add(new Employee { Id = 5, FirstName = "sheetal", LastName = "Kulkarni", City = "Nashik", ContactNumber = "9881735765", Email = "sheetal.kulkarni@transflower.in" });
            //employees.Add(new Employee { Id = 6, FirstName = "Amarn", LastName = "Sharma", City = "Delhi", ContactNumber = "9881733761", Email = "amar.sharma@transflower.in" });
            //employees.Add(new Employee { Id = 7, FirstName = "Sarang", LastName = "Agarwal", City = "Pune", ContactNumber = "9881735871", Email = "sarang.Agarwal@transflower.in" });
            return employees;
        }
        public static Employee GetEmployee(int id)
        {
            return new Employee
            {
                Id = 2,
                FirstName = "Ravi",
                LastName = "Pant",
                City = "Mumbai",
               // ContactNumber = 9881735441,
                Email = "ravi.pant@transflower.in"
            };
        }

    }
}