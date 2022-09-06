using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            
            
                

            Console.WriteLine("Digite o ano para verificar se ele é bissexto");
            ano = Convert.ToInt32(Console.ReadLine());

            if ((ano % 4 == 0)&&(ano % 100 !=0)||(ano % 400 == 0)) {

                Console.WriteLine("O ano é bissexto");


            }else {
                Console.WriteLine("O ano não é bissexto");
                    
                  }

        }
    }
}

