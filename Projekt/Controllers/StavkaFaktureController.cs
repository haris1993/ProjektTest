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
    public class StavkaFaktureController : Controller
    {
        MyContext db = new MyContext();

        public IActionResult DodajForm()
        {
            StavkaFaktureUrediViewModel model = new StavkaFaktureUrediViewModel();

            model.Faktura = db.Faktura.Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text = x.Id.ToString(),
                Value = x.Id.ToString()
            }).ToList();

            model.Proizvod = db.Proizvod.Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text = x.Naziv,
                Value = x.Id.ToString()
            }).ToList();

            model.Datum = DateTime.Now;
            return View(model);
        }

        public IActionResult UrediForm(int StavkaFaktureID)
        {

            StavkaFakture k = db.StavkaFakture.Find(StavkaFaktureID);
            if (k == null)
            {
                TempData["porukaError"] = "Greška pri brisanju";
                return RedirectToAction("Prikazi");
            }

            StavkaFaktureUrediViewModel model = new StavkaFaktureUrediViewModel();

            model.Faktura = db.Faktura.Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text = x.Id.ToString(),
                Value = x.Id.ToString()
            }).ToList();

            model.Proizvod = db.Proizvod.Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text = x.Naziv,
                Value = x.Id.ToString()
            }).ToList();


            return View(model);
        }

        public IActionResult Prikazi(int FakturaId)
        {

            StavkaFakturePrikazViewModel model = new StavkaFakturePrikazViewModel();
            model.FakturaId = FakturaId;
            model.Rows = db.StavkaFakture.Where(k=>k.FakturaId==FakturaId)
            .Select(k => new StavkaFakturePrikazViewModel.Row
            {
                 StavkaFaktureId=k.Id,
                  Datum=k.Datum,
                  Faktura=k.Faktura.Id.ToString(),
                  Proizvod=k.Proizvod.Naziv,
                 Kolicina=k.Kolicina
            }).ToList();




            return View(model);
        }

        public IActionResult Obrisi(int StavkaFaktureID)
        {

            StavkaFakture k = db.StavkaFakture.Find(StavkaFaktureID);
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



        public IActionResult Snimi(StavkaFaktureUrediViewModel input)
        {



            StavkaFakture k;
            if (input.StavkaFaktureId == 0)
            {
                k = new StavkaFakture();
                db.Add(k);
            }
            else
            {
                k = db.StavkaFakture.Find(input.StavkaFaktureId);
            }


            k.Datum = input.Datum;
            k.Kolicina = input.Kolicina;
            k.FakturaId = input.FakturaID;
            k.ProizvodId = input.ProizvodId;

            db.SaveChanges();

            db.Dispose();

            TempData["porukaSucess"] = "Uspješno ste izmjenili proizvod";

            return RedirectToAction("Prikazi");

        }
    }
}