using System;
using System.Collections.Generic;
using System.Text;

namespace customcollection
{
    public class Repositor : IFuncionario
    {

        public string Nome { get; set; }
        public string Cracha { get; set; }

        public string Local { get; set; }

        public double Salario { get; set; } = 5000;
        public double Bonificacao { get { return (Salario / 100) * 20; } }
    }
}
