using System;

namespace asterisco
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha = 0, coluna = 1;
            int count = Convert.ToInt32(Console.ReadLine());
            int colunas = count - 1;

            for (int i = 1;  i <= count; i++)
            {
                for (int a = 1; a <= linha; a++)
                {
                    Console.Write("");
                }
                for (int s = 1; s <= coluna; s ++)
                {
                    Console.Write("*");

                }
                linha--;
                coluna = coluna + 2;
                Console.WriteLine();


            }
        }
    }
}
