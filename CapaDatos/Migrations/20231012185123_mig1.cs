using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CapaDatos.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hechos",
                columns: table => new
                {
                    Hora = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    colorFondo = table.Column<long>(type: "bigint", nullable: false),
                    colorTexto = table.Column<long>(type: "bigint", nullable: false),
                    Mensaje = table.Column<string>(type: "text", nullable: true),
                    Like = table.Column<bool>(type: "boolean", nullable: false),
                    Resultado = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hechos", x => x.Hora);
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    Hora = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    colorFondo = table.Column<long>(type: "bigint", nullable: false),
                    colorTexto = table.Column<long>(type: "bigint", nullable: false),
                    Mensaje = table.Column<string>(type: "text", nullable: true),
                    Like = table.Column<bool>(type: "boolean", nullable: false),
                    Ip = table.Column<string>(type: "text", nullable: true),
                    Genero = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.Hora);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hechos");

            migrationBuilder.DropTable(
                name: "Publicaciones");
        }
    }
}
