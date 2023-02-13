using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class Nulos_permitidos_Usuario4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ultima_ip",
                table: "usuarios",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ultima_ip",
                table: "usuarios",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");
        }
    }
}
