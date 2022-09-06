using System;

namespace nGrandescRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int genRand = r.Next(10,100);
            Console.WriteLine("Random Number = " + genRand);


        }

   
    }
}
