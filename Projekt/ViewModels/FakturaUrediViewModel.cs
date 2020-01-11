using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.ViewModels
{
    public class FakturaUrediViewModel
    {

        public int FakturaId { get; set; }
        public DateTime Datum { get; set; }
        public List<SelectListItem> Kupac { get; set; }
        public int KupacId { get; set; }
        public double Iznos { get; set; }
    }
}
