using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface IDeletaService
    {
        public bool DeletarContrato(int id);
        public bool DeletarEmpresa(int id);
        public bool DeletarOrcamento(int id);
        public bool DeletarSolicitacao(int id);
        public bool DeletarUsuario(int id);
    }
}
