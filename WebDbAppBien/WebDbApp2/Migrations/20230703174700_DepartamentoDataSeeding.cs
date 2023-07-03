using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDbApp2.Migrations
{
    /// <inheritdoc />
    public partial class DepartamentoDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Decanato_DecanatoId",
                table: "Departamento");

            migrationBuilder.AlterColumn<int>(
                name: "DecanatoId",
                table: "Departamento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "DeptoId", "DecanatoId", "Descripcion" },
                values: new object[] { 1, 1, "Ciencias Computacionales" });

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Decanato_DecanatoId",
                table: "Departamento",
                column: "DecanatoId",
                principalTable: "Decanato",
                principalColumn: "DecanatoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Decanato_DecanatoId",
                table: "Departamento");

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "DeptoId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "DecanatoId",
                table: "Departamento",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Decanato_DecanatoId",
                table: "Departamento",
                column: "DecanatoId",
                principalTable: "Decanato",
                principalColumn: "DecanatoId");
        }
    }
}
