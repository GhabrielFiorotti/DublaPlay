using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Comentario
    {
        [Key]
        public int idComentario { get; set; }
        public string Corpo { get; set; }
        public DateTime Data { get; set; }
    }
}
