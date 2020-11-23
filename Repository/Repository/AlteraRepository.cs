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
            Empresa returnEmpresa = _con.Empresa.Where(x => x.idEmpresa == empresa.idEmpresa).First();

            if (returnEmpresa != null)
            {
                returnEmpresa.Endereco = empresa.Endereco == null ? returnEmpresa.Endereco : empresa.Endereco;
                returnEmpresa.Contato = empresa.Contato == null ? returnEmpresa.Contato : empresa.Contato;

                _con.SaveChanges();

            }
            return returnEmpresa.idEmpresa;

        }

        public int AlterarOrcamento(Orcamento orcamento)
        {
            Orcamento returnOrcamento = _con.Orcamento.Where(x => x.idOrcamento == orcamento.idOrcamento).First();

            if (returnOrcamento != null)
            {
                returnOrcamento.NomeAudio = orcamento.NomeAudio == null ? returnOrcamento.NomeAudio : orcamento.NomeAudio;

                _con.SaveChanges();

            }
            return returnOrcamento.idOrcamento;
        }

        public int AlterarSolicitacao(Solicitacao solicitacao)
        {
            Solicitacao returnSolicitacao = _con.Solicitacao.Where(x => x.idSolicitacao == solicitacao.idSolicitacao).First();

            if (returnSolicitacao != null)
            {
                returnSolicitacao.Valor = solicitacao.Valor;

                _con.SaveChanges();

            }
            return returnSolicitacao.idSolicitacao;
        }

        public int AlterarUsuario(Usuario usuario)
        {
            Usuario returnUsuario = _con.Usuario.Where(x => x.idUsuario == usuario.idUsuario).First();

            if (returnUsuario != null)
            {
                returnUsuario.Endereco = usuario.Endereco;
                returnUsuario.Contato = usuario.Contato;

                _con.SaveChanges();

            }
            return returnUsuario.idUsuario;
        }
    }
}
