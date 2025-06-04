using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebChat.Dati.Strutture
{
    [Table("Messaggi")]
    public class Messaggio
    {
        [Key]
        public uint IDmessaggio { get; set; }
        public Utente? Mittente { get; set; } = null;
        public Utente? Destinatario { get; set; } = null;
        [Required]
        public string Contenuto { get; set; } = string.Empty;
        [Required]
        public DateTime Invio{ get; set; } = DateTime.Now;

    }
}
