
using System;

namespace numerosrepetidosvetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.Write("Quantos valores\t");
            N = Convert.ToInt32(Console.ReadLine());

            int[] nVet = new int[N];
            int[] nVetAuxA = new int[N];
            int[] contVet = new int[N];


            // preenchendo Vetor
            for (int i = 0; i < nVet.Length; i++)
            {
                Console.Write("DIGITE APENAS NUMEROS INTEIROS : ");
                nVet[i] = Convert.ToInt32(Console.ReadLine());
                nVetAuxA[i] = nVet[i];
            }

            //mostrando vetor 
            for (int i = 0; i < nVet.Length; i++)
            {
                for (int j = 0; j < nVetAuxA.Length; j++)
                {
                    if (i != j)
                    {
                        if (nVet[i] == nVetAuxA[j])
                        {
                            Console.WriteLine("Valor repetido : " + nVet[i] + "  na posição :   " + i + " e " + j );
                            contVet[i]++;
                        }

                    }
                }


            }

            for (int i = 0; i < contVet.Length; i++)
            {
                if (contVet[i] > 0)
                {
                    Console.WriteLine($"O elemento {nVet[i]} na posição {i} repete {contVet[i]} vezes.");
                }

            }

            l


        }
    }

}