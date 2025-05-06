namespace TerzaApp.Dati.Strutture
{
    public class Ordine
    {
        public int IDordine { get; set; } = 0;
        public int IDutente { get; set; } = 0;
        public List<RigaOrdine> rigaOrdine { get; set; } = new List<RigaOrdine>();
        public string IndirizzoSpedizione { get; set; } = "";
        public int PrezzoTotale { get; set; } = 0;
        public override string ToString()
        {
            return IDordine.ToString();
        }

    }
}
