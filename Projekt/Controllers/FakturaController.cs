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
    public class FakturaController : Controller
    {
        MyContext db = new MyContext();

        public IActionResult DodajForm()
        {
            FakturaUrediViewModel model = new FakturaUrediViewModel();

            model.Kupac = db.Kupac.Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text = x.Naziv,
                Value = x.Id.ToString()
            }).ToList();

            model.Datum = DateTime.Now;
            return View(model);
        }

        public IActionResult UrediForm(int FakturaId)
        {

            Faktura k = db.Faktura.Find(FakturaId);
            if (k == null)
            {
                TempData["porukaError"] = "Greška pri brisanju";
                return RedirectToAction("Prikazi");
            }

            FakturaUrediViewModel model = new FakturaUrediViewModel();
            model.Kupac = db.Kupac.Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text=x.Naziv,
                Value=x.Id.ToString()
            }).ToList();

            return View( model);
        }

        public IActionResult Prikazi()
        {

            FakturaPrikazViewModel model = new FakturaPrikazViewModel();
            model.Rows = db.Faktura
            .Select(k => new FakturaPrikazViewModel.Row
            {
                FakturaId=k.Id,
                Datum=k.Datum,
                 Iznos=k.Iznos,
                  Kupac=k.Kupac.Naziv
            }).ToList();




            return View(model);
        }

        public IActionResult Obrisi(int FakturaId)
        {

            Faktura k = db.Faktura.Find(FakturaId);
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
            TempData["porukaSucess"] = "Uspješno ste obrisali fakturu";
            return RedirectToAction("Prikazi");
        }



        public IActionResult Snimi(FakturaUrediViewModel input)
        {



            Faktura k;
            if (input.FakturaId == 0)
            {
                k = new Faktura();
                db.Add(k);
            }
            else
            {
                k = db.Faktura.Find(input.FakturaId);
            }


            k.Datum = input.Datum;
            k.Iznos = input.Iznos;
            k.KupacId = input.KupacId;

            db.SaveChanges();

            db.Dispose();

            TempData["porukaSucess"] = "Uspješno ste izmjenili proizvod";

            return RedirectToAction("Prikazi");

        }
    }
}