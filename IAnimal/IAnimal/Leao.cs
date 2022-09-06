using System;
using System.Collections.Generic;
using System.Text;

namespace IAnimal
{
    public class Leao : IAnimal
    {
        public bool ComeAnimaisVivoApenas { get; set; }
        public bool Vivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Respirar()
        {
            
        }

        public void Caminhar()
        {
            
        }

        public void Levantar()
        {
            
        }

        public void Correr()
        {
            
        }

        public TipoAlimentacao TipoAlimentacao
        {
            get { return TipoAlimentacao.Carnivoro; }
        }

    
    }
}
