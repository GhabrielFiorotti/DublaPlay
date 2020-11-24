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
    public class EmpresaController : Controller
    {
        
        private readonly ICadastroService _service;
        private readonly IBuscaService _serviceBusca;

        public EmpresaController(ICadastroService service, IBuscaService serviceBusca)
        {
            _service = service;
            _serviceBusca = serviceBusca;
        }

        [HttpPost("[action]")]
        public IActionResult CadastroEmpresa([FromBody] Empresa empresa)
        {

            try
            {
                if (ModelState.IsValid)
                {


                    return Ok(new MessageReturn("Sucesso ao Adicionar Projeto",
                                                "",
                                                true,
                                                  _service.CadastrarEmpresa(empresa)));

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
        public IActionResult LoginEmpresa([FromBody] Empresa empresa)
        {
            try
            {
                var resposta = _serviceBusca.BuscarEmpresa(empresa);
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
