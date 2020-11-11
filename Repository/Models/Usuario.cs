using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DublaPlay.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public string Nome  { get; set; }
        public string Genero { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }

    }
}
