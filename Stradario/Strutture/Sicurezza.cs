using System.ComponentModel.DataAnnotations;

namespace Stradario.Strutture
{
    public class Sicurezza
    {
        [Required]
        public DateTime Creazione { get; set; } = DateTime.Now;
        public DateTime? UltimaModifica { get; set; }
    }
}
