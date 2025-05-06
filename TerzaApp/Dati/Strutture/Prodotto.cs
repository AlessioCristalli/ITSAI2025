namespace TerzaApp.Dati.Strutture
{
    public class Prodotto
    {
        public int IDprodotto { get; set; } = 0;
        public string Nome { get; set; } = "";
        public string Descrizione { get; set; } = "";
        public decimal Prezzo { get; set; } = 0;
        public int IDcategoria { get; set; } = 0;
        public int IDcollezione { get; set; } = 0;
        public string Currency => $"{this.Prezzo:C2}";
        public override string ToString()
        {
            return Nome;
        }
    }
}