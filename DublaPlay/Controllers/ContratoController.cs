using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository.ViewModel;
using Service.Contracts;

namespace DublaPlay.Controllers
{
    public class ContratoController : Controller
    {
        private readonly ICadastroService _service;

        public ContratoController(ICadastroService service)
        {
            _service = service;
        }

        [HttpPost("[action]")]
        public IActionResult CadastroContrato([FromBody] ContratoViewModel contrato)
        {
            return Ok(_service.CadastrarContrato(contrato));
        }

    }
}
