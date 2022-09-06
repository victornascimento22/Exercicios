using System;

namespace exer1Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[10] { "Victor", "Andre", "Pedro", "Clara", "Maria", "Rodrigo", "Jose", "Roberto", "Julia", "Gabriela" };
            double[] notas1 = new double[10] { 2, 5, 8, 7, 6, 7, 5, 7, 9, 5 };
            double[] notas2 = new double[10] { 9, 4, 7, 4, 3, 7, 5, 4, 9, 5 };
            double[] notas3 = new double[10] { 4, 5, 3, 5, 6, 7, 5, 1, 6, 4 };
            double[] mediatotal = new double[10];

            for (int i = 0; i < notas1.Length; i++)
            {
                Console.Write($"{i} - Notas do primeiro bimestre - Aluno : {alunos[i]} - Nota : {notas1[i]}\n");
                //notas1[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for (int i = 0; i < notas2.Length; i++)
            {
                Console.Write($"{i} - Notas do segundo bimestre - Aluno : {alunos[i]} - Nota : {notas2[i]}\n");
                //notas2[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for (int i = 0; i < notas3.Length; i++)
            {
                Console.Write($"{i} - Notas do terceiro bimestre - Aluno : {alunos[i]} - Nota : {notas3[i]}\n");
                //notas3[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for (int i = 0; i < alunos.Length; i++)
            {
                mediatotal[i] = notas1[i] + notas2[i] + notas3[i];
                Console.Write($"Nota Geral - Aluno : {alunos[i]} - Nota : {notas1[i]} + {notas2[i]} + {notas3[i]} = {mediatotal[i]}\n");
            }

            Console.WriteLine("\n");

            double[] menor = menornota(notas1, notas2, notas3);

            for (int i = 0; i < menor.Length; i++)
            {
                Console.WriteLine($"{i} - Menor nota : {alunos[i]} : {menor[i]}");
            }

            Console.WriteLine("\n");

            double[] maiorAluno = maiornota(notas1, notas2, notas3);

            for (int i = 0; i < maiorAluno.Length; i++)
            {

                Console.WriteLine($"{i} - Maior nota : {alunos[i]} : {maiorAluno[i]}");
            }

            Console.WriteLine("\n");

            double[] mediageral = medianota(notas1, notas2, notas3);

            for (int i = 0; i < mediageral.Length; i++)
            {
                Console.WriteLine($"{i} - Média Aluno :  {alunos[i]} : {mediageral[i]}");
            }

            Console.WriteLine("\n");

            double[] maiornotaTurma = maiornotaturma(notas1, notas2, notas3);

            double maiorTurma = 10;

            for (int i = 0; i < 10; i++)
            {
                if (maiorAluno[i] > maiorTurma)
                {
                    maiorTurma = maiorAluno[i];
                    Console.WriteLine($"{i} - Maior nota turma :  {alunos[i]} : {maiorTurma}");
                }

                if (maiorAluno[i] == maiorTurma)
                {
                    Console.WriteLine($"Notas iguais {alunos[i]} {maiorTurma}");
                }
            }

            Console.WriteLine("\n");

            double[] menornotaTurma = menornotaturma(notas1, notas2, notas3);

            double menor1 = maiorTurma;

            for (int i = 0; i < 10; i++)
            {
                if (menor[i] < menor1)
                {
                    menor1 = menor[i];
                    Console.WriteLine($"{i} - Menor nota turma :  {alunos[i]} : {menor1}");
                }

                if (menor[i] == menor1)
                {
                    Console.WriteLine($"3Notas iguais {alunos[i]} {menor1}");
                }
            }
        }

        static double[] menornota(double[] menor1, double[] menor2, double[] menor3)
        {
            double[] menorAux1 = new double[10];

            for (int i = 0; i < menorAux1.Length; i++)
            {

                if ((menor1[i] < menor2[i]) && (menor1[i] < menor3[i]))
                {
                    menorAux1[i] = menor1[i];
                }
                else if ((menor2[i] < menor1[i]) && (menor2[i] < menor3[i]))
                {
                    menorAux1[i] = menor2[i];
                }
                else if ((menor3[i] < menor1[i]) && (menor3[i] < menor2[i]))
                {
                    menorAux1[i] = menor3[i];
                }
                else
                {
                    menorAux1[i] = menor1[i];
                }
            }
            return menorAux1;
        }

        static double[] maiornota(double[] maior1, double[] maior2, double[] maior3)
        {
            double[] maiorAux1 = new double[10];

            for (int i = 0; i < maiorAux1.Length; i++)
            {

                if ((maior1[i] > maior2[i]) && (maior1[i] > maior3[i]))
                {
                    maiorAux1[i] = maior1[i];
                }
                else if ((maior2[i] > maior1[i]) && (maior2[i] > maior3[i]))
                {
                    maiorAux1[i] = maior2[i];
                }
                else if ((maior3[i] > maior1[i]) && (maior3[i] > maior2[i]))
                {
                    maiorAux1[i] = maior3[i];
                }
                else
                {
                    maiorAux1[i] = maior1[i];
                }
            }
            return maiorAux1;
        }

        static double[] medianota(double[] menor1, double[] menor2, double[] menor3)
        {
            double[] medianota = new double[10];

            for (int i = 0; i < medianota.Length; i++)
            {

                if ((menor1[i] < menor2[i]) && (menor1[i] < menor3[i]))
                {
                    medianota[i] = menor2[i] + menor3[i] / 2;
                }
                else if ((menor2[i] < menor1[i]) && (menor2[i] < menor3[i]))
                {
                    medianota[i] = menor1[i] + menor3[i] / 2;
                }
                else if ((menor3[i] < menor1[i]) && (menor3[i] < menor2[i]))
                {
                    medianota[i] = menor1[i] + menor2[i] / 2;
                }
                else
                {
                    medianota[i] = menor1[i];
                }

            }
            return medianota;
        }

        static double[] maiornotaturma(double[] notas1, double[] notas2, double[] notas3)
        {
            double[] maior = new double[10];

            for (int i = 0; i < notas1.Length; i++)
            {
                if ((notas1[i] > notas2[i]) && (notas1[i] > notas3[i]))
                {
                    maior[i] = notas1[i];
                }
                else if ((notas2[i] > notas1[i]) && (notas2[i] > notas3[i]))
                {
                    maior[i] = notas2[i];
                }
                else if ((notas3[i] > notas1[i]) && (notas3[i] > notas2[i]))
                {
                    maior[i] = notas3[i];
                }
                else
                {
                    maior[i] = notas1[i];
                }
            }
            return maior;
        }

        static double[] menornotaturma(double[] notas1, double[] notas2, double[] notas3)
        {
            double[] menor = new double[10];

            for (int i = 0; i < notas1.Length; i++)
            {
                if ((notas1[i] > notas2[i]) && (notas1[i] > notas3[i]))
                {
                    menor[i] = notas1[i];
                }
                else if ((notas2[i] > notas1[i]) && (notas2[i] > notas3[i]))
                {
                    menor[i] = notas2[i];
                }
                else if ((notas3[i] > notas1[i]) && (notas3[i] > notas2[i]))
                {
                    menor[i] = notas3[i];
                }
                else
                {
                    menor[i] = notas1[i];
                }
            }
            return menor;
        }
    }
}


