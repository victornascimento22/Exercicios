using System;

namespace linhasecolunas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int maior=nGrande(a);

            //int resultado = nGrande(maior);
            //Console.WriteLine($"{resultado}");

        }

        static int nGrande(int a)
        {
            int maior=0;
            int[] numeros = new int[a];

            for (int i = 0; i < numeros[a]; i++)
            {
                Console.WriteLine("Digite o numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < numeros.Length;i ++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];

                } else if (numeros[i] == maior)
                {
                    Console.WriteLine($"Elemento {numeros[i]} repetido no Indice {i}");
                }
            }
            


            return maior;
        }
    }
}
