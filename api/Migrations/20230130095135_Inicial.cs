using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAcc.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Perfis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfis", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Versoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroVersao = table.Column<int>(type: "int", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Versoes_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "varchar(60)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PerfilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Perfis_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Regras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorasPorCertificado = table.Column<int>(type: "int", nullable: false),
                    MaximoDeHoras = table.Column<int>(type: "int", nullable: false),
                    VersaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regras_Versoes_VersaoId",
                        column: x => x.VersaoId,
                        principalTable: "Versoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuariosCurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalDeHoras = table.Column<decimal>(type: "Decimal(4,1)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    VersaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosCurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuariosCurso_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosCurso_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosCurso_Versoes_VersaoId",
                        column: x => x.VersaoId,
                        principalTable: "Versoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Submissoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Horas = table.Column<decimal>(type: "Decimal(4,1)", nullable: false),
                    Caminho = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioCursoId = table.Column<int>(type: "int", nullable: false),
                    RegraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Submissoes_Regras_RegraId",
                        column: x => x.RegraId,
                        principalTable: "Regras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Submissoes_UsuariosCurso_UsuarioCursoId",
                        column: x => x.UsuarioCursoId,
                        principalTable: "UsuariosCurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Regras_VersaoId",
                table: "Regras",
                column: "VersaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissoes_RegraId",
                table: "Submissoes",
                column: "RegraId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissoes_UsuarioCursoId",
                table: "Submissoes",
                column: "UsuarioCursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PerfilId",
                table: "Usuarios",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosCurso_CursoId",
                table: "UsuariosCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosCurso_UsuarioId",
                table: "UsuariosCurso",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosCurso_VersaoId",
                table: "UsuariosCurso",
                column: "VersaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Versoes_CursoId",
                table: "Versoes",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Submissoes");

            migrationBuilder.DropTable(
                name: "Regras");

            migrationBuilder.DropTable(
                name: "UsuariosCurso");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Versoes");

            migrationBuilder.DropTable(
                name: "Perfis");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
