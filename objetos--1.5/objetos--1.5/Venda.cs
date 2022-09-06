using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos__1._5
{
    public class Venda
    {

        public double ValorTotalVenda;
        public Vendedor Vendedor;
        public Cliente Cliente;

           

        public Venda(double valortotalvenda, Vendedor nomevendedor, Cliente nomecliente)
        {

            this.ValorTotalVenda = valortotalvenda;
            this.Vendedor = nomevendedor;
            this.Cliente = nomecliente;



        }

    
    
    }

}