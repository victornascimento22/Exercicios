using System;

namespace doisvetores
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] vetA = new int[5];
            int[] vetB = new int[5];
            int[] vetC = new int[5];

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.Write("Preencha vetor A\t");
                vetA[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.Write("Preencha vetor B\t");
                vetB[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < vetA.Length; i++)
            {
                vetC[i] = vetA[i] * vetB[i];
            }

            for (int i = 0; i < vetA.Length; i++) {
                Console.WriteLine("O valor das multiplicações entre o Vetor A e Vetor B são : \t" + vetC[i]);
            }

        }
    }
}
