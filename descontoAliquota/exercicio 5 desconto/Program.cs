using System;

namespace exercicio_5_desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float desc;
            float descresul;
            float aliquo1 = (float)(5.0 / 100.0);
            float aliquo2 = (float)(15 / 100.0);
            float aliquo3 = (float)(25 / 100.0);
            float resultado;
          




            Console.WriteLine("Digite o valor do produto");//comando de entrada
            a = Convert.ToSingle(Console.ReadLine());        // comando de saída que atribui um valor a uma variavel e a mesma converte para um tipo de dado Single
            Console.WriteLine("O valor do produto = " + a);

            Console.WriteLine("Digite o valor do desconto"); //comando de entrada
            desc = Convert.ToSingle(Console.ReadLine());// comando de saída que atribui um valor a uma variavel e a mesma converte para um tipo de dado Single

            descresul = (desc / 100.0f); //porcentagem

            a = a - (descresul * a);// valor do produto com desconto


            Console.WriteLine("valor do produto com desconto" + a);


            if (a > 100)
            {
                a = a + (aliquo1 * a);
                Console.WriteLine("valor do produto com acréscimo de 5%" + a);

            }
            else if (a > 101){
                a = a + (aliquo2 * a);
                Console.WriteLine("valor do produto com acréscimo de 15%" + a);

            }
            else if (a > 1000){

                a = a + (aliquo3 * a);
                Console.WriteLine("valor do produto com acréscimo de 25%" + a);

            }
        }
    }
}
