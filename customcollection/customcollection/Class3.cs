using System;
using System.Collections.Generic;
using System.Text;

namespace customcollection
{
    public class Gerente : IFuncionario
    {
        public string Nome { get; set; }
        public string Cracha { get; set; }
        public string AreaGestao { get; set; }
        public double Bonificacao { get { return (Salario / 100) * 20; } }
        public double Salario { get; set; } = 10000;
    }
}

