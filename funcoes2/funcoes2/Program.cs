using System;

namespace funcoes2
{
    class Program
    {
        static void Main(string[] args)
        {

            Vetores();


        }
        static void Vetores()
        {
            double total=0;
            double[] vetor = new double[10];
            double media;

            Random random = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 10);
                total += vetor[i];
               
            }

            media =  total / 10;
        


            for (int i = 0; i < vetor.Length; i++)
            {

                Console.WriteLine($"{vetor[i]}");


            }
            Console.WriteLine($"{media}");
        }

       
    }

}
