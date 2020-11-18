using DublaPlay.Models;
using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class BuscaService : IBuscaService
    {
        private readonly IBuscaRepository _repository;

        public BuscaService(IBuscaRepository repository)
        {
            _repository = repository;
        }

        public Contrato BuscarContrato(Contrato contrato)
        {
            return _repository.BuscarContrato(contrato);
        }

        public Empresa BuscarEmpresa(Empresa empresa)
        {
            return _repository.BuscarEmpresa(empresa);
        }

        public Orcamento BuscarOrcamento(Orcamento orcamento)
        {
            return _repository.BuscarOrcamento(orcamento);
        }

        public Solicitacao BuscarSolicitacao(Solicitacao solicitacao)
        {
            return _repository.BuscarSolicitacao(solicitacao);
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            return _repository.BuscarUsuario(usuario);
        }
    }
}
