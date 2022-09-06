using System;

namespace TresNumerosOrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite valor para A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite valor para B");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite valor para C");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (b > c))
            {

                Console.WriteLine("A ordem crescente dos valores inseridos :" + c + b + a);

            }
            else if ((b > a) && (a > c))
            {

                Console.WriteLine("A ordem crescente dos valores inseridos" + c + a + b);

            }
            else if ((c > a) && (a > b)) {

                Console.WriteLine("A ordem crescente dos valores inseridos" + b + a + c);


            } else if ((a > c) && (c > b)) {

                Console.WriteLine("A ordem crescente dos valores inseridos" + b + c + a);

            } else if ((c > b) && (b > a)){

                Console.WriteLine("A ordem crescente dos valores inseridos" + a + b + c);

            }
        }
    }
}