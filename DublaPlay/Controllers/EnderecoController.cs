using DublaPlay.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DublaPlay.Controllers
{
    public class EnderecoController : Controller
    {

        private readonly ICadastroService _service;

        public EnderecoController(ICadastroService service)
        {

            _service = service;
        }


        [HttpPost("[action]")]
        public IActionResult CadastroEndereco([FromBody] Endereco endereco)
        {
            Console.WriteLine(endereco);

            
            _service.CadastrarEndereco(endereco);


            return Ok("fafoi");
        }
    }
}
