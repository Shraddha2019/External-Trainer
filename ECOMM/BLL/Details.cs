using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    namespace Details
    {
        public partial class Employee
        {
            public string Name { get; set; }
            public int age { get; set; }
            public string City { get; set; }
        }
        public partial class Employee
        {
            public List<Employee> Employees { get; set; }
        }


        public partial class Order
        {
          
            public int quantity { get; set; }
            public int price { get; set; }
        }

        public partial class Order
        {
            public List<Order> orders { get; set; }
        }

            public class listdetails
            {

                public List<Order> orders = new List<Order>();
                public List<Employee> employees = new List<Employee>();
                public listdetails()
                {
                    orders = FillOrders();
                    employees = FillEmployees();
                }
                private List<Employee> FillEmployees()
                {
                    employees.Add(new Employee() { Name = "Nitin Patil", age = 28, City = "baramati" });
                    employees.Add(new Employee() { Name = "Shraddha parkale", age = 27, City = "mumbai" });
                    employees.Add(new Employee() { Name = "Shiv shastri", age = 23, City = "akola" });
                    employees.Add(new Employee() { Name = "vaishnavi Patil", age = 28, City = "latur" });
                    return employees;
                }
                private List<Order> FillOrders()
                {
                    orders.Add(new Order() { quantity = 12, price = 25});
                    orders.Add(new Order() { quantity = 13, price = 35 });
                    orders.Add(new Order() { quantity = 14, price = 45 });
                    orders.Add(new Order() { quantity = 15, price = 55 });
                    orders.Add(new Order() { quantity = 16, price = 65 });
                    return orders;
                }

        }
    }
}