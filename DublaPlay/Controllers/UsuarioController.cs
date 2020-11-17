using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace DublaPlay.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ICadastroService _service;

        public UsuarioController(ICadastroService service)
        {
            _service = service;
        }
    }
}
