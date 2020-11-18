using DublaPlay.Models;
using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AlteraService : IAlteraService
    {
        private readonly IAlteraRepository _repository;

        public AlteraService(IAlteraRepository repository)
        {
            _repository = repository;
        }

        public int AlterarContrato(Contrato contrato)
        {
            return _repository.AlterarContrato(contrato);
        }

        public int AlterarEmpresa(Empresa empresa)
        {
            return _repository.AlterarEmpresa(empresa);
        }

        public int AlterarOrcamento(Orcamento orcamento)
        {
            return _repository.AlterarOrcamento(orcamento);
        }

        public int AlterarSolicitacao(Solicitacao solicitacao)
        {
            return _repository.AlterarSolicitacao(solicitacao);
        }

        public int AlterarUsuario(Usuario usuario)
        {
            return _repository.AlterarUsuario(usuario);
        }
    }
}
