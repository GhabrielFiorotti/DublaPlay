using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Contato
    {
        [Key]
        public int idContato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
