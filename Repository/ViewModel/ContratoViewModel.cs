using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.ViewModel
{
    public class ContratoViewModel
    {
        public int idUsuario { get; set; }
        public int idEmpresa { get; set; }
        public int idOrcamento { get; set; }
        public int idContrato { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int StatusContrato { get; set; }
        public string Audio { get; set; }

    }
}
