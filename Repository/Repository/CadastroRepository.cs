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
            _con.Add(usuario);
            _con.SaveChanges();

            return usuario.idUsuario;
        }
    }
}
