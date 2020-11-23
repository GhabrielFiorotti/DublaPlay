using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.DTO
{
    public class SolicitacaoViewModel
    {
        public int idSolicitacao { get; set; }
        public int Empresa { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string StatusSolicitacao { get; set; }
        public decimal Valor { get; set; }
        public string GeneroLoucutor { get; set; }
    }
}
