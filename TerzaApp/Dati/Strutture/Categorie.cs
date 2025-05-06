namespace TerzaApp.Dati.Strutture
{
    public class Categoria
    {
        public int IDcategoria { get; set; } = 0;
        public string Nome { get; set; } = "";
        public string Descrizione { get; set; } = "";
        public DateTime DateTime { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return Nome;
        }
    }
}
