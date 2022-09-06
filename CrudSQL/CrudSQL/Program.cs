using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CrudSQL
{
    class Program
    {
        static void Main(string[] args)
        {

            string connection = @"Data Source=ITELABD05\SQLEXPRESS;Initial Catalog=CrudSQL;Integrated Security=True;";

            List<Pessoa> pessoas = new List<Pessoa>();


            Console.WriteLine("Insira o Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o CPF:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Insira o Rg:");
            string rg = Console.ReadLine();
            Console.WriteLine("Insira o Telefone:");
            string telefone = Console.ReadLine();
            Console.WriteLine("Insira o Endereço:");
            string endereco = Console.ReadLine();
            Console.WriteLine("Insira o Data de nascimento:");
            DateTime dataDeNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Insira o Naturalidade:");
            string naturalidade = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, cpf, telefone, endereco, dataDeNascimento, naturalidade);


            try
            {

                var query = "Insert into Local " + "(Nome, CPF, Telefone, Endereco, DatadeNascimento, Naturalidade) values (@nome, @cpf, @telefone, @endereco, @dataNascimento, @naturalidade)";


                using (var sql = new SqlConnection(connection))
                {

                    SqlCommand command = new SqlCommand(query, sql);
                    command.Parameters.AddWithValue("@nome", pessoa.Nome);
                    command.Parameters.AddWithValue("@cpf", pessoa.CPF);
                    command.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                    command.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                    command.Parameters.AddWithValue("@dataNascimento", pessoa.DatadeNascimento);
                    command.Parameters.AddWithValue("@naturalidade", pessoa.Naturalidade);
                    command.Connection.Open();
                    command.ExecuteNonQuery();


                }

                Console.WriteLine("yea");
            }

            catch (Exception ex)
            {

                Console.WriteLine("Erro:" + ex.Message);

            }


            try
            {

                SqlDataReader resultado;

                var query = @"SELECT  Id, Nome, Cpf, Telefone, Endereco, DatadeNascimento, Naturalidade FROM Local";

                using (var sql = new SqlConnection(connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Connection.Open();
                    resultado = command.ExecuteReader();

                    while (resultado.Read())
                    {
                        pessoas.Add(new Pessoa(resultado.GetInt32(resultado.GetOrdinal("Id")),
                                                       resultado.GetString(resultado.GetOrdinal("Nome")),
                                                       resultado.GetString(resultado.GetOrdinal("Cpf")),
                                                       resultado.GetString(resultado.GetOrdinal("Telefone")),
                                                       resultado.GetString(resultado.GetOrdinal("Endereco")),
                                                       resultado.GetDateTime(resultado.GetOrdinal("DatadeNascimento")),
                                                       resultado.GetString(resultado.GetOrdinal("Naturalidade"))));


                    }
                }

                foreach (Pessoa p in pessoas)
                {
                    Console.WriteLine("========Inicio========");
                    Console.WriteLine("Id" + p.Id);
                    Console.WriteLine("Nome: " + p.Nome);
                    Console.WriteLine("CPF: " + p.CPF);
                    Console.WriteLine("Endereco: " + p.Endereco);
                    Console.WriteLine("Telefone: " + p.Telefone);
                    Console.WriteLine("Naturalidade: " + p.Naturalidade);
                    Console.WriteLine("Data de Nascimento: " + p.DatadeNascimento);
                    Console.WriteLine("========Fim========");
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro:" + ex.Message);

            }

            try
            {

                var query = @"DELETE FROM Local WHERE Id = @Id";

                using (var sql = new SqlConnection(connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Connection.Open();



                }

            }catch()





        }
    }


}

