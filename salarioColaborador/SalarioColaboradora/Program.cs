using System;

namespace SalarioColaboradora
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, salariodol, salarioeuro;
            float a = (float)(20 / 100.0);
            float b = (float)(13 / 100.0);
            float c = (float)(10 / 100.0);
            double d = (float)(5 / 100.0);
            float dol = 4.70f;
            float euro = 5.20f;
            int menu;

            
                Console.WriteLine("Insira o salário do colaborador");
                salario = Convert.ToSingle(Console.ReadLine());



                    if (salario <= 1200){

                        salario = salario + (a * salario);
                        Console.WriteLine("O salário do colaborar com acréscismo de 20%" + salario);

                        salariodol = salario / dol;
                        Console.WriteLine("O salário convertido em Dólar " + salariodol);

                        salarioeuro = salario / euro;
                        Console.WriteLine("O salário convertido em Euro " + salarioeuro);



            }
            else if (salario <= 2000){

                        salario = salario + (b * salario);
                        Console.WriteLine("O salário do colaborar com acréscismo de 13%" + salario);

                        salariodol = salario / dol;
                        Console.WriteLine("O salário convertido em Dólar " + salariodol);

                        salarioeuro = salario / euro;
                        Console.WriteLine("O salário convertido em Euro " + salarioeuro);

            }
            else if (salario <= 2500) {
            
                        salario = salario + (c * salario);
                        Console.WriteLine("O salário do colaborar com acréscismo de 10%" + salario);

                        salariodol = salario / dol;
                        Console.WriteLine("O salário convertido em Dólar " + salariodol);

                        salarioeuro = salario / euro;
                        Console.WriteLine("O salário convertido em Euro " + salarioeuro);

            }
            else if (salario > 2500){

                        salario = (float)(salario + (d * salario));
                        Console.WriteLine("O salário do colaborar com acréscismo de 5%" + salario);

                        salariodol = salario / dol;
                        Console.WriteLine("O salário convertido em Dólar " + salariodol);

                        salarioeuro = salario / euro;
                        Console.WriteLine("O salário convertido em Euro " + salarioeuro);

            }


         
        }
    }
}