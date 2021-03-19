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
            MembreViewModel mvm = new MembreViewModel();
            if (!Infra.SessionUtils.IsLogged) return RedirectToAction("Login", "Account", new { area = "" });

            return View(mvm);
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Biens()
        {
            Session.Abandon();

            return View();
        }
    }
}