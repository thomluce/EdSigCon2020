using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EdSigConNEW.Controllers
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

        public ActionResult Covid19()
        {
            return View();
        }
        public ActionResult GitHub()
        {
            return View();
        }

        public ActionResult EdSigCon()
        {
            // this is a comment added in the branch at the samem place as the comment in the master
            return View();
        }
    }
}