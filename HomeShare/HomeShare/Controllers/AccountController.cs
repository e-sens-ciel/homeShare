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
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {
                MembreModel mm = uow.UserAuth(lm);
                if (mm == null)
                {
                    ViewBag.Error = "Erreur Login/Password";
                    return View();
                }
                else
                {
                    SessionUtils.IsLogged = true;
                    SessionUtils.ConnectedUser = mm;
                    return RedirectToAction("Index", "Home", new { area = "Membre" });

                }
            }
            else
            {
                return View();
            }
        }


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