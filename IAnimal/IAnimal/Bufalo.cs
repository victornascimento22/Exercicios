using System;
using System.Collections.Generic;
using System.Text;

namespace IAnimal
{
    public class Bufalo
    {
       public bool Vivo { get; set; }
       public TipoAlimentacao TipoAlimentacao { get; set; }
       public bool ComeAnimaisVivosApenas { get; set; }

        public bool Levantar(bool vivo)
        {
            Console.Write("sim ou não");
            vivo = Convert.ToBoolean(Console.ReadLine());

            return vivo;
        }

        public void Caminhar()
        {
            
        }

        public void Respirar()
        {


        }

        public void Correr()
        {


        }

       
    }
}
