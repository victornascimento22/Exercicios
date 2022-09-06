using System;
using System.Collections.Generic;
using System.Text;
using APIMVC.Models;

namespace APIMVC.Controller
{
    public class CaminhaoController
    {
        //intermedia toda a ação de informacoes que vao pra tela.
        private readonly IList<Caminhao> _caminhoes = new List<Caminhao>();
        //só visivel na classe, e não posso alterar algum atributo que seja ligado a ele diretamente;

        public CaminhaoController()
        {



        }

        public void AdicionarViagem(Caminhao caminhao)
        {

            _caminhoes.Add(motorista);

        }
        // crud básico




    }
}
