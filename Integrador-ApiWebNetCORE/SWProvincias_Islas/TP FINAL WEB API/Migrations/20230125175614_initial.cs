using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_FINAL_WEB_API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    IdProvincia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.IdProvincia);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    IdProvincia = table.Column<int>(nullable: false),
                    provinciaIdProvincia = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.IdCiudad);
                    table.ForeignKey(
                        name: "FK_Ciudades_Provincia_provinciaIdProvincia",
                        column: x => x.provinciaIdProvincia,
                        principalTable: "Provincia",
                        principalColumn: "IdProvincia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_provinciaIdProvincia",
                table: "Ciudades",
                column: "provinciaIdProvincia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Provincia");
        }
    }
}
