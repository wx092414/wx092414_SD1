using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wx092414_SD1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Wen Xu.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information for Wen Xu.";

            return View();
        }
    }
}