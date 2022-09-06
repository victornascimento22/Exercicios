using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace CrudSQL
{
    public class Pessoa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
       public string Telefone { get; set; }

        public string Endereco { get; set; }
        
        public DateTime DatadeNascimento { get; set; }
        public string Naturalidade { get; set;  }

        public Pessoa(string nome, string cpf, string telefone, string endereco, DateTime dataNascimento, string naturalidade)
        {

            
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Endereco = endereco;
            DatadeNascimento = dataNascimento;
            Naturalidade = naturalidade;

        }

        public Pessoa(int id, string nome, string cpf, string telefone, string endereco, DateTime dataNascimento, string naturalidade)
        {

            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Endereco = endereco;
            DatadeNascimento = dataNascimento;
            Naturalidade = naturalidade;

        }



    }
}
