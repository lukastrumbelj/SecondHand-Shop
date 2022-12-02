using SecondHand.Controllers.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace SecondHand.Models
{
    public class Oblacila
    {
        [Key]
        public int Id { get; set; }
        public string ImeOblacila { get; set; }
        public string SlikaOblekeUrl { get; set; }
        public string opis { get; set; }
        public KategorijaOblacil KategorijaOblacil { get; set; }
     }
}
