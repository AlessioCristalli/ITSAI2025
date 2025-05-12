namespace TerzaApp.Dati.Strutture
{
    public class Collezione
    {
        public int IDcollezione { get; set; } = 0;
        public string NomeCollezione { get; set; } = "";
        public override string ToString()
        {
            return NomeCollezione;
        }
    }
}
