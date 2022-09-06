using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        double[] vetor = new double[5];
        double menor = 0;
        double maior = 0;
        double soma = 0;
        double media;

        Random random = new Random();


        for (int i = 0; i < vetor.Length; i++)
        {

            vetor[i] = random.Next(1, 10);
        }


        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];

            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        menor = maior;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }

        }
        media = soma / 5;

        Console.WriteLine("o maior valor é: " + maior);
        Console.WriteLine("o menor valor é: " + menor);
        Console.WriteLine("A média é: " + media);


    }
}

