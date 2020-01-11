using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt.EF;
using Projekt.Models;
using Projekt.ViewModels;

namespace Projekt.Controllers
{
    public class KupacController : Controller
    {
        MyContext db = new MyContext();

        public IActionResult DodajForm()
        {


            KupacUrediViewModel model = new KupacUrediViewModel();
            model.OpstinaStavke = db.Opstina.Select(z => new SelectListItem(z.Naziv, z.Id.ToString())).ToList();


            return View("UrediForm", model);
        }

        public IActionResult UrediForm(int KupacId)
        {

            Kupac k = db.Kupac.Where(x=>x.Id==KupacId).SingleOrDefault();
            if (k == null)
            {
                TempData["porukaError"] = "Greška pri brisanju";
                return RedirectToAction("Prikazi");
            }

            KupacUrediViewModel model = new KupacUrediViewModel();
            model.OpstinaStavke = db.Opstina.Select(z => new SelectListItem(z.Naziv, z.Id.ToString())).ToList();
            model.OpstinaRodjenjaId = k.OpstinaRodjenjaId;
            model.OpstinaPrebivalistaId = k.OpstinaPrebivalistaId;
            model.KupacId = k.Id;
            
            model.PDVBroj = k.PDVBroj;
            model.Adresa = k.Adresa;
            model.Naziv = k.Naziv;

            return View( model);
        }


        public IActionResult Prikazi()
        {
            


            List<NekiDrugiNaziv> podatak1 = db.Kupac

                                .Select(k => new NekiDrugiNaziv
                                {
                                    Naziv = k.Naziv,
                                    Adresa = k.Adresa,
                                    KupacId = k.Id,
                                    PdvBroj = k.PDVBroj,
                                    OpstinaPrebivalista = k.OpstinaPrebivalista.Naziv,
                                    BrojFaktura = db.Faktura.Where(q => q.KupacId == k.Id).Count(),
                                    SumaFaktura = db.Faktura.Where(q => q.KupacId == k.Id).Sum(s => (double?)s.Iznos)
                                })
                                .ToList();



            KupacPrikaziViewModel model = new KupacPrikaziViewModel();
            model.podaciZaHTMLTabelu = podatak1;
            model.brojNeplacenihFaktura = db.Faktura.Count(s => s.Iznos > 50);


            db.Dispose();
            return View("Prikazi", model);
        }

        public IActionResult Obrisi(int? KupacId)
        {

            Kupac k = db.Kupac.Where(x=>x.Id==KupacId).SingleOrDefault();
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
            TempData["porukaSucess"] = "Uspješno ste obrisali kupca";
            return RedirectToAction("Prikazi");
        }



        public IActionResult Snimi(KupacUrediViewModel input)
        {



            Kupac k;
            if (input.KupacId == 0)
            {
                k = new Kupac();
                db.Add(k);
            }
            else
            {
                k = db.Kupac.Find(input.KupacId);
            }


            k.Naziv = input.Naziv;
            k.Adresa = input.Adresa;
            k.PDVBroj = input.PDVBroj;
            k.OpstinaRodjenjaId = input.OpstinaRodjenjaId;
            k.OpstinaPrebivalistaId = input.OpstinaPrebivalistaId;

            db.SaveChanges();

            db.Dispose();

            TempData["porukaSucess"] = "Uspješno ste izmjenili kupca";

            return RedirectToAction("Prikazi");

        }
    }
}