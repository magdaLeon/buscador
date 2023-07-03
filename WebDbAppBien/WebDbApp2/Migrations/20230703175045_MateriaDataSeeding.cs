using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDbApp2.Migrations
{
    /// <inheritdoc />
    public partial class MateriaDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materia_Departamento_DeptoId",
                table: "Materia");

            migrationBuilder.DropIndex(
                name: "IX_Materia_DeptoId",
                table: "Materia");

            migrationBuilder.DropColumn(
                name: "DeptoId",
                table: "Materia");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Materia",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Materia",
                columns: new[] { "MateriaId", "CodigoClase", "Creditos", "CursosASU", "DepartamentoId", "Descripcion", "FechaActualizacion", "FechaIni", "NivelASU", "ObjetivoAprend", "Term", "UrlCurso", "UrlDownload", "Version" },
                values: new object[] { 1, null, null, null, 1, "Redes I", null, null, null, null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Materia_DepartamentoId",
                table: "Materia",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materia_Departamento_DepartamentoId",
                table: "Materia",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "DeptoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materia_Departamento_DepartamentoId",
                table: "Materia");

            migrationBuilder.DropIndex(
                name: "IX_Materia_DepartamentoId",
                table: "Materia");

            migrationBuilder.DeleteData(
                table: "Materia",
                keyColumn: "MateriaId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Materia");

            migrationBuilder.AddColumn<int>(
                name: "DeptoId",
                table: "Materia",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materia_DeptoId",
                table: "Materia",
                column: "DeptoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materia_Departamento_DeptoId",
                table: "Materia",
                column: "DeptoId",
                principalTable: "Departamento",
                principalColumn: "DeptoId");
        }
    }
}
