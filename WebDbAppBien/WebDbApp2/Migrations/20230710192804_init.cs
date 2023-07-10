using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDbApp2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Decanato",
                columns: table => new
                {
                    DecanatoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decanato", x => x.DecanatoId);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DeptoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DecanatoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DeptoId);
                    table.ForeignKey(
                        name: "FK_Departamento_Decanato_DecanatoId",
                        column: x => x.DecanatoId,
                        principalTable: "Decanato",
                        principalColumn: "DecanatoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    MateriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    NivelAsu = table.Column<string>(type: "TEXT", nullable: true),
                    CursosAsu = table.Column<string>(type: "TEXT", nullable: true),
                    ObjetivoAprend = table.Column<string>(type: "TEXT", nullable: true),
                    Creditos = table.Column<string>(type: "TEXT", nullable: true),
                    FechaIni = table.Column<string>(type: "TEXT", nullable: true),
                    FechaActualizacion = table.Column<string>(type: "TEXT", nullable: true),
                    Version = table.Column<string>(type: "TEXT", nullable: true),
                    UrlCurso = table.Column<string>(type: "TEXT", nullable: true),
                    UrlDownload = table.Column<string>(type: "TEXT", nullable: true),
                    CodigoClase = table.Column<string>(type: "TEXT", nullable: true),
                    Periodo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.MateriaId);
                    table.ForeignKey(
                        name: "FK_Materia_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "DeptoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Decanato",
                columns: new[] { "DecanatoId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Diseño, Ciencia y Tecnología" },
                    { 2, "CIENCIAS SOCIALES ECONÓMICA Y ADMINISTRATIVAS" },
                    { 3, "CIENCIAS DE LA SALUD" },
                    { 4, "POSGRADO" },
                    { 5, "EDUCACIÓN CONTINUA" },
                    { 6, "EDUCACIÓN MEDIA SUPERIOR" },
                    { 7, "EDUCACIÓN BÁSICA" },
                    { 8, "PROGRAMAS EN LINEA" }
                });

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "DeptoId", "DecanatoId", "Descripcion" },
                values: new object[,]
                {
                    { 1, 1, "ARTE Y DISEÑO" },
                    { 2, 1, "BIOTECNOLOGICAS Y AMBIENTALES" },
                    { 3, 1, "Computación e Industrial" },
                    { 4, 1, "DISEÑO Y CONSTRUCCION" },
                    { 5, 1, "ELECTROMECANICA" },
                    { 6, 1, "INNOVACIÓN SOSTENIBLE" }
                });

            migrationBuilder.InsertData(
                table: "Materia",
                columns: new[] { "MateriaId", "CodigoClase", "Creditos", "CursosAsu", "DepartamentoId", "Descripcion", "FechaActualizacion", "FechaIni", "NivelAsu", "ObjetivoAprend", "Periodo", "UrlCurso", "UrlDownload", "Version" },
                values: new object[,]
                {
                    { 1, "7032", null, null, 1, "Creatividad para el diseño - 7032, SM: 2022, Jul – Dic", null, null, null, null, "2222", "https://uag.instructure.com/courses/5021", "https://uag.instructure.com/courses/5021/content_exports", null },
                    { 2, "840", null, null, 2, "Taller de Eval de Form Term - 840, CT: 2021, May – Ago", null, null, null, null, "2132", "https://uag.instructure.com/courses/21786", "https://uag.instructure.com/courses/21786/content_exports", null },
                    { 3, "4406", null, null, 3, "Creatividad para el diseño - 7032, SM: 2022, Jul – Dic", null, null, null, null, "2221", "https://uag.instructure.com/courses/2115", "https://uag.instructure.com/courses/2115/content_exports", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_DecanatoId",
                table: "Departamento",
                column: "DecanatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_DepartamentoId",
                table: "Materia",
                column: "DepartamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Decanato");
        }
    }
}
