using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerVision1.Strutture;

namespace ComputerVision1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void BtnApri_Click(object sender, EventArgs e)
        {
            if (DlgApri.ShowDialog() == DialogResult.OK)
            {
                pctPreview.Image = Image.FromFile(DlgApri.FileName);
            }
        }

        private void BtnAnalizza_Click(object sender, EventArgs e)
        {
            pctPreview.Image = Image.FromFile(DlgApri.FileName);
            Bitmap immagine = (Bitmap)pctPreview.Image;
            Bitmap filtrata = analizza(immagine);
            pctPreview.Image = filtrata;
        }

        private Bitmap analizza(Bitmap immagine)
        {
            Bitmap output = new Bitmap(immagine.Width, immagine.Height);
            for (int x = 0; x < immagine.Width; x++)
            {
                for (int y = 0; y < immagine.Height; y++)
                {
                    Color pixel = immagine.GetPixel(x, y);

                    float hue = pixel.GetHue();
                    float luminosita = pixel.GetBrightness();
                    if (hue >= trkHueMin.Value && hue <= trkHueMax.Value && luminosita <= trkluminosita.Value)
                    {
                        output.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        output.SetPixel(x, y, Color.Black);
                    }
                }
            }
            output.Save("output.jpg", ImageFormat.Jpeg);
            return output;
        }

        private void trkluminosita_Scroll(object sender, EventArgs e)
        {
            labelLuminosita.Text = $"Luminosità: {trkluminosita.Value}";
        }

        private void trkHueMin_Scroll(object sender, EventArgs e)
        {
            labelHueMin.Text = $"Hue Min: {trkHueMin.Value}";
        }

        private void trkHueMax_Scroll(object sender, EventArgs e)
        {
            labelHueMax.Text = $"Hue Max: {trkHueMax.Value}";
        }

        private void BtnResetta_Click(object sender, EventArgs e)
        {
            pctPreview.Image = Image.FromFile(DlgApri.FileName);
        }
    }
}
