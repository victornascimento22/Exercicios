using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
   public class Hexagono : IFiguraGeometrica
    {
        public double CalcularArea { get;  }
        public int NumeroTotaldeLados { get; set; } = 6;
        public int ComprimentodosLados { get; set; }

        public double Perimetro { get; }

    }
}
