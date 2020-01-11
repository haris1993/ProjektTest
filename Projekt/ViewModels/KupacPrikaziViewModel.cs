using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.ViewModels
{
    public class KupacPrikaziViewModel
    {
        public List<NekiDrugiNaziv> podaciZaHTMLTabelu;
        public int brojNeplacenihFaktura;
    }

    public class NekiDrugiNaziv
    {
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string PdvBroj { get; set; }
        public string OpstinaPrebivalista { get; set; }
        public int KupacId { get; set; }
        public int BrojFaktura { get; set; }
        public double? SumaFaktura { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
