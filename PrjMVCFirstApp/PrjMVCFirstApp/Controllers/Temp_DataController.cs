using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrjMVCFirstApp.Controllers
{
    public class Temp_DataController : Controller
    {
        // GET: Temp_Data
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FirstRequest()
        {
            List<string> TempDataTest = new List<string>();
            TempDataTest.Add("Arul");
            TempDataTest.Add("Ramya");
            TempDataTest.Add("Selvi");
            TempData["Emp"] = TempDataTest;
            TempData.Keep();
            return View();
        }
        public ActionResult SecondRequest()
        {
            List <string>  n= TempData["Emp"] as List<string>;
            return View(n);
        }
    }
}