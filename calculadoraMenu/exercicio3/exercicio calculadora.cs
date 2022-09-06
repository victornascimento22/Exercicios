using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args) 
            {

            int a, b;
            int resultado;
            int menu;
  
            Console.WriteLine("Insira a operação que deseja realizar");
            Console.WriteLine("1 - Soma  2 - Subtracao 3 - Multiplicacao 4 - Divisao");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1){
                Console.WriteLine("Insira um número :");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira outro número");
                b = Convert.ToInt32(Console.ReadLine());

                resultado = a + b;

                Console.WriteLine("O resultado da operação é igual a = " + resultado);

            }
            else if (menu == 2){

                Console.WriteLine("Insira um número :");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira outro número");
                b = Convert.ToInt32(Console.ReadLine());

                resultado = a - b;

                Console.WriteLine("O resultado da operação é igual a = " + resultado);

            }
            else if (menu == 3){

                Console.WriteLine("Insira um número :");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira outro número");
                b = Convert.ToInt32(Console.ReadLine());

                resultado = a * b;

                Console.WriteLine("O resultado da operação é igual a = " + resultado);
            } else {

                Console.WriteLine("Insira um número :");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira outro número");
                b = Convert.ToInt32(Console.ReadLine());

                resultado = a / b;
                
                Console.WriteLine("O resultado da operação é igual a = " + resultado);
            }


         
   
        }
    }
}
