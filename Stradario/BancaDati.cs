using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using Stradario.Strutture;

namespace Stradario
{
    public class BancaDati : DbContext
    {
        public DbSet<Nodo> Nodi { get; set; }
        public DbSet<Arco> Archi { get; set; }
        public DbSet<Strada> Strade { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mappa.sqlite");
            base.OnConfiguring(optionsBuilder);
        }

        public void TrovaPercorso(Nodo inizio, Nodo fine, List<Nodo> percorso, Nodo[] giaVisti) 
        {
            // 1) valutazione di uscita o fallimento.
            // 1.a) sono arrivato
            if(inizio == fine)
            {
                percorso.AddRange(giaVisti);
                return;
            }
            // 1.b) sono arrivato secondo => deve essere lo stesso per tutti.
            if (percorso.Count > 0)
            {
                return;
            }
            // 1.c non ho più strade percorribili => ricordarmi dove sono passato, è un informazione solo mia.
            uint[] prossimi = Archi.Where(x => x.A == inizio.IDnodo).Select(x => x.B).ToArray();
            List<Nodo> buoni = new List<Nodo>();
            foreach (uint potenziale in prossimi) 
            {
                if (!giaVisti.Any(x => x.IDnodo == potenziale)) 
                {
                    buoni.Add(Nodi.First(x => x.IDnodo == potenziale));
                }
            }
            if (buoni.Count == 0)
            {
                return;
            }
            // 2) mi sposto alla casella successiva.
            Dictionary<Nodo, float> distanze = new Dictionary<Nodo, float>();
            foreach(Nodo inAnalisi in buoni)
            {
                distanze.Add(inAnalisi, inAnalisi.CalcolaDistanza(fine));
            }
            distanze = distanze.OrderBy(x => x.Value).ToDictionary();
            // 3) attivando i miei successori per prossimita al target
            foreach (KeyValuePair<Nodo, float> voce in distanze) 
            {
                TrovaPercorso(voce.Key, fine, percorso, giaVisti.Append(inizio).ToArray());
            }
        }

        public bool Importa(string percorsoMappa)
        {
            try {
                Nodi.RemoveRange(Nodi);
                Archi.RemoveRange(Archi);
                SaveChanges();
                string buffer = File.ReadAllText(percorsoMappa);
                string[] righe = buffer.Split('\n');
                foreach (string riga in righe)
                {
                    string[] celle = riga.Split('\t');
                    uint p1 = CreaNodo(celle[0]);
                    uint p2 = CreaNodo(celle[1]);
                    uint distanza = uint.Parse(celle[2]);
                    if (!Archi.Any(arc => arc.A == p1 && arc.B == p2))
                        Archi.Add(new Arco() { A = p1, B = p2, Distanza = distanza });
                    if (!Archi.Any(arc => arc.A == p2 && arc.B == p1))
                        Archi.Add(new Arco() { A = p2, B = p1, Distanza = distanza });
                }
                foreach (Nodo singolo in Nodi)
                {
                    Nominatim.RecuperaHTTP(singolo);
                }
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public uint CreaNodo(string nome)
        {
            Nodo? precedente = this.Nodi.FirstOrDefault(x => x.Nome == nome);
            if (precedente != null)
                return precedente.IDnodo;
            Nodo nuovo = new Nodo() { Nome = nome };
            this.Nodi.Add(nuovo);
            this.SaveChanges();
            return nuovo.IDnodo;
        }
    }
}
