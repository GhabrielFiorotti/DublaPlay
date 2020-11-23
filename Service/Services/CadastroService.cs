using DublaPlay.Models;
using Repository.Contracts;
using Repository.DTO;
using Repository.Models;
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

        public int CadastrarEmpresa(Empresa empresa)
        {
            return _repository.CadastrarEmpresa(empresa);
        }

        public int CadastrarContrato(Contrato contrato)
        {
            return _repository.CadastrarContrato(contrato);
        }

        public int CadastrarOrcamento(Orcamento orcamento)
        {
            return _repository.CadastrarOrcamento(orcamento);
        }

        public int CadastrarSolicitacao(SolicitacaoViewModel solicitacao)
        {
            return _repository.CadastrarSolicitacao(solicitacao);

        }

        public int CadastrarEndereco(Endereco endereco)
        {
            return _repository.CadastrarEndereco(endereco);
         }
    }
}
