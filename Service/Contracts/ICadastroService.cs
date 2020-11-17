using DublaPlay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface ICadastroService
    {
        public int CadastrarUsuario(Usuario usuario);

        public int CadastrarEmpresa(Empresa empresa);
    }
}
