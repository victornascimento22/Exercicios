using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
   public class Pentagono : IFiguraGeometrica
    {

        public double CalcularArea { get
         
            {
                var metadeLado = ComprimentodosLados / 2;
                var altura = metadeLado / constante;
                var areaTriangulo = (metadeLado * altura) / 2;

                return CalcularArea;

            }  }
        public int NumeroTotaldeLados { get; set; } = 5;
        public int ComprimentodosLados { get; set; } = 5;
        public double Perimetro { 
            
            get 
            
            {
                Perimetro = ComprimentodosLados * NumeroTotaldeLados;

                return Perimetro;


            }   set { }  }

        public double Resultado { get; set; }

        double constante = 0.726542528;
    }
}
