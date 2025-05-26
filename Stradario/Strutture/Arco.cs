using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stradario.Strutture
{
    /*
     * Create TABLE archi (
     * A int default 0,
     * B int default 0, 
     *  Distanza int default 0,
     *  )
     */
    [Table("archi")]
    public class Arco : Sicurezza
    {
        [Key]
        public uint IDarco { get; set; }
        [Required]
        public uint A { get; set; }
        [Required]
        public uint B { get; set; }
        public uint Distanza { get; set; } = 0;
    }
}
