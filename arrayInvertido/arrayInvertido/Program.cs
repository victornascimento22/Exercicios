using System;

namespace arrayInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] vetor = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] vetorAux = new int[10];


            for (int i = 0,j = 10-1; i < 10 && j >= 0; i++, j--)
                {
                
                vetorAux[i] = vetor[j];
                Console.WriteLine($"{vetorAux[i]}");

            }



        }
    }
}
