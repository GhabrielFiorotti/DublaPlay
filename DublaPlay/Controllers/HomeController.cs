using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DublaPlay.Models;
using Microsoft.Extensions.Configuration;
using Service.Contracts;
using Repository.Models;

namespace DublaPlay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICadastroService _service;

        public HomeController(ILogger<HomeController> logger, ICadastroService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        public IActionResult CadastroEmpresa()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult CadastroLocutor()
        {
           
            return View();
        }

        [HttpPost("[action]")]
        public IActionResult CadastroLocutor([FromBody] Usuario usuario)
        {
          
            _service.CadastrarUsuario(usuario);

            return Ok("fafoi");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
