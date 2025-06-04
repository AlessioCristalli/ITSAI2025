using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebChat.Dati.Strutture
{
    [Table("Utenti")]
    public class Utente
    {
        [Key]
        public uint IDutente { get; set; }
        public List<Messaggio> Ricevuti { get; set; }
        public List<Messaggio> Inviati { get; set; }
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
