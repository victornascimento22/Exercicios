using System;

namespace vetor_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] notasVetor = new float[10];
            float[] notasvetAux = new float[10];
            float total = 0;
            float maior = 0;
            double menor = 0;


            //preenchendo o vetor
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a nota de um aluno\t" + i);
                notasVetor[i] = Convert.ToSingle(Console.ReadLine());


                //verificar se o numero inserido é igual a 0
                if (menor == 0)
                {
                    menor = notasVetor[i];
                }
            
                //atualizando o maior valor e o menor valor do vetor
                if (notasVetor[i] > maior)
                {
                    maior = notasVetor[i];
                }
                if (notasVetor[i] < menor)
                {
                    menor = notasVetor[i];
                }
                total += notasVetor[i];
            }


            //comando de saída para maior, menor e a média das notas

            Console.WriteLine("A maior nota é" + maior + "A menor nota é" + menor);
            Console.WriteLine("A média é " + total / 10);






        }
    }
}
