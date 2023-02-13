using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class Columna_id_creador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_usuarios_IdCreador",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_rutas_proyectos_usuarios_IdCreador",
                table: "actividades_rutas_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_bitacoras_proyectos_usuarios_IdCreador",
                table: "bitacoras_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_chats_usuarios_IdCreador",
                table: "chats");

            migrationBuilder.DropForeignKey(
                name: "FK_comentarios_usuarios_IdCreador",
                table: "comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_monedas_usuarios_IdCreador",
                table: "monedas");

            migrationBuilder.DropForeignKey(
                name: "FK_personal_usuarios_IdCreador",
                table: "personal");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_usuarios_IdCreador",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_publicaciones_usuarios_IdCreador",
                table: "publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_rastreo_publicaciones_usuarios_IdCreador",
                table: "rastreo_publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_recursos_publicaciones_usuarios_IdCreador",
                table: "recursos_publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_secuencias_usuarios_IdCreador",
                table: "secuencias");

            migrationBuilder.DropForeignKey(
                name: "FK_tablas_usuarios_IdCreador",
                table: "tablas");

            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_usuarios_IdCreador",
                table: "usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_varios_usuarios_IdCreador",
                table: "varios");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "varios",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_varios_IdCreador",
                table: "varios",
                newName: "IX_varios_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "usuarios",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_usuarios_IdCreador",
                table: "usuarios",
                newName: "IX_usuarios_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "tablas",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_tablas_IdCreador",
                table: "tablas",
                newName: "IX_tablas_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "secuencias",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_secuencias_IdCreador",
                table: "secuencias",
                newName: "IX_secuencias_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "recursos_publicaciones",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_recursos_publicaciones_IdCreador",
                table: "recursos_publicaciones",
                newName: "IX_recursos_publicaciones_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "rastreo_publicaciones",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_rastreo_publicaciones_IdCreador",
                table: "rastreo_publicaciones",
                newName: "IX_rastreo_publicaciones_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "publicaciones",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_publicaciones_IdCreador",
                table: "publicaciones",
                newName: "IX_publicaciones_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "proyectos",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_proyectos_IdCreador",
                table: "proyectos",
                newName: "IX_proyectos_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "personal",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_personal_IdCreador",
                table: "personal",
                newName: "IX_personal_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "monedas",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_monedas_IdCreador",
                table: "monedas",
                newName: "IX_monedas_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "comentarios",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_comentarios_IdCreador",
                table: "comentarios",
                newName: "IX_comentarios_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "chats",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_chats_IdCreador",
                table: "chats",
                newName: "IX_chats_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "bitacoras_proyectos",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_bitacoras_proyectos_IdCreador",
                table: "bitacoras_proyectos",
                newName: "IX_bitacoras_proyectos_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "actividades_rutas_proyectos",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_actividades_rutas_proyectos_IdCreador",
                table: "actividades_rutas_proyectos",
                newName: "IX_actividades_rutas_proyectos_id_creador");

            migrationBuilder.RenameColumn(
                name: "IdCreador",
                table: "actividades_proyectos",
                newName: "id_creador");

            migrationBuilder.RenameIndex(
                name: "IX_actividades_proyectos_IdCreador",
                table: "actividades_proyectos",
                newName: "IX_actividades_proyectos_id_creador");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_usuarios_id_creador",
                table: "actividades_proyectos",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_rutas_proyectos_usuarios_id_creador",
                table: "actividades_rutas_proyectos",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_usuarios_id_creador",
                table: "bitacoras_proyectos",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_chats_usuarios_id_creador",
                table: "chats",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_comentarios_usuarios_id_creador",
                table: "comentarios",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_monedas_usuarios_id_creador",
                table: "monedas",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_usuarios_id_creador",
                table: "personal",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_usuarios_id_creador",
                table: "proyectos",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_usuarios_id_creador",
                table: "publicaciones",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_rastreo_publicaciones_usuarios_id_creador",
                table: "rastreo_publicaciones",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_recursos_publicaciones_usuarios_id_creador",
                table: "recursos_publicaciones",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_secuencias_usuarios_id_creador",
                table: "secuencias",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tablas_usuarios_id_creador",
                table: "tablas",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_usuarios_id_creador",
                table: "usuarios",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_varios_usuarios_id_creador",
                table: "varios",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_usuarios_id_creador",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_rutas_proyectos_usuarios_id_creador",
                table: "actividades_rutas_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_bitacoras_proyectos_usuarios_id_creador",
                table: "bitacoras_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_chats_usuarios_id_creador",
                table: "chats");

            migrationBuilder.DropForeignKey(
                name: "FK_comentarios_usuarios_id_creador",
                table: "comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_monedas_usuarios_id_creador",
                table: "monedas");

            migrationBuilder.DropForeignKey(
                name: "FK_personal_usuarios_id_creador",
                table: "personal");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_usuarios_id_creador",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_publicaciones_usuarios_id_creador",
                table: "publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_rastreo_publicaciones_usuarios_id_creador",
                table: "rastreo_publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_recursos_publicaciones_usuarios_id_creador",
                table: "recursos_publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_secuencias_usuarios_id_creador",
                table: "secuencias");

            migrationBuilder.DropForeignKey(
                name: "FK_tablas_usuarios_id_creador",
                table: "tablas");

            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_usuarios_id_creador",
                table: "usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_varios_usuarios_id_creador",
                table: "varios");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "varios",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_varios_id_creador",
                table: "varios",
                newName: "IX_varios_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "usuarios",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_usuarios_id_creador",
                table: "usuarios",
                newName: "IX_usuarios_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "tablas",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_tablas_id_creador",
                table: "tablas",
                newName: "IX_tablas_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "secuencias",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_secuencias_id_creador",
                table: "secuencias",
                newName: "IX_secuencias_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "recursos_publicaciones",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_recursos_publicaciones_id_creador",
                table: "recursos_publicaciones",
                newName: "IX_recursos_publicaciones_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "rastreo_publicaciones",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_rastreo_publicaciones_id_creador",
                table: "rastreo_publicaciones",
                newName: "IX_rastreo_publicaciones_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "publicaciones",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_publicaciones_id_creador",
                table: "publicaciones",
                newName: "IX_publicaciones_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "proyectos",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_proyectos_id_creador",
                table: "proyectos",
                newName: "IX_proyectos_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "personal",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_personal_id_creador",
                table: "personal",
                newName: "IX_personal_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "monedas",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_monedas_id_creador",
                table: "monedas",
                newName: "IX_monedas_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "comentarios",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_comentarios_id_creador",
                table: "comentarios",
                newName: "IX_comentarios_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "chats",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_chats_id_creador",
                table: "chats",
                newName: "IX_chats_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "bitacoras_proyectos",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_bitacoras_proyectos_id_creador",
                table: "bitacoras_proyectos",
                newName: "IX_bitacoras_proyectos_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "actividades_rutas_proyectos",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_actividades_rutas_proyectos_id_creador",
                table: "actividades_rutas_proyectos",
                newName: "IX_actividades_rutas_proyectos_IdCreador");

            migrationBuilder.RenameColumn(
                name: "id_creador",
                table: "actividades_proyectos",
                newName: "IdCreador");

            migrationBuilder.RenameIndex(
                name: "IX_actividades_proyectos_id_creador",
                table: "actividades_proyectos",
                newName: "IX_actividades_proyectos_IdCreador");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_usuarios_IdCreador",
                table: "actividades_proyectos",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_rutas_proyectos_usuarios_IdCreador",
                table: "actividades_rutas_proyectos",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_usuarios_IdCreador",
                table: "bitacoras_proyectos",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_chats_usuarios_IdCreador",
                table: "chats",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_comentarios_usuarios_IdCreador",
                table: "comentarios",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_monedas_usuarios_IdCreador",
                table: "monedas",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_usuarios_IdCreador",
                table: "personal",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_usuarios_IdCreador",
                table: "proyectos",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_usuarios_IdCreador",
                table: "publicaciones",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_rastreo_publicaciones_usuarios_IdCreador",
                table: "rastreo_publicaciones",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_recursos_publicaciones_usuarios_IdCreador",
                table: "recursos_publicaciones",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_secuencias_usuarios_IdCreador",
                table: "secuencias",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tablas_usuarios_IdCreador",
                table: "tablas",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_usuarios_IdCreador",
                table: "usuarios",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_varios_usuarios_IdCreador",
                table: "varios",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");
        }
    }
}
