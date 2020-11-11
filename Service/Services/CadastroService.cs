using DublaPlay.Models;
using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CadastroService : ICadastroService
    {
        private readonly ICadastroRepository _repository;

        public CadastroService(ICadastroRepository repository)
        {
            _repository = repository;
        }

        public int CadastrarUsuario(Usuario usuario)
        {
            return _repository.CadastrarUsuario(usuario);
        }
    }
}
