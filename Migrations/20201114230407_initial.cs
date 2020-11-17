using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea9_10.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Foto = table.Column<byte[]>(type: "BLOB", nullable: false),
                    Sexo = table.Column<string>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false),
                    Nombres = table.Column<string>(type: "TEXT", nullable: false),
                    F_Nacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pais_Nac = table.Column<string>(type: "TEXT", nullable: false),
                    Ciudad_Nac = table.Column<string>(type: "TEXT", nullable: false),
                    Pais_Res = table.Column<string>(type: "TEXT", nullable: false),
                    Ciudad_Res = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Celular = table.Column<string>(type: "TEXT", nullable: false),
                    Correo = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo_Docum = table.Column<string>(type: "TEXT", nullable: false),
                    Documento_ID = table.Column<string>(type: "TEXT", nullable: false),
                    EstadoCivil = table.Column<string>(type: "TEXT", nullable: false),
                    Casado = table.Column<string>(type: "TEXT", nullable: true),
                    Tiene_Hijos = table.Column<string>(type: "TEXT", nullable: true),
                    N_Hijos = table.Column<int>(type: "INTEGER", nullable: false),
                    Profesion = table.Column<string>(type: "TEXT", nullable: true),
                    Ocu_Actual = table.Column<string>(type: "TEXT", nullable: true),
                    Empr_Negocio = table.Column<string>(type: "TEXT", nullable: true),
                    Prof_Tele = table.Column<string>(type: "TEXT", nullable: true),
                    F_Conversion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    F_Bautismo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    F_Iglesia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Denominacion = table.Column<string>(type: "TEXT", nullable: false),
                    Iglesia_Actual = table.Column<string>(type: "TEXT", nullable: false),
                    Iglesia_Anterior = table.Column<string>(type: "TEXT", nullable: true),
                    Pastor_Actual = table.Column<string>(type: "TEXT", nullable: false),
                    Disciplinado = table.Column<string>(type: "TEXT", nullable: false),
                    Cant_Disc = table.Column<int>(type: "INTEGER", nullable: false),
                    Causas = table.Column<string>(type: "TEXT", nullable: true),
                    Funcion = table.Column<string>(type: "TEXT", nullable: false),
                    Ministerios = table.Column<string>(type: "TEXT", nullable: true),
                    Minis_frutos = table.Column<string>(type: "TEXT", nullable: true),
                    Mini_llamado = table.Column<string>(type: "TEXT", nullable: true),
                    Metas = table.Column<string>(type: "TEXT", nullable: true),
                    Respaldo = table.Column<string>(type: "TEXT", nullable: true),
                    N_Estudio = table.Column<string>(type: "TEXT", nullable: true),
                    Expulsado = table.Column<string>(type: "TEXT", nullable: true),
                    Exp_Razon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Correo = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
