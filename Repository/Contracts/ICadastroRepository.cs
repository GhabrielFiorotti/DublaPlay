using DublaPlay.Models;
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
        public int CadastrarSolicitacao(Solicitacao solicitacao);
        public int CadastrarUsuario(Usuario usuario);

    }
}
