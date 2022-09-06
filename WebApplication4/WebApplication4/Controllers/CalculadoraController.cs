using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculadoraController:ControllerBase
    {
        [HttpGet]
        public string Soma(string a, string b)
        {
            int resultado = Convert.ToInt32(a) + Convert.ToInt32(b);
            return resultado.ToString();
        }
    }
}
