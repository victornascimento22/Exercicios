using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
    public interface IFiguraGeometrica
    {
        double CalcularArea { get; }
        int NumeroTotaldeLados { get; set; }
        int ComprimentodosLados { get; set; }

        double Perimetro { get;  }


    }
}
