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

        public EmpresaController(ICadastroService service)
        {
        
            _service = service;
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

            if (_serviceBusca.BuscarEmpresa(empresa) != null)
            {
                return Ok("Logado com sucesso");

            }
            else
            {
                return Ok("Não pois realizar o login, verifique se os dados foram digitados corretamente.");

            }

        }

    }
}
