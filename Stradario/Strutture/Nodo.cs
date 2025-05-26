using System.ComponentModel.DataAnnotations;

namespace Stradario.Strutture
{
    public class Nodo : Sicurezza
    {
        [Key]
        public uint IDnodo { get; set; }
        [Required]
        public string Nome { get; set; }
        public float X { get; set; } // Longitudine
        public float Y { get; set; } // Latitudine
        public override string ToString()
        {
            return this.Nome;
        }
        public float CalcolaDistanza(Nodo target) 
        {
            float deltaX = this.X - target.X;
            float deltaY = this.Y - target.Y;
            return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
