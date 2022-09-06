using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal f2 = 0, f3 = 1;
            decimal f1 = 0;



            for (int a = 0; a < 140; a++)
            {

                f1 = f2 + f3;
                f2 = f3;
                f3 = f1;

                Console.WriteLine("Fibonacci\t\t" + f1);
            }

        }


    }
}
