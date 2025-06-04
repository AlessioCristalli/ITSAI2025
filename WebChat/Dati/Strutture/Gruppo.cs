using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebChat.Dati.Strutture
{
    [Table("Gruppi")]
    public class Gruppo
    {
        [Key]
        public int IDgruppo { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public List<Utente> Membri { get; set; } = new List<Utente>();
        public List<Messaggio> Messaggi { get; set; } = new List<Messaggio>();
        public DateTime Creazione { get; set; } = DateTime.Now;
    }
}
