using DublaPlay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IBuscaRepository
    {
        Contrato BuscarContrato(Contrato contrato);
        Empresa BuscarEmpresa(Empresa empresa);
        Orcamento BuscarOrcamento(Orcamento orcamento);
        Solicitacao BuscarSolicitacao(Solicitacao solicitacao);
        Usuario BuscarUsuario(Usuario usuario);
        List<Solicitacao> BuscarSolicitacaoPorEmpresa(int page, int size, int idEmpresa);
        List<Orcamento> BuscarSolicitacaoPorOrcamento(int page, int size, int idSolicitacao);
        List<Solicitacao> BuscarSolicitacaoAberto(int page, int size);
        List<Contrato> BuscarContratos(int page, int size);
        List<Empresa> BuscarEmpresas(int page, int size);
        List<Orcamento> BuscarOrcamentos(int page, int size);
        List<Solicitacao> BuscarSolicitacoes(int page, int size);
        List<Usuario> BuscarUsuarios(int page, int size);
    }
}
