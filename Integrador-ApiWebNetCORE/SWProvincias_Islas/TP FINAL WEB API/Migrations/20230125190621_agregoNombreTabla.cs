using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_FINAL_WEB_API.Migrations
{
    public partial class agregoNombreTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Provincia_provinciaIdProvincia",
                table: "Ciudades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades");

            migrationBuilder.RenameTable(
                name: "Ciudades",
                newName: "Ciudad");

            migrationBuilder.RenameIndex(
                name: "IX_Ciudades_provinciaIdProvincia",
                table: "Ciudad",
                newName: "IX_Ciudad_provinciaIdProvincia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudad",
                table: "Ciudad",
                column: "IdCiudad");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudad_Provincia_provinciaIdProvincia",
                table: "Ciudad",
                column: "provinciaIdProvincia",
                principalTable: "Provincia",
                principalColumn: "IdProvincia",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudad_Provincia_provinciaIdProvincia",
                table: "Ciudad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudad",
                table: "Ciudad");

            migrationBuilder.RenameTable(
                name: "Ciudad",
                newName: "Ciudades");

            migrationBuilder.RenameIndex(
                name: "IX_Ciudad_provinciaIdProvincia",
                table: "Ciudades",
                newName: "IX_Ciudades_provinciaIdProvincia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades",
                column: "IdCiudad");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Provincia_provinciaIdProvincia",
                table: "Ciudades",
                column: "provinciaIdProvincia",
                principalTable: "Provincia",
                principalColumn: "IdProvincia",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
