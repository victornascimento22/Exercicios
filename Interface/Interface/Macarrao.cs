using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Macarrao : IProduto
    {
        public string Marca { get; set; }

        public string Descricao { get; set; }
        public double ValorEmReal { get; set; }

        public double ValorDeOrigem
        {
            get
            {
                return ValorEmReal / 5.51;
            }
        }
        public string PaisDeOrigem { get; set; }


    }
}
