using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using BOL;
namespace BLL
{
    public class EmployeeManager
    {
        public static bool Register(Employee emp)
        {
            bool status = false;
            status = EmployeeDAL.Register(emp);
            return status;

        }
        public static List<Employee> GetAllPEmployee()
        {
            List<Employee> Employee = new List<Employee>();
            Employee = EmployeeDAL.GetAll();
            return Employee;
        }
    }
}