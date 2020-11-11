using DublaPlay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface ICadastroRepository
    {
        public int CadastrarUsuario(Usuario usuario);
    }
}
