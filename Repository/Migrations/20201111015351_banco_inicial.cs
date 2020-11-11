using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class banco_inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    idComentario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Corpo = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.idComentario);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    idContato = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.idContato);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    idEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.idEndereco);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    idEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnderecoidEndereco = table.Column<int>(nullable: true),
                    ContatoidContato = table.Column<int>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    NomeRazao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.idEmpresa);
                    table.ForeignKey(
                        name: "FK_Empresa_Contato_ContatoidContato",
                        column: x => x.ContatoidContato,
                        principalTable: "Contato",
                        principalColumn: "idContato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresa_Endereco_EnderecoidEndereco",
                        column: x => x.EnderecoidEndereco,
                        principalTable: "Endereco",
                        principalColumn: "idEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnderecoidEndereco = table.Column<int>(nullable: true),
                    ContatoidContato = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Contato_ContatoidContato",
                        column: x => x.ContatoidContato,
                        principalTable: "Contato",
                        principalColumn: "idContato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Endereco_EnderecoidEndereco",
                        column: x => x.EnderecoidEndereco,
                        principalTable: "Endereco",
                        principalColumn: "idEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Solicitacao",
                columns: table => new
                {
                    idSolicitacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaidEmpresa = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    StatusSolicitacao = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    GeneroLoucutor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitacao", x => x.idSolicitacao);
                    table.ForeignKey(
                        name: "FK_Solicitacao_Empresa_EmpresaidEmpresa",
                        column: x => x.EmpresaidEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "idEmpresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orcamento",
                columns: table => new
                {
                    idOrcamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioidUsuario = table.Column<int>(nullable: true),
                    SolicitacaoidSolicitacao = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    AudioPrevia = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamento", x => x.idOrcamento);
                    table.ForeignKey(
                        name: "FK_Orcamento_Solicitacao_SolicitacaoidSolicitacao",
                        column: x => x.SolicitacaoidSolicitacao,
                        principalTable: "Solicitacao",
                        principalColumn: "idSolicitacao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orcamento_Usuario_UsuarioidUsuario",
                        column: x => x.UsuarioidUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    idContrato = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioidUsuario = table.Column<int>(nullable: true),
                    EmpresaidEmpresa = table.Column<int>(nullable: true),
                    OrcamentoidOrcamento = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    StatusContrato = table.Column<int>(nullable: false),
                    Audio = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.idContrato);
                    table.ForeignKey(
                        name: "FK_Contrato_Empresa_EmpresaidEmpresa",
                        column: x => x.EmpresaidEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "idEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contrato_Orcamento_OrcamentoidOrcamento",
                        column: x => x.OrcamentoidOrcamento,
                        principalTable: "Orcamento",
                        principalColumn: "idOrcamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contrato_Usuario_UsuarioidUsuario",
                        column: x => x.UsuarioidUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_EmpresaidEmpresa",
                table: "Contrato",
                column: "EmpresaidEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_OrcamentoidOrcamento",
                table: "Contrato",
                column: "OrcamentoidOrcamento");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_UsuarioidUsuario",
                table: "Contrato",
                column: "UsuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_ContatoidContato",
                table: "Empresa",
                column: "ContatoidContato");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EnderecoidEndereco",
                table: "Empresa",
                column: "EnderecoidEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_SolicitacaoidSolicitacao",
                table: "Orcamento",
                column: "SolicitacaoidSolicitacao");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_UsuarioidUsuario",
                table: "Orcamento",
                column: "UsuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitacao_EmpresaidEmpresa",
                table: "Solicitacao",
                column: "EmpresaidEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ContatoidContato",
                table: "Usuario",
                column: "ContatoidContato");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EnderecoidEndereco",
                table: "Usuario",
                column: "EnderecoidEndereco");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Orcamento");

            migrationBuilder.DropTable(
                name: "Solicitacao");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
