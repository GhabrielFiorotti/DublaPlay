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
        private readonly IBuscaService _serviceBuscar;
        private readonly IDeletaService _servicedeletar;

        public SolicitacaoController(ICadastroService service, IBuscaService serviceBusca, IDeletaService serviceDeleta)
        {
            _service = service;
            _serviceBuscar = serviceBusca;
            _servicedeletar = serviceDeleta;
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



        [HttpGet("[action]")]
        public IActionResult BuscaSolicitacoesEmAberto([FromQuery] int page, int size)
        {

            try
            {
                if (ModelState.IsValid)
                {


                    return Ok(new MessageReturn("Sucesso ao Adicionar Projeto",
                                                "",
                                                true,
                                                  _serviceBuscar.BuscarSolicitacaoAberto(page, size)));

                }
                else
                {
                    return BadRequest(new MessageReturn("Erro ao fazer a busca Projeto",
                                                        "",
                                                        false));
                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao fazer a busca",
                                                   "",
                                                   false));

            }


        }

        [HttpGet("[action]")]
        public IActionResult BuscarSolicitacaoPorEmpresa([FromQuery] int page, int size, int idEmpresa)
        {

            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Por Empresa",
                                            "",
                                            true,
                                              _serviceBuscar.BuscarSolicitacaoPorEmpresa(page, size, idEmpresa)));


            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao fazer a busca",
                                                   "",
                                                   false));

            }


        }
    }
}
