using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin28.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hot Calls Information";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hot Calls Program Contact Information";

            return View();
        }
    }
}