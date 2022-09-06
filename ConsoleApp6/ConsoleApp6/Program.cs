using System;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int qtd = 30;

            string caracteres = "ABCDEFGHI64654864848648JKLM213123123123123NOPQRSTUVWXYZÇ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ".ToLower() +
                "0123456789012345678654798765465486421368789" + "%$#@!!@#$%%()_-+=§¢£³²¹.,;:|/&&*";

            Random sorteio = new Random();
            int numerosSorteado = 0;
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < qtd; i++)
            {
                numerosSorteado = sorteio.Next(0, caracteres.Length - 1);
                password.Append(caracteres[numerosSorteado]);
            }

            Console.WriteLine(password);

        }
    }
}
