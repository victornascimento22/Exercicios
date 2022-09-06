    using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            char letra;
           
     
            
            Console.WriteLine("Insira uma letra");
            letra = Convert.ToChar(Console.ReadLine());

            if  ((letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u')) {

                Console.WriteLine("A letra é uma vogal");
            }else
            {

                Console.WriteLine("A letra é uma consoante");

            }
            



        }
    }
}
