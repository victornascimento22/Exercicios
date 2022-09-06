using System;

namespace ConsoanteVogal
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0; // coeficientes da equação
            double delta = 0;  // valor de delta \\ Delta é igual a diferença entre o quadrado do coeficiente linear (b) e o produto de quatro vezes o coeficiente quadrático(a) como o coeficiente constante (c).
                               //delta = b² - 4ac \\ calculo para achar o valor de delta
                               //Delta Positivo: existem duas raízes reais diferentes
                               //Delta Negativo: não existe raiz real
                               //Delta Zero: existem duas raízes reais igual


            // ax² + bx + c = 0 \\ equação de segundo grau


            Console.WriteLine("Digite valor A ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite valor B ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite valor C ");
            c = Convert.ToDouble(Console.ReadLine());


            delta = Math.Pow(b, 2) - 4 * a * c;


            if ((a == 0) && (b == 0) && (c == 0))
            {

                Console.WriteLine("O valor de A, B, C devem ser diferentes de 0");
            }


            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Não existe valor real");

            }
            else if (delta > 0)

            {
                Console.WriteLine("Possui duas soluções reais e diferentes" + a + " " + b);

            }
            else if (delta == 0)
            {

                Console.WriteLine("Possui apenas um raiz" + a);

            }

            Console.WriteLine("O valor de delta" + delta);

            double raiz = Math.Sqrt(delta);
            double x, y;

            x = -b + Math.Sqrt(delta) / (2 * a);
            y = -b - Math.Sqrt(delta) / (2 * a);


            Console.WriteLine("O valor da equação" + " " + x);
            Console.WriteLine("O valor da equação" + " "+ y);





        }
    }
}