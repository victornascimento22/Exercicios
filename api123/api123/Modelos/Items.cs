using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api123.Models
{
    public class TodoItems
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }


    //A propriedade Id funciona como a chave exclusiva em um banco de dados relacional.
    //As classes de modelo podem ir para qualquer lugar do projeto, mas a Models pasta é usada por convenção.
}
