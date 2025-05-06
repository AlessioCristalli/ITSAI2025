using System.Text.Json;
using TerzaApp.Dati.Strutture;

namespace TerzaApp.Dati
{
    public class Archivio
    {
        public List<Prodotto> prodotti { get; set; } = new List<Prodotto>();
        public List<Categoria> categorie { get; set; } = new List<Categoria>();
        public List<Utente> utenti { get; set; } = new List<Utente>();
        public List<Ordine> ordini { get; set; } = new List<Ordine>();
        public List<RigaOrdine> rigaOrdini { get; set; } = new List<RigaOrdine>();
        public List<Collezione> collezioni { get; set; } = new List<Collezione>();

        public Archivio()
        {

        }

        public void addProdotto(Prodotto singolo)
        {
            foreach(Prodotto registrato in prodotti)
            {
                singolo.IDprodotto = Math.Max(singolo.IDprodotto, registrato.IDprodotto);
            }
            singolo.IDprodotto++;
            prodotti.Add(singolo);
        }

        public void addCategoria(Categoria singola)
        {
            foreach (Categoria registrata in categorie)
            {
                singola.IDcategoria = Math.Max(singola.IDcategoria, registrata.IDcategoria);
            }
            singola.IDcategoria++;
            categorie.Add(singola);
        }

        public void addUtente(Utente singolo)
        {
            foreach (Utente registrato in utenti)
            {
                singolo.IDutente = Math.Max(singolo.IDutente, registrato.IDutente);
            }
            singolo.IDutente++;
            utenti.Add(singolo);
        }

        public void addCollezione(Collezione singola)
        {
            foreach (Collezione registrata in collezioni)
            {
                singola.IDcollezione = Math.Max(singola.IDcollezione, registrata.IDcollezione);
            }
            singola.IDcollezione++;
            collezioni.Add(singola);
        }

        public void addRigaOrdine(RigaOrdine singola)
        {
            foreach (RigaOrdine registrata in rigaOrdini)
            {
                singola.IDrigaOrdine = Math.Max(singola.IDrigaOrdine, registrata.IDrigaOrdine);
            }
            singola.IDrigaOrdine++;
            rigaOrdini.Add(singola);
        }

        public void addOrdine(Ordine singolo)
        {
            foreach (Ordine registrato in ordini)
            {
                singolo.IDordine = Math.Max(singolo.IDordine, registrato.IDordine);
            }
            singolo.IDordine++;
            ordini.Add(singolo);
        }

        public void Recupera()
        {
            if (File.Exists("archivio.json"))
            {
                string json = File.ReadAllText("archivio.json");
                Archivio vecchio = JsonSerializer.Deserialize<Archivio>(json);
                if (vecchio != null)
                {
                    this.prodotti = vecchio.prodotti;
                    this.categorie = vecchio.categorie;
                }
            }
        }

        public void Salva()
        {
            JsonSerializerOptions opzioni = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(this, opzioni);
            File.WriteAllText("archivio.json", json);
        }
    }
}
