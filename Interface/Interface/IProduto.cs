using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IProduto
    {

        string Marca { get; set; }
        string Descricao { get; set; }
        double ValorEmReal { get; set; }
        double ValorDeOrigem { get; }
        string PaisDeOrigem { get; set; }



    }
}
