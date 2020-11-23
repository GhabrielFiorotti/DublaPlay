using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AlteradoTabeladeorçamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AudioPrevia",
                table: "Orcamento");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Orcamento");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Orcamento");

            migrationBuilder.AddColumn<string>(
                name: "NomeAudio",
                table: "Orcamento",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeAudio",
                table: "Orcamento");

            migrationBuilder.AddColumn<byte>(
                name: "AudioPrevia",
                table: "Orcamento",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Orcamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Orcamento",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
