using System;

namespace exercicio_coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, y1, x2, y2;
            float d;

            Console.WriteLine("Insira o primeiro ponto de coordenada");
            x1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o segundo ponto de coordenada ");
            y1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o terceiro ponto de coordenada");
            x2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o quarto ponto de coordenada ");
            y2 = Convert.ToSingle(Console.ReadLine());

            d = (float)Math.Sqrt(((x1 - y1) * (x1 - y1)) + ((x2 - y2) * (x2 - y2)));
            

            Console.WriteLine("a distancia entre um ponto e outro é de " + d);

        }
    }
}
