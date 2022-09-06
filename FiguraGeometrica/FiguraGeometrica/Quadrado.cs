using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
    public class Quadrado : IFiguraGeometrica
    {

        public double CalcularArea { get 
            {
                Resultado = 4 * 4 / 2;

                return Resultado;
            }  }
        public int NumeroTotaldeLados { get; set; } = 4;
        public int ComprimentodosLados { get; set; } = 4;
        public double Perimetro { get {

                Perimetro = ComprimentodosLados * NumeroTotaldeLados;

                return Perimetro;

            } set { }
        }
        public double Resultado { get; set; }

    }
}
