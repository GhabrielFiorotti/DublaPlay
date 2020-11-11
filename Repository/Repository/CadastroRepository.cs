using DublaPlay.Models;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class CadastroRepository: ICadastroRepository
    {
        private DublaPlayContexto _con { get; set; }

        public CadastroRepository(DublaPlayContexto con)
        {
            _con = con;
        }

        public int CadastrarUsuario(Usuario usuario)
        {
            //Aqui vc faz suas querys para cadastrar as coisas no banco usando o _con
            throw new NotImplementedException();
        }
    }
}
