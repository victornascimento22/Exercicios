using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos__1._5
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }

        public Cliente(string nome, string cpf, string endereco)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Endereco = endereco; 


        }


    }
}
