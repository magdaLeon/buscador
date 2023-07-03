using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDbApp2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    MateriaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NivelAcademico",
                columns: table => new
                {
                    NivelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelAcademico", x => x.NivelId);
                });

            migrationBuilder.CreateTable(
                name: "Decanato",
                columns: table => new
                {
                    DecanatoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    NivelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decanato", x => x.DecanatoId);
                    table.ForeignKey(
                        name: "FK_Decanato_NivelAcademico_NivelId",
                        column: x => x.NivelId,
                        principalTable: "NivelAcademico",
                        principalColumn: "NivelId");
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DeptoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DecanatoId = table.Column<int>(type: "INTEGER", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DeptoId);
                    table.ForeignKey(
                        name: "FK_Departamento_Decanato_DecanatoId",
                        column: x => x.DecanatoId,
                        principalTable: "Decanato",
                        principalColumn: "DecanatoId");
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    MateriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeptoId = table.Column<int>(type: "INTEGER", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    NivelASU = table.Column<string>(type: "TEXT", nullable: true),
                    CursosASU = table.Column<string>(type: "TEXT", nullable: true),
                    ObjetivoAprend = table.Column<string>(type: "TEXT", nullable: true),
                    Creditos = table.Column<string>(type: "TEXT", nullable: true),
                    FechaIni = table.Column<string>(type: "TEXT", nullable: true),
                    FechaActualizacion = table.Column<string>(type: "TEXT", nullable: true),
                    Version = table.Column<string>(type: "TEXT", nullable: true),
                    UrlCurso = table.Column<string>(type: "TEXT", nullable: true),
                    UrlDownload = table.Column<string>(type: "TEXT", nullable: true),
                    CodigoClase = table.Column<string>(type: "TEXT", nullable: true),
                    Term = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.MateriaId);
                    table.ForeignKey(
                        name: "FK_Materia_Departamento_DeptoId",
                        column: x => x.DeptoId,
                        principalTable: "Departamento",
                        principalColumn: "DeptoId");
                });

            migrationBuilder.InsertData(
                table: "NivelAcademico",
                columns: new[] { "NivelId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "EDUCACION BASICA" },
                    { 2, "EDUCACION MEDIA" },
                    { 3, "EDUCACION SUPERIOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Decanato_NivelId",
                table: "Decanato",
                column: "NivelId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_DecanatoId",
                table: "Departamento",
                column: "DecanatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_DeptoId",
                table: "Materia",
                column: "DeptoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Decanato");

            migrationBuilder.DropTable(
                name: "NivelAcademico");
        }
    }
}
