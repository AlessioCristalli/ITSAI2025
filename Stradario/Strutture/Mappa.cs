
using System.Diagnostics.Contracts;

namespace Stradario.Strutture
{
    public class Mappa
    {
        public List<Nodo> Nodi { get; set; } = new List<Nodo>();
        public List<Arco> Archi { get; set; } = new List<Arco>();

        public Mappa(string percorsoMappa)
        {
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
        }

        public uint CreaNodo(string nome)
        {
            if (Nodi.Any(n => n.Nome == nome))
            {
                return Nodi.First(n => n.Nome == nome).IDnodo;
            }
            else
            {
                uint nuovoId = 1;
                if (Nodi.Count > 0)
                {
                    nuovoId = Nodi.Last().IDnodo + 1;
                }
                Nodi.Add(new Nodo() { IDnodo = nuovoId, Nome = nome });
                return nuovoId;
            }
        }
    }
}
