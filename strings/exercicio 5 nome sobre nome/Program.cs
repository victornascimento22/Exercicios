using System;

namespace exercicio_5_nome_sobre_nome
{
    class Program
    {
        static void Main(string[] args)
        {
            string  nome;
            string  sbnome;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            sbnome = Console.ReadLine();

            Console.WriteLine("Seu nome e seu sobrenome = " + nome +  " " + sbnome);


        }
    }
}
