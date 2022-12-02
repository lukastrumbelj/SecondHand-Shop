using SecondHand.Controllers.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace SecondHand.Models
{
    public class Obutev
    {
        [Key]
        public int Id { get; set; }
        public string ImeCevlja { get; set; }
        public string SlikaCevljaUrl { get; set; }
        public double StCevlja { get; set; }
        public string opis { get; set; }
        public string znamka { get; set; }

        public KategorijaObutev KategorijaObutev { get; set; }
    }
}
