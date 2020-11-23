using DublaPlay.Models;
using Repository.Contracts;
using Repository.Models;
using Repository.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class CadastroRepository : ICadastroRepository
    {
        private DublaPlayContexto _con { get; set; }

        public CadastroRepository(DublaPlayContexto con)
        {
            _con = con;
        }

        public int CadastrarUsuario(Usuario usuario)
        {
            _con.Add(usuario);
            _con.SaveChanges();

            return usuario.idUsuario;
        }
        public int CadastrarEmpresa(Empresa empresa)
        {
            _con.Add(empresa);
            _con.SaveChanges();

            return empresa.idEmpresa;
        }

        public int CadastrarEndereco(Endereco endereco)
        {
            _con.Add(endereco);
            _con.SaveChanges();

            return endereco.idEndereco;
        }

        public int CadastrarContrato(ContratoViewModel contrato)
        {
            var empresa = _con.Empresa.Where(x => x.idEmpresa == contrato.idEmpresa).FirstOrDefault();
            var usuario = _con.Usuario.Where(x => x.idUsuario == contrato.idUsuario).FirstOrDefault();
            var orcamento = _con.Orcamento.Where(x => x.idOrcamento == contrato.idOrcamento).FirstOrDefault();

            Contrato contratoInsert = new Contrato
            {
                Usuario = usuario,
                Empresa = empresa,
                Orcamento = orcamento,
                Data = DateTime.Now,
                Descricao = contrato.Descricao,
                StatusContrato = contrato.StatusContrato,
                Audio = contrato.Audio

            };

            _con.Add(contratoInsert);
            _con.SaveChanges();

            return contratoInsert.idContrato;
        }

        public int CadastrarOrcamento(OrcamentoViewModel orcamento)
        {

            var solicitacao = _con.Solicitacao.Where(x => x.idSolicitacao == orcamento.idSolicitacao).FirstOrDefault();
            var usuario = _con.Usuario.Where(x => x.idUsuario == orcamento.idUsuario).FirstOrDefault();

            Orcamento orcamentoInsert = new Orcamento
            {
                Solicitacao = solicitacao,
                Usuario = usuario,
                NomeAudio = orcamento.nomeAudio

            };

            _con.Add(orcamentoInsert);
            _con.SaveChanges();

            return orcamentoInsert.idOrcamento;
        }

        public int CadastrarSolicitacao(SolicitacaoViewModel solicitacao)
        {

            var empresa = _con.Empresa.Where(x => x.idEmpresa == solicitacao.idEmpresa).FirstOrDefault();

            Solicitacao solicitacaoInsert = new Solicitacao
            {
                Data = DateTime.Now,
                Descricao = solicitacao.Descricao,
                StatusSolicitacao = solicitacao.StatusSolicitacao,
                Valor = solicitacao.Valor,
                GeneroLoucutor = solicitacao.GeneroLoucutor,
                Empresa = empresa
            };

            _con.Add(solicitacaoInsert);
            _con.SaveChanges();

            return solicitacaoInsert.idSolicitacao;
        }

        
    }
}
