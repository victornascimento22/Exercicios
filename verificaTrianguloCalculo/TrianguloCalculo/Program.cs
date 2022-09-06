using System;

namespace TrianguloCalculo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Insira o valor do lado A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o valor do lado B");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o valor do lado B");
            c = Convert.ToInt32(Console.ReadLine());


                if (a + b >= c){ 

                if ((a == b) && (b == c)){

                    Console.WriteLine("O triangulo é equilatero");

                }
                else if ((a == b) || (b == c) || (a == c)){

                    Console.WriteLine("O triangulo é isosceles");
                }
                else{
                  
                    Console.WriteLine("O triangulo é escaleno");
                }
            }else {

                Console.WriteLine("Os valores inseridos não formam um triângulo");
            }
        }
    }
}
