using DublaPlay.Models;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _con.Contrato.Where(x => x.idContrato == contrato.idContrato).FirstOrDefault();
        }

        public Empresa BuscarEmpresa(Empresa empresa)
        {
            return _con.Empresa.Where(x => x.Cnpj == empresa.Cnpj && x.Senha == empresa.Senha).FirstOrDefault();
        }

        public Orcamento BuscarOrcamento(Orcamento orcamento)
        {
            return _con.Orcamento.Where(x => x.idOrcamento == orcamento.idOrcamento).FirstOrDefault();
        }

        public Solicitacao BuscarSolicitacao(Solicitacao solicitacao)
        {
            return _con.Solicitacao.Where(x => x.idSolicitacao == solicitacao.idSolicitacao).FirstOrDefault();
        }
        public Solicitacao BuscarSolicitacaoPorId(Empresa empresa)
        {
            return _con.Solicitacao.Where(x => x.Empresa.idEmpresa == empresa.idEmpresa).FirstOrDefault();
        }

        public List<Solicitacao> BuscarSolicitacaoAberto(int page, int size)
        {
            return _con.Solicitacao
                    .Skip((page - 1) * size)
                    .Take(size)
                    .Where(x => x.StatusSolicitacao == "A")
                    .ToList();
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {

            return _con.Usuario.Where(x => x.Cpf == usuario.Cpf && x.Senha == usuario.Senha).FirstOrDefault();

        }

        public List<Contrato> BuscarContratos(int page, int size)
        {
            return _con.Contrato
                      .Skip((page - 1) * size)
                      .Take(size)
                      .ToList();
        }

        public List<Empresa> BuscarEmpresas(int page, int size)
        {
            return _con.Empresa
                       .Skip((page - 1) * size)
                       .Take(size)
                       .ToList();
        }

        public List<Orcamento> BuscarOrcamentos(int page, int size)
        {
            return _con.Orcamento
                      .Skip((page - 1) * size)
                      .Take(size)
                      .ToList();
        }

        public List<Solicitacao> BuscarSolicitacoes(int page, int size)
        {
            return _con.Solicitacao
                      .Skip((page - 1) * size)
                      .Take(size)
                      .ToList();
        }

        public List<Usuario> BuscarUsuarios(int page, int size)
        {
            return _con.Usuario
                        .Skip((page - 1) * size)
                        .Take(size)
                        .ToList();
        }
                
    }
}
