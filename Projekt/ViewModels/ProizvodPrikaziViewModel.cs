using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.ViewModels
{
    public class ProizvodPrikaziViewModel
    {
        public List<Row> Rows { get; set; }
        public class Row
        {
            public int ProizvodId { get; set; }
            public string Naziv { get; set; }
            public string JedinicaMjere { get; set; }
            public float Cijena { get; set; }
        }
    }
}
