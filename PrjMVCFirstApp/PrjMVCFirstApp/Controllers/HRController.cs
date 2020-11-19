using PrjMVCFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrjMVCFirstApp.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
       
        public ActionResult DisplayEmployee()
        {
            Employee emp = new Employee();
            emp.id = 101;
            emp.name = "Arul";
            emp.age = 23;
            return View(emp);
        }
        public ActionResult DisplayEmployeeList()
        {
            List<Employee> e = new List<Employee>();
            e.Add(new Employee { id = 1001, name = "Arul", age = 23 });
            e.Add(new Employee { id = 1002, name = "selvan", age = 24 });
            e.Add(new Employee { id = 1003, name = "Ramya", age = 26 });
            return View(e);
        }
        public ActionResult Index()
        {
            List<Department> d = new List<Department>();
            d.Add(new Department { id = 501, Dname = "CSE" });
            d.Add(new Department { id = 502, Dname = "IT" });
            d.Add(new Department { id = 503, Dname = "Admin" });
            d.Add(new Department { id = 504, Dname = "HR" });
            d.Add(new Department { id = 505, Dname = "Mech" });

            return View("ListDepartmentdetails", d);
        }
        public ActionResult ListDepartmentdetails(Department department)
        {
            return View(department);
        }
        public ActionResult CallContact()
        {
            return View("~/Views/Home/Contact.cshtml");
        }
        public ActionResult ReMethod()
        {
            return RedirectToAction("SecondMethod", "Demo");
        }
        public ActionResult Rules()
        {
            List<string> rule = new List<string>()
            { "Avoid T-shirt", "Carry your Id card"};
            //both viewbag and view data is used to transfer data from controller to view
            //viewbag-dynamic property
            ViewBag.getrules = rule;
            string Name = "Arulselvan";
            ViewBag.Name = Name;
            ViewData["Name"] = Name;

            ViewData["follow"] = rule;
            return View();
        }
        public ActionResult Tempdatafrom()
        {
            List<string> L = TempData["Emp"] as List<string>;
            return View(L);
        }
    }
}