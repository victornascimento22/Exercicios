using System;

namespace objetos__1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor1 = new Vendedor("Victor", 1);
            Vendedor vendedor2 = new Vendedor("Victorio", 2);
            Cliente cliente1 = new Cliente("Victorino", "54564465", "sdhiuashduihas");
            Cliente cliente2 = new Cliente("Victorildo", "64654654", "iuashduihasuidh");

            Venda venda1 = new Venda( 5000, vendedor1, cliente1);
            Venda venda2 = new Venda( 3000, vendedor2, cliente2);


            Console.WriteLine("Valor total da venda : " + venda1.ValorTotalVenda);
            Console.WriteLine("Valor total da venda : " + venda1.Vendedor.Nome);
            Console.WriteLine("Valor total da venda : " + venda1.Cliente.Nome);
            Console.WriteLine("Cracha : " + venda1.Vendedor.CodigoCracha);












        }
    }
}
