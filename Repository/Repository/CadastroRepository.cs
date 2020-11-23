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

        public int CadastrarContrato(Contrato contrato)
        {
            throw new NotImplementedException();
        }

        public int CadastrarOrcamento(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public int CadastrarSolicitacao(SolicitacaoViewModel solicitacao)
        {


            Solicitacao solicitaaco = new Solicitacao
            {
                Empresa = _con.Empresa.Where(x => x.idEmpresa == solicitacao.idEmpresa).First()
            };

            _con.Add(solicitacao);
            _con.SaveChanges();

            return 0;
        }

    }
}
