using DublaPlay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface IBuscaService
    {
        public Contrato BuscarContrato(Contrato contrato);
        public Empresa BuscarEmpresa(Empresa empresa);
        public Orcamento BuscarOrcamento(Orcamento orcamento);
        public Solicitacao BuscarSolicitacao(Solicitacao solicitacao);
        public Usuario BuscarUsuario(Usuario usuario);
        List<Solicitacao> BuscarSolicitacaoAberto(int page, int size);
        List<Contrato> BuscarContratos(int page, int size);
        List<Empresa> BuscarEmpresas(int page, int size);
        List<Orcamento> BuscarOrcamentos(int page, int size);
        List<Solicitacao> BuscarSolicitacoes(int page, int size);
        List<Usuario> BuscarUsuarios(int page, int size);
    }
}
