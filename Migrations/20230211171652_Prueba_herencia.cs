using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class Prueba_herencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_grupo = table.Column<int>(type: "int", nullable: true),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: true),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.id);
                    table.ForeignKey(
                        name: "FK_admin_usuarios_id_modificador",
                        column: x => x.id_modificador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_admin_usuarios_IdCreador",
                        column: x => x.IdCreador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_admin_varios_id_grupo",
                        column: x => x.id_grupo,
                        principalTable: "varios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    segundo_nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    segundo_apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    perfil = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    id_ciudad = table.Column<int>(type: "int", nullable: false),
                    telefono2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    clave = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    email2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    id_profesion = table.Column<int>(type: "int", nullable: true),
                    max_publicaciones = table.Column<int>(type: "int", nullable: false),
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    estatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    verificado = table.Column<int>(type: "int", nullable: false),
                    ultima_ip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: true),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_usuarios_id_modificador",
                        column: x => x.id_modificador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_user_usuarios_IdCreador",
                        column: x => x.IdCreador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_user_varios_id_ciudad",
                        column: x => x.id_ciudad,
                        principalTable: "varios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_user_varios_id_grupo",
                        column: x => x.id_grupo,
                        principalTable: "varios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_user_varios_id_profesion",
                        column: x => x.id_profesion,
                        principalTable: "varios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_admin_id_grupo",
                table: "admin",
                column: "id_grupo");

            migrationBuilder.CreateIndex(
                name: "IX_admin_id_modificador",
                table: "admin",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_admin_IdCreador",
                table: "admin",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_user_id_ciudad",
                table: "user",
                column: "id_ciudad");

            migrationBuilder.CreateIndex(
                name: "IX_user_id_grupo",
                table: "user",
                column: "id_grupo");

            migrationBuilder.CreateIndex(
                name: "IX_user_id_modificador",
                table: "user",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_user_id_profesion",
                table: "user",
                column: "id_profesion");

            migrationBuilder.CreateIndex(
                name: "IX_user_IdCreador",
                table: "user",
                column: "IdCreador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
