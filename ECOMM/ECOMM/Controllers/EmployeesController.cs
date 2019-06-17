using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;
namespace ECOMM.Controllers
{
    public class EmployeesController : Controller
    {
        //
        // GET: /Employees/


        //public ActionResult Index()
        //{
        //    //retrive data from application variables
        //    List<Customer> customers = (List<Customer>)this.HttpContext.Application["catlog1"];


        //    return View(customers);
        //}
        //public ActionResult Index()
        //{
        //    Employee empl = this.Session["empname"] as Employee;
        //    return View(empl);
        //}
        //[HttpGet]
        //public ActionResult Register(int id)
        //{
        //    Customer thecust = new Customer { custid = id };
        //   return View(thecust);
        //}
        //[HttpPost]
        //public ActionResult Register(Customer thecust)
        //{
        //    Employee empl = this.Session["empname"] as Employee;

        //    empl.Register(thecust);
        //    return RedirectToAction("index");
        //}
        List<Employee> employees = new List<Employee>();

        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult register1(Employee emp)
        {

            if (EmployeeManager.Register(emp))
            {

            }
            List<Employee> employees = EmployeeManager.GetAllPEmployee();

            return View(employees);
        }
        //}
        //public ActionResult Index()
        //{
        //    //List<Product> products = (List<Product>)this.HttpContext.Application["catalog"];
        //    List<Employee> employees = EmployeeManager.GetAllPEmployee();
        //    return View(employees);
        //}

        [ActionName("find")]
        public ActionResult GetById(int id)
        {
            // get student from the database 
            return View();
        }


        [NonAction]
        public Employee GetStudent(int id)
        {
            return employees.Where(e => e.Id == id).FirstOrDefault();
        }


        [HttpPost]
        public ActionResult PostAction(dynamic d)
        {
            return View("Index");
        }


        [HttpPut]
        public ActionResult PutAction()
        {
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteAction()
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction()
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction()
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction()
        {
            return View("Index");
        }

    }
}
