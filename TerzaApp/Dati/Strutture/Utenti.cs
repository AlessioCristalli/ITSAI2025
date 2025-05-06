namespace TerzaApp.Dati.Strutture
{
    public class Utente
    {
        public int IDutente = 0;
        public string Nome { get; set; } = "";
        public string Cognome { get; set; } = "";
        public int Eta { get; set; } = 0;
        public string Email { get; set; } = "";
        public string Indirizzo { get; set; } = "";
        public override string ToString()
        {
            return Nome;
        }
    }
}
