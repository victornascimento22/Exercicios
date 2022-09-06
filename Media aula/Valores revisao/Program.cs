using System;

namespace Valores_revisao
{
    class Program
    {
        public static readonly int i;

        static void Main(string[] args)

        {

            /*Faça um programa que receba um número indefinido de valores e ao fim da execução,
            mostre a média de todas as entradas;*/


            float entrada;
            float entradatotal = 0;
            float contador = 0;

            Console.WriteLine("Digite um valor:");
            entrada = Convert.ToSingle(Console.ReadLine());
            while (entrada >= 1)

            {
                contador = contador + 1;
                entradatotal = entrada + entradatotal;
                entrada = Convert.ToSingle(Console.ReadLine());
            }
            Console.WriteLine("A media é:" + entradatotal / contador);

        }


    }

}
