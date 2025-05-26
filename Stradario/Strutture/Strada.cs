using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Stradario.Strutture
{
    [Table("Strade")]
    public class Strada
    {
        [Key]
        public uint IDstrada { get; set; }
        [Required]
        public Nodo A { get; set; }
        [Required]
        public Nodo B { get; set; }
        public float lunghezza => A.CalcolaDistanza(B);

        public override string ToString()
        {
            return $"{A.Nome} → {B.Nome} : {lunghezza} ";
        }
    }
}
