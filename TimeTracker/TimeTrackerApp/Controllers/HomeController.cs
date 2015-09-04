using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "TimeTracker is a simple web application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please use the following contacts to get in touch with the application development team.";

            return View();
        }
    }
}