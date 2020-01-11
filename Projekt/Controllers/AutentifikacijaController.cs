using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.EF;
using Projekt.Models;
using Projekt.ViewModels;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace Projekt.Controllers
{
   
    public class AutentifikacijaController : Controller
    {
        MyContext db = new MyContext();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel ad)
        {
            Admin admin = db.Admin.Where(x => x.Username == ad.Username && x.Password == ad.Password).SingleOrDefault();
            Kupac korisnik = db.Kupac.Where(z => z.Username == ad.Username && z.Password == ad.Password).SingleOrDefault();
            if (admin != null)
            {

                HttpContext.Session.SetString("Password", admin.Password);
                return RedirectToAction("Index", "Home");
            }
            if (korisnik != null)
            {
                HttpContext.Session.SetString("Password", korisnik.Password);
                return RedirectToAction("Prikazi", "Proizvod");
            }
            else
            {
                ViewBag.error = "Pogrešan username ili password";
            }
            return View();
        }

        public ActionResult Odjava()
        {
            HttpContext.Session.Remove("username");

            return RedirectToAction("Početna", "Korisnik");
        }
    }
}