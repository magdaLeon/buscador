using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDbApp2.Migrations
{
    /// <inheritdoc />
    public partial class DecanatoDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decanato_NivelAcademico_NivelId",
                table: "Decanato");

            migrationBuilder.AlterColumn<int>(
                name: "NivelId",
                table: "Decanato",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Decanato",
                columns: new[] { "DecanatoId", "Descripcion", "NivelId" },
                values: new object[] { 1, "DCyT", 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Decanato_NivelAcademico_NivelId",
                table: "Decanato",
                column: "NivelId",
                principalTable: "NivelAcademico",
                principalColumn: "NivelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decanato_NivelAcademico_NivelId",
                table: "Decanato");

            migrationBuilder.DeleteData(
                table: "Decanato",
                keyColumn: "DecanatoId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "NivelId",
                table: "Decanato",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Decanato_NivelAcademico_NivelId",
                table: "Decanato",
                column: "NivelId",
                principalTable: "NivelAcademico",
                principalColumn: "NivelId");
        }
    }
}
