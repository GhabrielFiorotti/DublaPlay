﻿using DublaPlay.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DublaPlay.Controllers
{
    public class EnderecoController : Controller
    {

        private readonly ICadastroService _service;

        public EnderecoController(ICadastroService service)
        {

            _service = service;
        }


        [HttpPost("[action]")]
        public IActionResult CadastroEndereco([FromBody] Endereco endereco)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    return Ok(new MessageReturn("Sucesso ao Adicionar Endereco",
                                                "",
                                                true,
                                                  _service.CadastrarEndereco(endereco)));

                }
                else
                {
                    return BadRequest(new MessageReturn("Erro ao Adicionar Endereco",
                                                        "Preencha todos os campos.",
                                                        false));
                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar Endereco",
                                                   "Erro ao adicionar projeto, por favor tente novamente mais tarde.",
                                                   false));

            }
        }
    }
}
