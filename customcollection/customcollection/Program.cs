using System;

namespace customcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Repositor repositor = new Repositor() { Nome = "Joãozinho", Cracha = "654", Local = " loja" };
            Gerente gerente = new Gerente() { Nome = "João", Cracha = "6254", AreaGestao = "Vendas" };

            MostrarDados(repositor);
            MostrarDados(gerente);

        }

        public static void MostrarDados(IFuncionario funcionario)
        {
            Console.WriteLine("Nome" + funcionario.Nome);
            Console.WriteLine("Cracha" + funcionario.Cracha);
            Console.WriteLine("salario" + funcionario.Bonificacao);

        }
    }
}
