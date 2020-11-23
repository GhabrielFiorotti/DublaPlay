using DublaPlay.Models;
using Repository.Models;
using Repository.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface ICadastroRepository
    {
        public int CadastrarContrato(ContratoViewModel contrato);
        public int CadastrarEmpresa(Empresa empresa);
        public int CadastrarOrcamento(OrcamentoViewModel orcamento);
        public int CadastrarSolicitacao(SolicitacaoViewModel solicitacao);
        public int CadastrarUsuario(Usuario usuario);
        public int CadastrarEndereco(Endereco endereco);
    }
}
