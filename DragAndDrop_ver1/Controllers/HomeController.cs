using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DragAndDrop_ver1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DnD1()
        {
            return View();
        }

        public ActionResult Layout()
        {
            return View();
        }

        public ActionResult DnD1v2()
        {
            return View();
        }

        public ActionResult gridster()
        {
            return View();
        }

        public ActionResult gridly()
        {
            return View();
        }

        public ActionResult DnD2()
        {
            return View();
        }
        public ActionResult DnD3()
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
    }
}