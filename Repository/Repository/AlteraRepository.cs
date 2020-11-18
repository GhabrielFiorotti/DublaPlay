using DublaPlay.Models;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class AlteraRepository : IAlteraRepository
    {
        private DublaPlayContexto _con { get; set; }

        public AlteraRepository(DublaPlayContexto con)
        {
            _con = con;
        }

        public int AlterarContrato(Contrato contrato)
        {
            throw new NotImplementedException();
        }

        public int AlterarEmpresa(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public int AlterarOrcamento(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public int AlterarSolicitacao(Solicitacao solicitacao)
        {
            throw new NotImplementedException();
        }

        public int AlterarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
