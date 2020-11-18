using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class DeletaRepository : IDeletaRepository
    {

        private DublaPlayContexto _con { get; set; }

        public DeletaRepository(DublaPlayContexto con)
        {
            _con = con;
        }

        public bool DeletarContrato(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeletarEmpresa(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeletarOrcamento(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeletarSolicitacao(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeletarUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
