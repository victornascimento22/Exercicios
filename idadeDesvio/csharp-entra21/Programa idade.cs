using System;

namespace csharp_entra21
{
	class Program
	{
		static void Main(string[] args)
		{
			int idade;

			//COMANDO DE ENTRADA

			Console.WriteLine("Insira a sua idade");
			idade = Convert.ToInt32(Console.ReadLine());


			if (idade >= 18)
			{
				Console.WriteLine("O sujeito é maior de idade");
			}
			else
			{
				Console.WriteLine("O sujeito é menor de idade");
			}
		}
	}
}
