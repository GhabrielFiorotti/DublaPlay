﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using DublaPlay.Models;
using DublaPlay.DTO;

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
            _service.CadastrarSolicitacao(solicitacao);

            return Ok("fafoi");
        }
    }
}
