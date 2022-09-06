using System;

namespace entradadetexto
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] a = new string[10];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Insira um texto ");
                a[i] = Convert.ToString(Console.ReadLine());

            }

            for (int i = 0; i < a.Length; i++)
            {

                Console.Write (a[i] + "\tou\t");

            }


        }
    }
}