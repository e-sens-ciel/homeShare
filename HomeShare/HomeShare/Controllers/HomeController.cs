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
        public ActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();
            return View(ivm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Recherche(IndexViewModel ivm)
        {
            string bienRechercher = ivm.RequeteRecherche.ToString();
            RechercheViewModel rvm = new RechercheViewModel(bienRechercher);
            return View(rvm);
        }

        [HttpGet]
        public ActionResult BienDetail(int id)
        {
            BienDetailViewModel bdwm = new BienDetailViewModel(id);
            return View(bdwm);
        }
        //public ActionResult Blog()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        //public ActionResult BlogDetail()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        //public ActionResult Buysalarent()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //public ActionResult Propertydetail()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}


    }
}