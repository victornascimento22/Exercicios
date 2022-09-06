using System;

namespace ConsoleApp3
{
    class 
        
         Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[5];
            double[] array2 = new double[5];
            string[] array3 = new string[6];

            ///preencherVetor(array);
            preencherVetorMultiplicando(array);
            ///ReceberValoresAtribuir(array, array2);
            ///ArrayMultiplicadoPeloIndice(array);       
            ///Convertendo_variavel_Array();
        }
        static void preencherVetor(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Digite o {i}° do seu array: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }         
        }
        static void preencherVetorMultiplicando(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Digite o {i}° do seu array: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
                array[i] = array[i] * 2;
                Console.WriteLine($"{i}° x 2 = " + array[i]);
            }
        }
        static void ReceberValoresAtribuir(double[] array, double[] array2)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Digite o {i}° do seu array: ");
                array[i] = Convert.ToDouble(Console.ReadLine());               
            }
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
                Console.WriteLine(array[i] + "==" + array2[i]);
            }           
        }
        static void ArrayMultiplicadoPeloIndice(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Digite o {i}° do seu array: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
                array[i] = array[i] * i;
                Console.WriteLine($" vezes o {i}° {array[i]}");
            }
        }
        static void Convertendo_variavel_Array()
        {
            string texto = Console.ReadLine();
            char[] chars = new char[texto.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = texto[i];
            }

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
        }
    }
}
