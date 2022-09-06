using System;
using System.Collections.Generic;
using System.Text;

namespace IAnimal
{
    public interface IAnimal
    {
        void Respirar();
        void Caminhar();
        void Levantar();
        void Correr();
        bool Vivo { get; set; }
        TipoAlimentacao TipoAlimentacao { get; }
        bool ComeAnimaisVivoApenas { get; set; }     

    }

    public enum TipoAlimentacao
    {
        Carnivoro,
        Herbivoro
    }
}
