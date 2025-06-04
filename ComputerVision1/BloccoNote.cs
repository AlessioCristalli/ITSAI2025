using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVision1
{
    public partial class BloccoNote : Form
    {
        public BloccoNote()
        {
            InitializeComponent();
        }
        private void BtnNuovo_Click(object sender, EventArgs e)
        {
            var conferma = MessageBox.Show("Vuoi creare un nuovo file?", "Nuovo File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conferma == DialogResult.Yes)
            {
                new BloccoNote().Show();
            }
            else
            {
                MessageBox.Show("Operazione annullata.", "Esito operazione");
            }
        }
        private void BtnApri_Click(object sender, EventArgs e)
        {
            DlgApri.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
            if (DlgApri.ShowDialog() == DialogResult.OK && DlgApri.FileName.EndsWith(".txt"))
            {
                MessageBox.Show($"Hai aperto il file {DlgApri.FileName}!", "Apertura File", MessageBoxButtons.OK);
                textBox.Text = File.ReadAllText(DlgApri.FileName);
            }
            else
            {
                MessageBox.Show("Il file può essere solo con estensione *.txt", "Ops... qualcosa è andato storto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSalva_Click(object sender, EventArgs e)
        {
            DlgSalva.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
            if (DlgSalva.ShowDialog() == DialogResult.OK && DlgSalva.FileName.EndsWith(".txt"))
            {
                MessageBox.Show($"Hai salvato il file {DlgSalva.FileName}!", "Salvataggio File", MessageBoxButtons.OK);
                File.WriteAllText(DlgSalva.FileName, textBox.Text);
                textBox.Clear();
            }
        }
        private void BtnPulisci_Click(object sender, EventArgs e)
        {
            var conferma = MessageBox.Show("Vuoi pulire il contenuto del Blocco note?", "Pulisci Testo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conferma == DialogResult.Yes)
            {
                textBox.Clear();
            }
            else
            {
                MessageBox.Show("Operazione annullata.", "Esito operazione");
            }
        }
        private void BloccoNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                return; // Non c'è testo da salvare, quindi non chiedere conferma.
            }
            else
            {
                var conferma = MessageBox.Show("Hai delle modifiche in sospeso, se non salvi andranno perse! vuoi salvare?", "Chiusura blocco note", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (conferma == DialogResult.Yes)
                {
                    DlgSalva.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
                    if (DlgSalva.ShowDialog() == DialogResult.OK && DlgSalva.FileName.EndsWith(".txt")) // Il file è sempre con estensione .txt quindi la condizione puo essere anche tolta.
                    {
                        MessageBox.Show($"Hai salvato il file {DlgSalva.FileName}!", "Salvataggio File", MessageBoxButtons.OK);
                        File.WriteAllText(DlgSalva.FileName, textBox.Text);
                    }
                }
                else if (conferma == DialogResult.Cancel)
                {
                    e.Cancel = true; // Annulla la chiusura del form.
                }
            } // Se l'utente clicca su No, il form si chiude senza salvare.
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            DlgFont.ShowColor = true; // Permette di scegliere anche il colore del testo.
            DlgFont.Font = textBox.Font; // Imposta il font corrente del TextBox nel dialogo.
            DlgFont.ShowApply = true;
            if (DlgFont.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = DlgFont.Font; // Applica il font selezionato al TextBox.
                textBox.ForeColor = DlgFont.Color; // Applica il colore selezionato al TextBox.
            }
        }
    }
}
