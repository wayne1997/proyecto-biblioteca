using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProyectoIntegrador.Data.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "titulos",
                columns: table => new
                {
                    TitulosID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nombre = table.Column<string>(nullable: true),
                    ISBN = table.Column<string>(nullable: true),
                    Edicion = table.Column<string>(nullable: true),
                    Fecha_lanzamiento = table.Column<DateTime>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    DirectorioPortada = table.Column<string>(nullable: true),
                    UrlReview = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titulos", x => x.TitulosID);
                });

            migrationBuilder.CreateTable(
                name: "ejemplares",
                columns: table => new
                {
                    EjemplarID = table.Column<string>(maxLength: 10, nullable: false),
                    EstadoBibliografico = table.Column<bool>(nullable: false),
                    Disponibilidad = table.Column<bool>(nullable: false),
                    TitulosID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ejemplares", x => x.EjemplarID);
                    table.ForeignKey(
                        name: "FK_ejemplares_titulos_TitulosID",
                        column: x => x.TitulosID,
                        principalTable: "titulos",
                        principalColumn: "TitulosID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ejemplares_TitulosID",
                table: "ejemplares",
                column: "TitulosID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ejemplares");

            migrationBuilder.DropTable(
                name: "titulos");
        }
    }
}
