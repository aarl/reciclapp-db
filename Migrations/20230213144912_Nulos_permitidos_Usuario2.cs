using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class Nulos_permitidos_Usuario2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "estatus",
                table: "usuarios",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "estatus",
                table: "usuarios",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldDefaultValueSql: "''");
        }
    }
}
