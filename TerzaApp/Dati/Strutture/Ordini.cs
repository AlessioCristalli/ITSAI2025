namespace TerzaApp.Dati.Strutture
{
    public class Ordine
    {
        public int IDordine { get; set; } = 0;
        public int IDutente { get; set; } = 0;
        public List<RigaOrdine> rigaOrdine { get; set; } = new List<RigaOrdine>();
        public string IndirizzoSpedizione { get; set; } = "";
        public decimal PrezzoTotale { get; set; } = 0;
        public string Currency => $"{this.PrezzoTotale:C2}";
        public decimal calcolaPrezzoTotale()
        {
            decimal totale = 0;
            foreach (RigaOrdine riga in rigaOrdine)
            {
                totale += riga.PrezzoTotale;
            }
            return totale;
        }
        public override string ToString()
        {
            return IDordine.ToString();
        }

    }
}
