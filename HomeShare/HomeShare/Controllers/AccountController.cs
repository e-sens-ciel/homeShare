using HomeShare.Infra;
using HomeShare.Models;
using HomeShare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeShare.Controllers
{

    public class AccountController : Controller
    {
        UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);



        [HttpGet]
        public ActionResult Register()
        {
            RegisterViewModel rvm = new RegisterViewModel();
            ViewBag.pays = new SelectList(rvm.paysModel, "Id", "Name");
            return View(rvm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(MembreModel mm)
        {
            mm.Pays += 1;

            if (ModelState.IsValid)
            {
                if (uow.CreateUser(mm))
                {
                    SessionUtils.IsLogged = true;
                    SessionUtils.ConnectedUser = mm;
                    //return RedirectToAction("Index", "Home", new { area = "Membre" });
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ViewBag.Error = "Erreur Login/Password";
                    return View("Register");
                }
            }
            else
            {
                ViewBag.Error = "Erreur Login/Password";
                return View("Register");
            }
        }
    }
}