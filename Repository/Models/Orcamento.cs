using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DublaPlay.Models
{
    public class Orcamento
    {
        [Key]
        public int idOrcamento { get; set; }
        public Usuario Usuario { get; set; }
        public Solicitacao Solicitacao { get; set; }
   
        public string NomeAudio { get; set; }
    }
}
