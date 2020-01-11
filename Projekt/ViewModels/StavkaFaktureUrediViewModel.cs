using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.ViewModels
{
    public class StavkaFaktureUrediViewModel
    {
        public int StavkaFaktureId { get; set; }
        public DateTime Datum { get; set; }
        public List<SelectListItem> Faktura { get; set; }
        public int FakturaID { get; set; }
        public List<SelectListItem> Proizvod { get; set; }
        public int ProizvodId { get; set; }
        public float Kolicina { get; set; }
    }
}
