using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.ViewModels
{
    public class FakturaPrikazViewModel
    {
       public List<Row> Rows { get; set; }
        public class Row
        {
            public int FakturaId { get; set; }
            public DateTime Datum { get; set; }
            public string Kupac { get; set; }
            public double Iznos { get; set; }
        }
    }
}
