using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using DublaPlay.Models;
using Repository.ViewModel;
using Repository.Models;

namespace DublaPlay.Controllers
{
    public class SolicitacaoController : Controller
    {
        private readonly ICadastroService _service;

        public SolicitacaoController(ICadastroService service)
        {
            _service = service;
        }


        [HttpPost("[action]")]
        public IActionResult CadastroSolicitacao([FromBody] SolicitacaoViewModel solicitacao)
        {

            try
            {
                if (ModelState.IsValid)
                {


                    return Ok(new MessageReturn("Sucesso ao Adicionar Projeto",
                                                "",
                                                true,
                                                  _service.CadastrarSolicitacao(solicitacao)));

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
    }
}
