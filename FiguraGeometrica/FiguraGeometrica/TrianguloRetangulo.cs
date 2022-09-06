using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
    public class TrianguloEquilatero : IFiguraGeometrica
    {
        public double CalcularArea { get 
            {
                Resultado = 3 * 3 / 2;

                return Resultado;
            }  
        }

        public int NumeroTotaldeLados { get; set; } = 3;

        public int ComprimentodosLados { get; set; } = 3;
        public double Perimetro
        {
            get
            {
                Perimetro = ComprimentodosLados * NumeroTotaldeLados;

                return Perimetro;
            }
            set { }
        } 

        public double Resultado { get; set; }
}

        

          

    }

