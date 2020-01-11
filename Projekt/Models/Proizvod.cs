using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Proizvod
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string JedinicaMjere { get; set; }
        public float Cijena { get; set; }

        public override string ToString()
        {
            return " |" + Naziv + " | " + Cijena + "  " + JedinicaMjere + " | " + Cijena + " KM";
        }
    }
}
