using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DublaPlay.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Service.Contracts;

namespace DublaPlay.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ICadastroService _service;
        private readonly IBuscaService _serviceBusca;


        public UsuarioController(ICadastroService service, IBuscaService serviceBusca)
        {
            _service = service;
            _serviceBusca = serviceBusca;
        }

        [HttpPost("[action]")]
        public IActionResult CadastroLocutor([FromBody] Usuario usuario)
        {
            _service.CadastrarUsuario(usuario);

            return Ok("fafoi");
        }

        [HttpPost("[action]")]
        public IActionResult LoginUsuario([FromBody] Usuario usuario)
        {

            if (_serviceBusca.BuscarUsuario(usuario) != null)
            {
                return Ok("logado");

            }
            else
            {
                return Ok("nao logado");

            }

        }

    }
}
