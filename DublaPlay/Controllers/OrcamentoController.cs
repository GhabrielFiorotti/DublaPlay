﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.ViewModel;
using Service.Contracts;

namespace DublaPlay.Controllers
{
    public class OrcamentoController : Controller
    {
        private readonly ICadastroService _service;
        private readonly IBuscaService _serviceBuscar;

        public OrcamentoController(ICadastroService service, IBuscaService serviceBusca)
        {
            _serviceBuscar = serviceBusca;
            _service = service;
        }

        [HttpPost("[action]")]
        public IActionResult CadastroOrcamento([FromBody] OrcamentoViewModel orcamento)
        {

            try
            {
                if (ModelState.IsValid)
                {


                    return Ok(new MessageReturn("Sucesso ao Adicionar Projeto",
                                                "",
                                                true,
                                                  _service.CadastrarOrcamento(orcamento)));

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
        public IActionResult BuscarOrcamentos([FromQuery] int page, int size)
        {

            try
            {
                if (ModelState.IsValid)
                {


                    return Ok(new MessageReturn("Sucesso ao fazer a busca",
                                                "",
                                                true,
                                                  _serviceBuscar.BuscarOrcamentos(page, size)));

                }
                else
                {
                    return BadRequest(new MessageReturn("Erro ao fazer a busca",
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
    }
}
