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

        public List<Solicitacao> BuscarSolicitacaoPorEmpresa(int page, int size, int idEmpresa)
        {
            return _repository.BuscarSolicitacaoPorEmpresa(page, size, idEmpresa);
        }

        public List<Solicitacao> BuscarSolicitacaoAberto(int page, int size)
        {
            return _repository.BuscarSolicitacaoAberto(page, size);
        }

        public List<Contrato> BuscarContratos(int page, int size)
        {
            return _repository.BuscarContratos(page, size);
        }

        public List<Empresa> BuscarEmpresas(int page, int size)
        {
            return _repository.BuscarEmpresas(page, size);
        }

        public List<Orcamento> BuscarOrcamentos(int page, int size)
        {
            return _repository.BuscarOrcamentos(page, size);

        }

        public List<Solicitacao> BuscarSolicitacoes(int page, int size)
        {
            return _repository.BuscarSolicitacoes(page, size);

        }

        public List<Usuario> BuscarUsuarios(int page, int size)
        {

            return _repository.BuscarUsuarios(page, size);

        }
    }
}
