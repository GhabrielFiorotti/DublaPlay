using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace DublaPlay.Controllers
{
    public class OrcamentoController : Controller
    {
        private readonly ICadastroService _service;

        public OrcamentoController(ICadastroService service)
        {
            _service = service;
        }
    }
}
