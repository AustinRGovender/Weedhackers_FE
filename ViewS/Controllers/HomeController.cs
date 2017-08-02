using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndustrialCleaning()
        {
            return View();
        }
        public ActionResult PestWeedControl()
        {
            return View();
        }
        public ActionResult WasteManagement()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}