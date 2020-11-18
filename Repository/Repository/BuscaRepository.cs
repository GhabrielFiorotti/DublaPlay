using DublaPlay.Models;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class BuscaRepository : IBuscaRepository
    {

        private DublaPlayContexto _con { get; set; }

        public BuscaRepository(DublaPlayContexto con)
        {
            _con = con;
        }

        public Contrato BuscarContrato(Contrato contrato)
        {
            throw new NotImplementedException();
        }

        public Empresa BuscarEmpresa(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public Orcamento BuscarOrcamento(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public Solicitacao BuscarSolicitacao(Solicitacao solicitacao)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
