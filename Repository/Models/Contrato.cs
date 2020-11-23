using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DublaPlay.Models
{
    public class Contrato
    {
        [Key]
        public int idContrato { get; set; }
        public Usuario Usuario { get; set; }
        public Empresa Empresa { get; set; }
        public Orcamento Orcamento { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int StatusContrato { get; set; }
        public string Audio { get; set; }
    }
}
