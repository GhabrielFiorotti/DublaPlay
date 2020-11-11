using DublaPlay.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class DublaPlayContexto: DbContext
    {
        [Key]
        public int DbContextId { get; set; }

        [NotMapped]
        private IConfiguration _conf { get; set; }

        public DublaPlayContexto(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _conf = configuration;
        }

        public DublaPlayContexto() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conf.GetConnectionString("myconn"));
        }

        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Orcamento> Orcamento { get; set; }
        public DbSet<Solicitacao> Solicitacao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
