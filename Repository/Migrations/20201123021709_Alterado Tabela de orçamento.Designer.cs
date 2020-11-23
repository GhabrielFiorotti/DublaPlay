﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Models;

namespace Repository.Migrations
{
    [DbContext(typeof(DublaPlayContexto))]
    [Migration("20201123021709_Alterado Tabela de orçamento")]
    partial class AlteradoTabeladeorçamento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DublaPlay.Models.Contrato", b =>
                {
                    b.Property<int>("idContrato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Audio")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpresaidEmpresa")
                        .HasColumnType("int");

                    b.Property<int?>("OrcamentoidOrcamento")
                        .HasColumnType("int");

                    b.Property<int>("StatusContrato")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioidUsuario")
                        .HasColumnType("int");

                    b.HasKey("idContrato");

                    b.HasIndex("EmpresaidEmpresa");

                    b.HasIndex("OrcamentoidOrcamento");

                    b.HasIndex("UsuarioidUsuario");

                    b.ToTable("Contrato");
                });

            modelBuilder.Entity("DublaPlay.Models.Empresa", b =>
                {
                    b.Property<int>("idEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContatoidContato")
                        .HasColumnType("int");

                    b.Property<int?>("EnderecoidEndereco")
                        .HasColumnType("int");

                    b.Property<string>("NomeRazao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEmpresa");

                    b.HasIndex("ContatoidContato");

                    b.HasIndex("EnderecoidEndereco");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("DublaPlay.Models.Orcamento", b =>
                {
                    b.Property<int>("idOrcamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeAudio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SolicitacaoidSolicitacao")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioidUsuario")
                        .HasColumnType("int");

                    b.HasKey("idOrcamento");

                    b.HasIndex("SolicitacaoidSolicitacao");

                    b.HasIndex("UsuarioidUsuario");

                    b.ToTable("Orcamento");
                });

            modelBuilder.Entity("DublaPlay.Models.Solicitacao", b =>
                {
                    b.Property<int>("idSolicitacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpresaidEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("GeneroLoucutor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusSolicitacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("idSolicitacao");

                    b.HasIndex("EmpresaidEmpresa");

                    b.ToTable("Solicitacao");
                });

            modelBuilder.Entity("DublaPlay.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContatoidContato")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoidEndereco")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.HasIndex("ContatoidContato");

                    b.HasIndex("EnderecoidEndereco");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Repository.Models.Comentario", b =>
                {
                    b.Property<int>("idComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Corpo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.HasKey("idComentario");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("Repository.Models.Contato", b =>
                {
                    b.Property<int>("idContato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idContato");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("Repository.Models.Endereco", b =>
                {
                    b.Property<int>("idEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEndereco");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("DublaPlay.Models.Contrato", b =>
                {
                    b.HasOne("DublaPlay.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaidEmpresa");

                    b.HasOne("DublaPlay.Models.Orcamento", "Orcamento")
                        .WithMany()
                        .HasForeignKey("OrcamentoidOrcamento");

                    b.HasOne("DublaPlay.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioidUsuario");
                });

            modelBuilder.Entity("DublaPlay.Models.Empresa", b =>
                {
                    b.HasOne("Repository.Models.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("ContatoidContato");

                    b.HasOne("Repository.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoidEndereco");
                });

            modelBuilder.Entity("DublaPlay.Models.Orcamento", b =>
                {
                    b.HasOne("DublaPlay.Models.Solicitacao", "Solicitacao")
                        .WithMany()
                        .HasForeignKey("SolicitacaoidSolicitacao");

                    b.HasOne("DublaPlay.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioidUsuario");
                });

            modelBuilder.Entity("DublaPlay.Models.Solicitacao", b =>
                {
                    b.HasOne("DublaPlay.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaidEmpresa");
                });

            modelBuilder.Entity("DublaPlay.Models.Usuario", b =>
                {
                    b.HasOne("Repository.Models.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("ContatoidContato");

                    b.HasOne("Repository.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoidEndereco");
                });
#pragma warning restore 612, 618
        }
    }
}
