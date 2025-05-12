namespace TerzaApp.Dati.Strutture
{
    public class RigaOrdine
    {
        public int IDrigaOrdine { get; set; } = 0;
        public string Nome { get; set; } = "Il tuo Carrello";
        public int IDprodotto { get; set; } = 0;
        public int Quantità { get; set; } = 0;
        public decimal PrezzoTotale { get; set; } = 0;
        public string Currency => $"{this.PrezzoTotale:C2}";
        public override string ToString()
        {
            return Nome;
        }

    }
}
