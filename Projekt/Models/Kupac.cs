using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Kupac
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string PDVBroj { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public int OpstinaRodjenjaId { get; set; }
        [ForeignKey("OpstinaRodjenjaId")]
        public SelectListItems OpstinaRodjenja { get; set; }


        public int OpstinaPrebivalistaId { get; set; }
        [ForeignKey("OpstinaPrebivalistaId")]
        public SelectListItems OpstinaPrebivalista { get; set; }

        public override string ToString()
        {
            return Naziv + " (" + Adresa + ") ";
        }
    }
}
