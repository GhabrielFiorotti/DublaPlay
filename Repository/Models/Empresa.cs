using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DublaPlay.Models
{
    public class Empresa
    {
        [Key]
        public int idEmpresa { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public string Cnpj { get; set; }
        public string Senha { get; set; }
        public string NomeRazao { get; set; }

    }
}
