using DublaPlay.Models;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Contrato returnContrato = _con.Contrato.Where(x => x.idContrato == contrato.idContrato).First();

            if (returnContrato != null)
            {
                returnContrato.Orcamento = contrato.Orcamento == null ? returnContrato.Orcamento : contrato.Orcamento;
                returnContrato.StatusContrato = contrato.StatusContrato == 0 ? returnContrato.StatusContrato : contrato.StatusContrato;
                returnContrato.Descricao = contrato.Descricao == null ? returnContrato.Descricao : contrato.Descricao;

                _con.SaveChanges();

            }
            return returnContrato.idContrato;
        }

        public int AlterarEmpresa(Empresa empresa)
        {
            Empresa returnEmpresa = _con.Contrato.Where(x => x.idContrato == contrato.idContrato).First();

            if (returnContrato != null)
            {
                returnContrato.Orcamento = contrato.Orcamento == null ? returnContrato.Orcamento : contrato.Orcamento;
                returnContrato.StatusContrato = contrato.StatusContrato == 0 ? returnContrato.StatusContrato : contrato.StatusContrato;
                returnContrato.Descricao = contrato.Descricao == null ? returnContrato.Descricao : contrato.Descricao;

                _con.SaveChanges();

            }
            return returnContrato.idContrato;

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
