using HomeShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeShare.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            RegisterViewModel rvm = new RegisterViewModel();
            return View(rvm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Agents()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BlogDetail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Buysalarent()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Propertydetail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}