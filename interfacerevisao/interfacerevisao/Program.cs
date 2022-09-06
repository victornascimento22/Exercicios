using System;

namespace interfacerevisao
{
    public interface IPiloto : IPessoa 
    {
        public string Licenca { get; set; }
         void Guiar(string carro);


    }

    public class Piloto : IPiloto
    {

        private string _carroguiado { get; set; }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Idade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DatadeNascimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Telefone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Licenca { get; set; }
      

        public void Guiar(string carro)
        {
            _carroguiado = carro;
            

        }

    }

    public class Pessoa : IPessoa
    {
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Idade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DatadeNascimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Telefone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public interface IPessoa
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DatadeNascimento { get; set; }
        public string Email { get; set; } 
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }

    }
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");
       
    
    
    }
    }
