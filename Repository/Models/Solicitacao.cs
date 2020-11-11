using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DublaPlay.Models
{
    public class Solicitacao
    {
        [Key]
        public int idSolicitacao { get; set; }
        public Empresa Empresa { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string StatusSolicitacao { get; set; }
        public decimal Valor { get; set; }
        public string GeneroLoucutor { get; set; }
    }
}
