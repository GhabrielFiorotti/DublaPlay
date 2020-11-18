﻿using DublaPlay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface IBuscaService
    {
        public Contrato BuscarContrato(Contrato contrato);
        public Empresa BuscarEmpresa(Empresa empresa);
        public Orcamento BuscarOrcamento(Orcamento orcamento);
        public Solicitacao BuscarSolicitacao(Solicitacao solicitacao);
        public Usuario BuscarUsuario(Usuario usuario);
    }
}
