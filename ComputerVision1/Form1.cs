using System.Drawing.Imaging;
using ComputerVision1.Strutture;

namespace ComputerVision1
{
    public partial class Form1 : Form
    {
        private string[] args;
        public Form1(string[] inIngresso)
        {
            InitializeComponent();
            args = inIngresso;
            BtnCalcola.Text = $"Apri immagine";
        }
        private void BtnCalcola_Click(object sender, EventArgs e)
        {
            if (DlgApri.ShowDialog() == DialogResult.OK)
            {
                PctPreview.Image = Image.FromFile(DlgApri.FileName);
                Bitmap immagine = (Bitmap)PctPreview.Image;
                PercentualeColori colori = Scomponi(immagine);
                txtRisultato.Text += $"Immagine caricata {PctPreview.Size}!\r\n";
                txtRisultato.Text += $"Rosso:\t{colori.PercR}\r\n";
                txtRisultato.Text += $"Verde:\t{colori.PercG}\r\n";
                txtRisultato.Text += $"Blu:\t{colori.PercB} \r\n";
            }
        }
        private PercentualeColori Scomponi(Bitmap immagine)
        {
            Bitmap canaleR = new Bitmap(immagine.Width, immagine.Height);
            Bitmap canaleG = new Bitmap(immagine.Width, immagine.Height);
            Bitmap canaleB = new Bitmap(immagine.Width, immagine.Height);
            PercentualeColori risultato = new PercentualeColori(immagine.Size);
            for (int x = 0; x < immagine.Width; x++)
            {
                for (int y = 0; y < immagine.Height; y++)
                {
                    Color pixel = immagine.GetPixel(x, y);
                    risultato.R += pixel.R;
                    risultato.G += pixel.G;
                    risultato.B += pixel.B;
                    if (pixel.R > trkBar.Value) // Serve per visualizzare i punti dove il colore è superiore alla soglia
                        canaleR.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.R, pixel.R));
                    if (pixel.G > trkBar.Value)
                        canaleG.SetPixel(x, y, Color.FromArgb(pixel.G, pixel.G, pixel.G));
                    if (pixel.B > trkBar.Value)
                        canaleB.SetPixel(x, y, Color.FromArgb(pixel.B, pixel.B, pixel.B));
                }
            } // Quando i pixel risultano neri nelle immagini canaleR, canaleG o canaleB, significa che il valore del canale corrispondente (R, G o B) è inferiore o uguale alla soglia impostata nella TrackBar.
            canaleR.Save("canaleR.jpg", ImageFormat.Jpeg);
            canaleG.Save("canaleG.jpg", ImageFormat.Jpeg);
            canaleB.Save("canaleB.jpg", ImageFormat.Jpeg);

            return risultato;
        }

        private void trkBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"Soglia: {trkBar.Value}";
        }
    }
}
