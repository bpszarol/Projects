using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Project1()
        {
            ViewBag.Message = "This is a simple introduction to using knockout using input fields and ko.computed functions to check for input and modify existing text elements";
            return View();
        }

        public ActionResult Project2()
        {
            ViewBag.Message = "This is a simple introduction to other method of data input, as well as using ko.computed functions to perform mathematical operations on input";
            return View();
        }

        public ActionResult Project3()
        {
            ViewBag.Message = "This is a simple introduction to observable arrays that can be bound by specific rules.";
            return View();
        }

        public ActionResult Project4()
        {
            ViewBag.Message = "This is an introduction to using JSON and YQL to get current news headlines and dislpay them in a scrollable box.";
            return View();
        }

        public ActionResult Project5()
        {
            ViewBag.Message = "This is SPARTA.";
            return View();
        }
    }
}