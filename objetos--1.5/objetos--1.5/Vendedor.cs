using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos__1._5
{
    public class Vendedor
    {

        public string Nome { get; set; }
        public int CodigoCracha { get; set; }

        public Vendedor(string nome, int codigocracha)
        {
            this.Nome = nome;
            this.CodigoCracha = codigocracha;



        }

    }
}
