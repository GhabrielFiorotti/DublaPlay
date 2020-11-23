using DublaPlay.Models;
using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface ICadastroRepository
    {
        public int CadastrarContrato(Contrato contrato);
        public int CadastrarEmpresa(Empresa empresa);
        public int CadastrarOrcamento(Orcamento orcamento);
        public int CadastrarSolicitacao(SolicitacaoViewModel solicitacao);
        public int CadastrarUsuario(Usuario usuario);
        public int CadastrarEndereco(Endereco endereco);
    }
}
