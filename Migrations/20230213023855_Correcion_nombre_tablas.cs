using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class Correcion_nombre_tablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_RecursosPublicaciones_id_imagen_principal",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_usuarios_id_modificador",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_usuarios_id_usuario",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_usuarios_IdCreador",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_varios_id_estatus_recurso",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_varios_id_tipo_catalogo",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_varios_id_tipo_recurso",
                table: "RecursosPublicaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecursosPublicaciones",
                table: "RecursosPublicaciones");

            migrationBuilder.RenameTable(
                name: "RecursosPublicaciones",
                newName: "recursos_publicaciones");

            migrationBuilder.RenameIndex(
                name: "IX_RecursosPublicaciones_IdCreador",
                table: "recursos_publicaciones",
                newName: "IX_recursos_publicaciones_IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_RecursosPublicaciones_id_usuario",
                table: "recursos_publicaciones",
                newName: "IX_recursos_publicaciones_id_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_RecursosPublicaciones_id_tipo_recurso",
                table: "recursos_publicaciones",
                newName: "IX_recursos_publicaciones_id_tipo_recurso");

            migrationBuilder.RenameIndex(
                name: "IX_RecursosPublicaciones_id_tipo_catalogo",
                table: "recursos_publicaciones",
                newName: "IX_recursos_publicaciones_id_tipo_catalogo");

            migrationBuilder.RenameIndex(
                name: "IX_RecursosPublicaciones_id_modificador",
                table: "recursos_publicaciones",
                newName: "IX_recursos_publicaciones_id_modificador");

            migrationBuilder.RenameIndex(
                name: "IX_RecursosPublicaciones_id_estatus_recurso",
                table: "recursos_publicaciones",
                newName: "IX_recursos_publicaciones_id_estatus_recurso");

            migrationBuilder.AddPrimaryKey(
                name: "PK_recursos_publicaciones",
                table: "recursos_publicaciones",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_recursos_publicaciones_id_imagen_principal",
                table: "proyectos",
                column: "id_imagen_principal",
                principalTable: "recursos_publicaciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_recursos_publicaciones_usuarios_id_modificador",
                table: "recursos_publicaciones",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_recursos_publicaciones_usuarios_id_usuario",
                table: "recursos_publicaciones",
                column: "id_usuario",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_recursos_publicaciones_usuarios_IdCreador",
                table: "recursos_publicaciones",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_recursos_publicaciones_varios_id_estatus_recurso",
                table: "recursos_publicaciones",
                column: "id_estatus_recurso",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_recursos_publicaciones_varios_id_tipo_catalogo",
                table: "recursos_publicaciones",
                column: "id_tipo_catalogo",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_recursos_publicaciones_varios_id_tipo_recurso",
                table: "recursos_publicaciones",
                column: "id_tipo_recurso",
                principalTable: "varios",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_recursos_publicaciones_id_imagen_principal",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_recursos_publicaciones_usuarios_id_modificador",
                table: "recursos_publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_recursos_publicaciones_usuarios_id_usuario",
                table: "recursos_publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_recursos_publicaciones_usuarios_IdCreador",
                table: "recursos_publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_recursos_publicaciones_varios_id_estatus_recurso",
                table: "recursos_publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_recursos_publicaciones_varios_id_tipo_catalogo",
                table: "recursos_publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_recursos_publicaciones_varios_id_tipo_recurso",
                table: "recursos_publicaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_recursos_publicaciones",
                table: "recursos_publicaciones");

            migrationBuilder.RenameTable(
                name: "recursos_publicaciones",
                newName: "RecursosPublicaciones");

            migrationBuilder.RenameIndex(
                name: "IX_recursos_publicaciones_IdCreador",
                table: "RecursosPublicaciones",
                newName: "IX_RecursosPublicaciones_IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_recursos_publicaciones_id_usuario",
                table: "RecursosPublicaciones",
                newName: "IX_RecursosPublicaciones_id_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_recursos_publicaciones_id_tipo_recurso",
                table: "RecursosPublicaciones",
                newName: "IX_RecursosPublicaciones_id_tipo_recurso");

            migrationBuilder.RenameIndex(
                name: "IX_recursos_publicaciones_id_tipo_catalogo",
                table: "RecursosPublicaciones",
                newName: "IX_RecursosPublicaciones_id_tipo_catalogo");

            migrationBuilder.RenameIndex(
                name: "IX_recursos_publicaciones_id_modificador",
                table: "RecursosPublicaciones",
                newName: "IX_RecursosPublicaciones_id_modificador");

            migrationBuilder.RenameIndex(
                name: "IX_recursos_publicaciones_id_estatus_recurso",
                table: "RecursosPublicaciones",
                newName: "IX_RecursosPublicaciones_id_estatus_recurso");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecursosPublicaciones",
                table: "RecursosPublicaciones",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_RecursosPublicaciones_id_imagen_principal",
                table: "proyectos",
                column: "id_imagen_principal",
                principalTable: "RecursosPublicaciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecursosPublicaciones_usuarios_id_modificador",
                table: "RecursosPublicaciones",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecursosPublicaciones_usuarios_id_usuario",
                table: "RecursosPublicaciones",
                column: "id_usuario",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecursosPublicaciones_usuarios_IdCreador",
                table: "RecursosPublicaciones",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecursosPublicaciones_varios_id_estatus_recurso",
                table: "RecursosPublicaciones",
                column: "id_estatus_recurso",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecursosPublicaciones_varios_id_tipo_catalogo",
                table: "RecursosPublicaciones",
                column: "id_tipo_catalogo",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecursosPublicaciones_varios_id_tipo_recurso",
                table: "RecursosPublicaciones",
                column: "id_tipo_recurso",
                principalTable: "varios",
                principalColumn: "id");
        }
    }
}
