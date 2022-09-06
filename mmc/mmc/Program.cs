using System;

namespace mmc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, menor;
            int[] vet1 = new int[3];
            int[] vetAux = new int[20];
           

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("menor1");
                menor = a;
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("menor2");
                menor = b;
            }
            else
            {
                Console.WriteLine("menor3");
                menor = c;
            }

            while ()
            {
                if (a % i == 0 || b % i == 0 || c % i == 0)
                {
                    if (vetAux == 0)
                    {
                        
                    }
                   

                }
            }

       

            for (int i = 0; i <= menor; i++)
            {

                Console.WriteLine($"{vetAux[i]}");


            }
        }
    }
}
