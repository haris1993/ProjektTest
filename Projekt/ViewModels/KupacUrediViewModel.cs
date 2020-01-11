using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.ViewModels
{
    public class KupacUrediViewModel
    {
        public int KupacId { get; set; }
        public string Adresa { get; set; }
        public string Naziv { get; set; }
        public string PDVBroj { get; set; }
        public int OpstinaRodjenjaId { get; set; }
        public int OpstinaPrebivalistaId { get; set; }
        public List<SelectListItem> OpstinaStavke { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
