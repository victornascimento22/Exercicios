using System;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {

        static void Main(string[] args)
        {
            int qtd = 30000;

            string caracteres = "ABCDEFGHI64658648JKLM123NOPQRSTUVWXYZÇ" +
                "ABCDEFG456456HIJKLM546456NOPQRSTU45645VWXYZÇ".ToLower() +
                "0123456789012345678654798765465486421368789" + "%$#@!!@#$56456456456%%()_-+=§¢£³²¹.,;:|/&&*";

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
