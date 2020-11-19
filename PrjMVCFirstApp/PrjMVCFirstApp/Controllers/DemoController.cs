using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjMVCFirstApp.Models;

namespace PrjMVCFirstApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FirstMethod()
        {
            return View();
        }

        public ViewResult SecondMethod()
        {
            return View();
        }
        public ContentResult Reply()
        {
            //return Content("Good Morning!");
            return Content("<h2>Good Morning!<h2>", "text/html");
        }

        //[NonAction]
        public EmptyResult Addition()
        {
            int a = 100;
            int b = 150;
            int Addition = a + b;
            return new EmptyResult();
        }

        public JsonResult EmpData()
        {
            Employee employee = new Employee();
            employee.id = 101;
            employee.name = "Arul";
            employee.age = 23;
            return Json(employee, JsonRequestBehavior.AllowGet);
        }
    }
}