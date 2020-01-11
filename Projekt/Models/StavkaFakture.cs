using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class StavkaFakture
    {
        [Key]
        public int Id { get; set; }
        public DateTime Datum { get; set; }


        public int FakturaId { get; set; }
        [ForeignKey("FakturaId")]
        public Faktura Faktura { get; set; }


        public int ProizvodId { get; set; }
        [ForeignKey("ProizvodId")]
        public Proizvod Proizvod { get; set; }

        public float Kolicina { get; set; }
    }
}
