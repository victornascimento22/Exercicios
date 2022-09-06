using System;

namespace EuclidesAlgoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, j;
            int mdc;
            int mdcFinal;
            //maximo divisor menor valor dos numeros


            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            

            mdc = MDC(x, y);

            Console.WriteLine($"{mdc}");
            
            mdcFinal = resultado(j,x,y,mdc);

     
   
        }

        static int MDC(int x, int y)
        {
            int aux;
            int r = 1;
  

            if (x > y)
            {
                aux = x;
                x = y;
                y = aux;
            }

            do
            {
                r = x % y;
                x = y;
                y = r;

            } while (r != 0);

        
            return x;

        }

        static int resultado(int j,int x, int y, int mdc)
        {
            int aux;
            while (y != 0)
            {
                aux = x;
                x = y;
                y = aux % y;
            }

            return j;
        }

    }

   
}
