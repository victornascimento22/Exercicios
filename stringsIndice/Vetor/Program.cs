using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetorNomes = new string[10];

            for (int i = 0; i < vetorNomes.Length; i++)
            {

                Console.WriteLine("Insira um nome");
                vetorNomes[i] = Convert.ToString(Console.ReadLine());
            }

            for (int i = 0; i < vetorNomes.Length; i++)
            {

                Console.WriteLine("Os nomes inseridos do vetor : \t " + "Posição do Vetor =\t"
                   + i + "\t" + vetorNomes[i]);




            }


        }
    }
}