using DublaPlay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface IAlteraService
    {
        public int AlterarContrato(Contrato contrato);
        public int AlterarEmpresa(Empresa empresa);
        public int AlterarOrcamento(Orcamento orcamento);
        public int AlterarSolicitacao(Solicitacao solicitacao);
        public int AlterarUsuario(Usuario usuario);
    }
}
