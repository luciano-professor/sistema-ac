using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAcc.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoAtributos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HorasPorCertificado",
                table: "Regras",
                newName: "MaximoHorasPorCertificado");

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "UsuariosCurso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mes",
                table: "UsuariosCurso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "CargaContabilizada",
                table: "Submissoes",
                type: "decimal(4,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Submissoes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Submissoes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeEmissao",
                table: "Submissoes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Submissoes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Submissoes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Submissoes",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "CargaHorarioFixa",
                table: "Regras",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Regras",
                type: "text",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Documentacao",
                table: "Regras",
                type: "text",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "UsuariosCurso");

            migrationBuilder.DropColumn(
                name: "Mes",
                table: "UsuariosCurso");

            migrationBuilder.DropColumn(
                name: "CargaContabilizada",
                table: "Submissoes");

            migrationBuilder.DropColumn(
                name: "DataDeAtualizacao",
                table: "Submissoes");

            migrationBuilder.DropColumn(
                name: "DataDeCriacao",
                table: "Submissoes");

            migrationBuilder.DropColumn(
                name: "DataDeEmissao",
                table: "Submissoes");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Submissoes");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Submissoes");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Submissoes");

            migrationBuilder.DropColumn(
                name: "CargaHorarioFixa",
                table: "Regras");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Regras");

            migrationBuilder.DropColumn(
                name: "Documentacao",
                table: "Regras");

            migrationBuilder.RenameColumn(
                name: "MaximoHorasPorCertificado",
                table: "Regras",
                newName: "HorasPorCertificado");
        }
    }
}
