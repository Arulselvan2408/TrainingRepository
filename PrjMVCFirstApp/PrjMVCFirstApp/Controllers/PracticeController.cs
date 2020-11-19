using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjMVCFirstApp.Models;

namespace PrjMVCFirstApp.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult mymethod()
        {
            Employee e = new Employee();
            e.id = 101;
            e.name = "arul";
            e.age = 23;

            ViewBag.Name = "Arulselvan";
            ViewData["Name"] = "Arulselvan";
            string say = "My name is Arulselvan";

            TempData["say"] = say;
            TempData.Keep();
            return View(e);
            

        }
        public JsonResult j()
        {
            Employee e = new Employee();
            e.id = 101;
            e.name = "arul";
            e.age = 23;
            return Json(e, JsonRequestBehavior.AllowGet);

        }
        
        
    }
}