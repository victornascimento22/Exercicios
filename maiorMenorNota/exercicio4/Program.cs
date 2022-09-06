using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.WriteLine("Insira nota um");

            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira nota dois");

            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira nota tres");

            c = Convert.ToSingle(Console.ReadLine());


            if ((a > b) && (a > c)) {
                Console.WriteLine("A nota 1 é a maior nota =" + a);

            } else if ((b > c) && (b > a)) {
                Console.WriteLine("A nota 2 é a maior nota =" + b);

            } else if ((c > a) && (c > b)) {

                Console.WriteLine("A nota 3 é a maior nota =" + c);
            }

            if ((a < b) && (a < c))
            {
                Console.WriteLine("A nota 1 é a menor nota =" + a);

            }
            else if ((b < c) && (b < a))
            {
                Console.WriteLine("A nota 2 é a menor nota =" + b);

            }
            else if ((c < a) && (c < b))
            {

                Console.WriteLine("A nota 3 é a menor nota =" + c);
            }
        }
    }
}