using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeShare.Areas.Membre.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            //ViewBag.ZoneMembre = "active";
            if (!Infra.SessionUtils.IsLogged) return RedirectToAction("Login", "Account", new { area = "" });

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}