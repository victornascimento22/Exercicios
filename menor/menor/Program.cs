using System;

namespace menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int menor = MenorNota(a,b);


            Console.WriteLine($"{menor}");
        }

        static int MenorNota(int a, int b)
        {
            int menor1;

            if (a < b)
            {
                menor1 = a;

            }else
            {

                menor1 = b;
            }
           



            return menor1;
        }
    }
}
