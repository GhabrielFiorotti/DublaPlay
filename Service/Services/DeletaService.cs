using Repository.Contracts;
using Repository.Repository;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class DeletaService : IDeletaService
    {
        private readonly IDeletaRepository _repository;

        public DeletaService(IDeletaRepository repository)
        {
            _repository = repository;
        }

        public bool DeletarContrato(int id)
        {
            return _repository.DeletarContrato(id);
        }

        public bool DeletarEmpresa(int id)
        {
            return _repository.DeletarEmpresa(id);
        }

        public bool DeletarOrcamento(int id)
        {
            return _repository.DeletarOrcamento(id);
        }

        public bool DeletarSolicitacao(int id)
        {
            return _repository.DeletarSolicitacao(id);
        }

        public bool DeletarUsuario(int id)
        {
            return _repository.DeletarUsuario(id);
        }
    }
}
