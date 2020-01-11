using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.EF;
using Projekt.Models;
using Projekt.ViewModels;

namespace Projekt.Controllers
{
    public class ProizvodController : Controller
    {
        MyContext db = new MyContext();

        public IActionResult DodajForm()
        {


            

            return View("UrediForm");
        }

        public IActionResult UrediForm(int ProizvodId)
        {

            Proizvod k = db.Proizvod.Find(ProizvodId);
            if (k == null)
            {
                TempData["porukaError"] = "Greška pri brisanju";
                return RedirectToAction("Prikazi");
            }

            ProizvodUrediViewModel model = new ProizvodUrediViewModel();
            model.ProizvodId = k.Id;
            model.Naziv = k.Naziv;
            model.JedinicaMjere = k.JedinicaMjere;
            model.Cijena = k.Cijena;

            return View(model);
        }


        public IActionResult Prikazi()
        {

            ProizvodPrikaziViewModel model = new ProizvodPrikaziViewModel();
                model.Rows=db.Proizvod
                .Select(k=>new ProizvodPrikaziViewModel.Row
                {
                    ProizvodId=k.Id,
                    Naziv = k.Naziv,
                    JedinicaMjere = k.JedinicaMjere,
                    Cijena = k.Cijena
                }).ToList();



            
            return View(model);
        }

        public IActionResult Obrisi(int ProizvodId)
        {

            Proizvod k = db.Proizvod.Find(ProizvodId);
            if (k == null)
            {
                TempData["porukaError"] = "Greška pri brisanju";

            }
            else
            {
                db.Remove(k);
                db.SaveChanges();
            }
            db.Dispose();
            TempData["porukaSucess"] = "Uspješno ste obrisali proizvod";
            return RedirectToAction("Prikazi");
        }



        public IActionResult Snimi(ProizvodUrediViewModel input)
        {



            Proizvod k;
            if (input.ProizvodId == 0)
            {
                k = new Proizvod();
                db.Add(k);
            }
            else
            {
                k = db.Proizvod.Find(input.ProizvodId);
            }


            k.Naziv = input.Naziv;
            k.JedinicaMjere = input.JedinicaMjere;
            k.Cijena = input.Cijena;
           
            db.SaveChanges();

            db.Dispose();

            TempData["porukaSucess"] = "Uspješno ste izmjenili proizvod";

            return RedirectToAction("Prikazi");

        }
    }
}