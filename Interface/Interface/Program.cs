using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduto> produtos = new List<IProduto>();
                       
            Macarrao macarrao = new Macarrao() {Marca ="Marca,", Descricao="Descricao", PaisDeOrigem="Italia", ValorEmReal=2.50};
            Carne carne = new Carne() { Marca = "Marca,", Descricao = "Descricao", PaisDeOrigem = "PaisdeOrigem", ValorEmReal = 90.00 };
            Leite leite = new Leite() { Marca = "Marca,", Descricao = "Descricao", PaisDeOrigem = "PaisdeOrigem", ValorEmReal = 5.00 };



            produtos.Add(macarrao);
            produtos.Add(carne);
            produtos.Add(leite);

            foreach (IProduto produto in produtos) {


                Console.WriteLine(produtos);
            
            }

        
        }
    }
}
