using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DublaPlay.Common;
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

            try
            {
                GravarTxt gravar = new GravarTxt();
                if (ModelState.IsValid)
                {

                    gravar.Gravar(String.Format("Usuario {0} cadastrado", usuario.Nome));

                    return Ok(new MessageReturn("Sucesso ao Adicionar Projeto",
                                                "",
                                                true,
                                                  _service.CadastrarUsuario(usuario)));


                }
                else
                {
                    return BadRequest(new MessageReturn("Erro ao Adicionar Projeto",
                                                        "Preencha todos os campos.",
                                                        false));
                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar Projeto",
                                                   "Erro ao adicionar projeto, por favor tente novamente mais tarde.",
                                                   false));

            }
        }

        [HttpPost("[action]")]
        public IActionResult LoginUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var resposta = _serviceBusca.BuscarUsuario(usuario);
                if (resposta != null)
                {

                    return Ok(new MessageReturn("Logado com sucesso",
                                                       "Logado com sucesso",
                                                        true,
                                                        resposta));

                }
                else
                {
                    return Ok(new MessageReturn("Erro ao fazer login",
                                                       "",
                                                       false));

                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro fazer login",
                                                   "",
                                                   false));

            }

        }
    }
}
