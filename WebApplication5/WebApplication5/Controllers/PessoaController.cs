using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PessoaController : Controller
    {
        private static readonly List<Pessoa> pessoas = new List<Pessoa>();
   
        [HttpPost]
        public IActionResult SalvarPessoa(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                Ok("Pessoa nao adicionada! ");
            }

            pessoas.Add(pessoa);           
            return Ok("Pessoa adicionada com sucesso! ");
        }
        [HttpPut]
        public IActionResult AtualizarPessoa(Pessoa pessoa)
        {
            Pessoa x = pessoas.FirstOrDefault(x => x.Nome == pessoa.Nome);
            if (x != null)
            {
                x.Nome = pessoa.Nome;
                x.Cpf = pessoa.Cpf;
                x.Idade = pessoa.Idade;
                return Ok("Pessoa atualizada: ");
            }
            else
            {
                NotFound();
            }
            return Ok();
        }
        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Ok(pessoas.ToList());
        }
        [HttpDelete]
        public IActionResult Delete(Pessoa pessoa)
        {
            Pessoa x = pessoas.FirstOrDefault(p => p.Nome == p.Nome);
            if(x != null)
            {
                 pessoas.Remove(x);
            }
            else
            {
               return Ok("Pessoa não encontrada. ");
            }

            return Ok("Pessoa Removida com sucesso. ");
        }
    }
}
