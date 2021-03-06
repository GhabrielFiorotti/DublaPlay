﻿using DublaPlay.Models;
using Repository.Models;
using Repository.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface ICadastroService
    {
        public int CadastrarContrato(ContratoViewModel contrato);
        public int CadastrarEmpresa(Empresa empresa);
        public int CadastrarOrcamento(OrcamentoViewModel orcamento);
        public int CadastrarSolicitacao(SolicitacaoViewModel solicitacao);
        public int CadastrarUsuario(Usuario usuario);
        public int CadastrarEndereco(Endereco endereco);
    }
}
