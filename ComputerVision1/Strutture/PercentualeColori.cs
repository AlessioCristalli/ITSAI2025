using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerVision1.Strutture
{
    public class PercentualeColori
    {
        public int volumeImmagine = 0;
        public int R { get; set; } = 0;
        public int G { get; set; } = 0;
        public int B { get; set; } = 0;

        public double PercR => (double)R / (double)volumeImmagine;
        public double PercG => (double)G / (double)volumeImmagine;
        public double PercB => (double)B / (double)volumeImmagine;

        public PercentualeColori(Size dimensioni) 
        {
            volumeImmagine = dimensioni.Width * dimensioni.Height * 255;
        }
    }
}
