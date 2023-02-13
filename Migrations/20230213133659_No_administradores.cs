using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class No_administradores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.AlterColumn<int>(
                name: "id_rol",
                table: "usuarios",
                type: "int",
                nullable: true,
                defaultValueSql: "null",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id_grupo",
                table: "usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id_ciudad",
                table: "usuarios",
                type: "int",
                nullable: true,
                defaultValueSql: "null",
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id_rol",
                table: "usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "null");

            migrationBuilder.AlterColumn<int>(
                name: "id_grupo",
                table: "usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_ciudad",
                table: "usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "null");

            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_grupo = table.Column<int>(type: "int", nullable: true),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    clave = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, defaultValueSql: "''"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_registro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.id);
                    table.ForeignKey(
                        name: "FK_administradores_usuarios_id_modificador",
                        column: x => x.id_modificador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_administradores_usuarios_IdCreador",
                        column: x => x.IdCreador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_administradores_varios_id_grupo",
                        column: x => x.id_grupo,
                        principalTable: "varios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_administradores_email",
                table: "administradores",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_administradores_id_grupo",
                table: "administradores",
                column: "id_grupo");

            migrationBuilder.CreateIndex(
                name: "IX_administradores_id_modificador",
                table: "administradores",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_administradores_IdCreador",
                table: "administradores",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_administradores_nombre",
                table: "administradores",
                column: "nombre",
                unique: true);
        }
    }
}
