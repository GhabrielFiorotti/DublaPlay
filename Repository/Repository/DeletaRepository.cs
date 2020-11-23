using DublaPlay.Models;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Contrato contrato = _con.Contrato.Where(x => x.idContrato == id).First();
            _con.Contrato.Remove(contrato);
            try
            {
                _con.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool DeletarEmpresa(int id)
        {
            Empresa empresa = _con.Empresa.Where(x => x.idEmpresa == id).First();
            _con.Empresa.Remove(empresa);
            try
            {
                _con.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletarOrcamento(int id)
        {
            Orcamento orcamento = _con.Orcamento.Where(x => x.idOrcamento == id).First();
            _con.Orcamento.Remove(orcamento);
            try
            {
                _con.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletarSolicitacao(int id)
        {
            Solicitacao solicitacao = _con.Solicitacao.Where(x => x.idSolicitacao == id).First();
            _con.Solicitacao.Remove(solicitacao);
            try
            {
                _con.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletarUsuario(int id)
        {
            Usuario usuario = _con.Usuario.Where(x => x.idUsuario == id).First();
            _con.Usuario.Remove(usuario);
            try
            {
                _con.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
