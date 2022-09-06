using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, soma = 0;
            int i = 0;
            float media;


            while (i < 10)
            {
                Console.WriteLine("Digite um valor : \t");
                x = Convert.ToInt32(Console.ReadLine());
                
                if ( x < 0 )
                {
                    Console.WriteLine("NAO PODE");
                }   
                soma = soma + x;
                i++;   
            }
            
            media = soma / i;
            Console.WriteLine("média" + media) ;

        }
    }
}
