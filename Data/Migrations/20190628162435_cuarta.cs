using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProyectoIntegrador.Data.Migrations
{
    public partial class cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ejemplares_titulos_TitulosID",
                table: "ejemplares");

            migrationBuilder.DropPrimaryKey(
                name: "PK_titulos",
                table: "titulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ejemplares",
                table: "ejemplares");

            migrationBuilder.RenameTable(
                name: "titulos",
                newName: "Titulos");

            migrationBuilder.RenameTable(
                name: "ejemplares",
                newName: "Ejemplares");

            migrationBuilder.RenameColumn(
                name: "TitulosID",
                table: "Titulos",
                newName: "TituloID");

            migrationBuilder.RenameColumn(
                name: "TitulosID",
                table: "Ejemplares",
                newName: "TituloID");

            migrationBuilder.RenameIndex(
                name: "IX_ejemplares_TitulosID",
                table: "Ejemplares",
                newName: "IX_Ejemplares_TituloID");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Titulos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Titulos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Titulos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Titulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CiudadID",
                table: "Titulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaisID",
                table: "Titulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Titulos",
                table: "Titulos",
                column: "TituloID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ejemplares",
                table: "Ejemplares",
                column: "EjemplarID");

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NombreArea = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaID);
                });

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    AutorID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PrimerNombre = table.Column<string>(maxLength: 50, nullable: false),
                    PrimerApellido = table.Column<string>(maxLength: 50, nullable: false),
                    DirectorioAutor = table.Column<string>(nullable: false),
                    Bibliografia = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.AutorID);
                });

            migrationBuilder.CreateTable(
                name: "Instituciones",
                columns: table => new
                {
                    InstitucionID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NombreInstitucion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituciones", x => x.InstitucionID);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    PaisID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NombrePais = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.PaisID);
                });

            migrationBuilder.CreateTable(
                name: "AutoresLibros",
                columns: table => new
                {
                    AutorLibroID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AutorID = table.Column<int>(nullable: false),
                    TituloID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoresLibros", x => x.AutorLibroID);
                    table.ForeignKey(
                        name: "FK_AutoresLibros_Autores_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Autores",
                        principalColumn: "AutorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoresLibros_Titulos_TituloID",
                        column: x => x.TituloID,
                        principalTable: "Titulos",
                        principalColumn: "TituloID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lector",
                columns: table => new
                {
                    LectorID = table.Column<string>(maxLength: 10, nullable: false),
                    PrimerNombre = table.Column<string>(nullable: false),
                    PrimerApellido = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(maxLength: 10, nullable: true),
                    Correo = table.Column<string>(maxLength: 50, nullable: false),
                    DirectorioFoto = table.Column<string>(nullable: true),
                    InstitucionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lector", x => x.LectorID);
                    table.ForeignKey(
                        name: "FK_Lector_Instituciones_InstitucionID",
                        column: x => x.InstitucionID,
                        principalTable: "Instituciones",
                        principalColumn: "InstitucionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    CiudadID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NombreCiudad = table.Column<string>(maxLength: 40, nullable: false),
                    PaisID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.CiudadID);
                    table.ForeignKey(
                        name: "FK_Ciudades_Paises_PaisID",
                        column: x => x.PaisID,
                        principalTable: "Paises",
                        principalColumn: "PaisID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    PrestamoID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FechaPrestamo = table.Column<DateTime>(nullable: false),
                    FechaDevolucion = table.Column<DateTime>(nullable: false),
                    EstadoPrestamo = table.Column<bool>(nullable: false),
                    EjemplarID = table.Column<int>(nullable: false),
                    LectorID = table.Column<int>(nullable: false),
                    EjemplarID1 = table.Column<string>(nullable: true),
                    LectorID1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.PrestamoID);
                    table.ForeignKey(
                        name: "FK_Prestamos_Ejemplares_EjemplarID1",
                        column: x => x.EjemplarID1,
                        principalTable: "Ejemplares",
                        principalColumn: "EjemplarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestamos_Lector_LectorID1",
                        column: x => x.LectorID1,
                        principalTable: "Lector",
                        principalColumn: "LectorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Multas",
                columns: table => new
                {
                    MultaID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Monto = table.Column<double>(nullable: false),
                    TiempoRetraso = table.Column<int>(nullable: false),
                    PrestamoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multas", x => x.MultaID);
                    table.ForeignKey(
                        name: "FK_Multas_Prestamos_PrestamoID",
                        column: x => x.PrestamoID,
                        principalTable: "Prestamos",
                        principalColumn: "PrestamoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titulos_AreaID",
                table: "Titulos",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Titulos_CiudadID",
                table: "Titulos",
                column: "CiudadID");

            migrationBuilder.CreateIndex(
                name: "IX_Titulos_PaisID",
                table: "Titulos",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_AutoresLibros_AutorID",
                table: "AutoresLibros",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_AutoresLibros_TituloID",
                table: "AutoresLibros",
                column: "TituloID");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_PaisID",
                table: "Ciudades",
                column: "PaisID");

            migrationBuilder.CreateIndex(
                name: "IX_Lector_InstitucionID",
                table: "Lector",
                column: "InstitucionID");

            migrationBuilder.CreateIndex(
                name: "IX_Multas_PrestamoID",
                table: "Multas",
                column: "PrestamoID");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_EjemplarID1",
                table: "Prestamos",
                column: "EjemplarID1");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_LectorID1",
                table: "Prestamos",
                column: "LectorID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ejemplares_Titulos_TituloID",
                table: "Ejemplares",
                column: "TituloID",
                principalTable: "Titulos",
                principalColumn: "TituloID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titulos_Areas_AreaID",
                table: "Titulos",
                column: "AreaID",
                principalTable: "Areas",
                principalColumn: "AreaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titulos_Ciudades_CiudadID",
                table: "Titulos",
                column: "CiudadID",
                principalTable: "Ciudades",
                principalColumn: "CiudadID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titulos_Paises_PaisID",
                table: "Titulos",
                column: "PaisID",
                principalTable: "Paises",
                principalColumn: "PaisID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejemplares_Titulos_TituloID",
                table: "Ejemplares");

            migrationBuilder.DropForeignKey(
                name: "FK_Titulos_Areas_AreaID",
                table: "Titulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Titulos_Ciudades_CiudadID",
                table: "Titulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Titulos_Paises_PaisID",
                table: "Titulos");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "AutoresLibros");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Multas");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Lector");

            migrationBuilder.DropTable(
                name: "Instituciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Titulos",
                table: "Titulos");

            migrationBuilder.DropIndex(
                name: "IX_Titulos_AreaID",
                table: "Titulos");

            migrationBuilder.DropIndex(
                name: "IX_Titulos_CiudadID",
                table: "Titulos");

            migrationBuilder.DropIndex(
                name: "IX_Titulos_PaisID",
                table: "Titulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ejemplares",
                table: "Ejemplares");

            migrationBuilder.DropColumn(
                name: "AreaID",
                table: "Titulos");

            migrationBuilder.DropColumn(
                name: "CiudadID",
                table: "Titulos");

            migrationBuilder.DropColumn(
                name: "PaisID",
                table: "Titulos");

            migrationBuilder.RenameTable(
                name: "Titulos",
                newName: "titulos");

            migrationBuilder.RenameTable(
                name: "Ejemplares",
                newName: "ejemplares");

            migrationBuilder.RenameColumn(
                name: "TituloID",
                table: "titulos",
                newName: "TitulosID");

            migrationBuilder.RenameColumn(
                name: "TituloID",
                table: "ejemplares",
                newName: "TitulosID");

            migrationBuilder.RenameIndex(
                name: "IX_Ejemplares_TituloID",
                table: "ejemplares",
                newName: "IX_ejemplares_TitulosID");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "titulos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "titulos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "titulos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_titulos",
                table: "titulos",
                column: "TitulosID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ejemplares",
                table: "ejemplares",
                column: "EjemplarID");

            migrationBuilder.AddForeignKey(
                name: "FK_ejemplares_titulos_TitulosID",
                table: "ejemplares",
                column: "TitulosID",
                principalTable: "titulos",
                principalColumn: "TitulosID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
