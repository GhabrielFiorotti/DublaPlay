using DublaPlay.Models;
using Microsoft.AspNetCore.Mvc;
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

            _service.CadastrarEmpresa(empresa);



            return Ok("fafoi");
        }
    }
}
