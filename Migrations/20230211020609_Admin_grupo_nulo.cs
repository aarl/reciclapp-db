using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class Admin_grupo_nulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "id_modificador",
                table: "usuarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "null",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "null");

            migrationBuilder.AlterColumn<Guid>(
                name: "id_creador",
                table: "usuarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "null",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValueSql: "null");

            migrationBuilder.AlterColumn<int>(
                name: "id_grupo",
                table: "administradores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "id_modificador",
                table: "usuarios",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "null",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "null");

            migrationBuilder.AlterColumn<Guid>(
                name: "id_creador",
                table: "usuarios",
                type: "uniqueidentifier",
                nullable: true,
                defaultValueSql: "null",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "null");

            migrationBuilder.AlterColumn<int>(
                name: "id_grupo",
                table: "administradores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
