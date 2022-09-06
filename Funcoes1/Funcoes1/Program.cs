using System;

namespace Funcoes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int resultado = Soma(a, b);

            Console.WriteLine($"{resultado}");


        }

        static int Soma(int a, int b)
        {




            return a + b;
        }
    }
}

