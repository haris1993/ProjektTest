using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.ViewModels
{
    public class StavkaFakturePrikazViewModel
    {
        public int FakturaId { get; set; }
        public List<Row> Rows { get; set; }
        public class Row
        {
            public int StavkaFaktureId { get; set; }
            public DateTime Datum { get; set; }
            public string Proizvod { get; set; }
            public string Faktura { get; set; }
            public float Kolicina { get; set; }
        }
    }
}
