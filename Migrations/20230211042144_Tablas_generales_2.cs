using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class Tablas_generales_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_registro_general_id_estatus_proyecto",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_registro_general_id_estatus_publicacion",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_registro_general_id_ruta_proyecto",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_registro_general_id_tipo_actividad",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_rutas_proyectos_registro_general_RutaProyectoId",
                table: "actividades_rutas_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_administradores_registro_general_id_grupo",
                table: "administradores");

            migrationBuilder.DropForeignKey(
                name: "FK_bitacoras_proyectos_registro_general_id_tipo_bitacora",
                table: "bitacoras_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_personal_registro_general_id_rol",
                table: "personal");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_registro_general_id_estatus_proyecto",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_registro_general_id_estatus_publicacion",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_registro_general_id_ruta_proyecto",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_registro_general_id_tipo_proyecto",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_publicaciones_registro_general_EstatusPublicacionId",
                table: "publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_publicaciones_registro_general_TipoPublicacionId",
                table: "publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_registro_general_id_estatus_recurso",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_registro_general_id_tipo_catalogo",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_registro_general_id_tipo_recurso",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_registro_general_id_ciudad",
                table: "usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_registro_general_id_grupo",
                table: "usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_registro_general_id_profesion",
                table: "usuarios");

            migrationBuilder.DropTable(
                name: "registro_general");

            migrationBuilder.CreateTable(
                name: "varios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_tabla = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    id_padre = table.Column<int>(type: "int", nullable: true),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_varios", x => x.id);
                    table.ForeignKey(
                        name: "FK_varios_tablas_id_tabla",
                        column: x => x.id_tabla,
                        principalTable: "tablas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_varios_usuarios_id_creador",
                        column: x => x.id_creador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_varios_usuarios_id_modificador",
                        column: x => x.id_modificador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_varios_varios_id_padre",
                        column: x => x.id_padre,
                        principalTable: "varios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_varios_id_creador",
                table: "varios",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_varios_id_modificador",
                table: "varios",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_varios_id_padre",
                table: "varios",
                column: "id_padre");

            migrationBuilder.CreateIndex(
                name: "IX_varios_id_tabla",
                table: "varios",
                column: "id_tabla");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_varios_id_estatus_proyecto",
                table: "actividades_proyectos",
                column: "id_estatus_proyecto",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_varios_id_estatus_publicacion",
                table: "actividades_proyectos",
                column: "id_estatus_publicacion",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_varios_id_ruta_proyecto",
                table: "actividades_proyectos",
                column: "id_ruta_proyecto",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_varios_id_tipo_actividad",
                table: "actividades_proyectos",
                column: "id_tipo_actividad",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_rutas_proyectos_varios_RutaProyectoId",
                table: "actividades_rutas_proyectos",
                column: "RutaProyectoId",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_administradores_varios_id_grupo",
                table: "administradores",
                column: "id_grupo",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_varios_id_tipo_bitacora",
                table: "bitacoras_proyectos",
                column: "id_tipo_bitacora",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_varios_id_rol",
                table: "personal",
                column: "id_rol",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_varios_id_estatus_proyecto",
                table: "proyectos",
                column: "id_estatus_proyecto",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_varios_id_estatus_publicacion",
                table: "proyectos",
                column: "id_estatus_publicacion",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_varios_id_ruta_proyecto",
                table: "proyectos",
                column: "id_ruta_proyecto",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_varios_id_tipo_proyecto",
                table: "proyectos",
                column: "id_tipo_proyecto",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_varios_EstatusPublicacionId",
                table: "publicaciones",
                column: "EstatusPublicacionId",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_varios_TipoPublicacionId",
                table: "publicaciones",
                column: "TipoPublicacionId",
                principalTable: "varios",
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

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_varios_id_ciudad",
                table: "usuarios",
                column: "id_ciudad",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_varios_id_grupo",
                table: "usuarios",
                column: "id_grupo",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_varios_id_profesion",
                table: "usuarios",
                column: "id_profesion",
                principalTable: "varios",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_varios_id_estatus_proyecto",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_varios_id_estatus_publicacion",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_varios_id_ruta_proyecto",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_proyectos_varios_id_tipo_actividad",
                table: "actividades_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_actividades_rutas_proyectos_varios_RutaProyectoId",
                table: "actividades_rutas_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_administradores_varios_id_grupo",
                table: "administradores");

            migrationBuilder.DropForeignKey(
                name: "FK_bitacoras_proyectos_varios_id_tipo_bitacora",
                table: "bitacoras_proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_personal_varios_id_rol",
                table: "personal");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_varios_id_estatus_proyecto",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_varios_id_estatus_publicacion",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_varios_id_ruta_proyecto",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_varios_id_tipo_proyecto",
                table: "proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_publicaciones_varios_EstatusPublicacionId",
                table: "publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_publicaciones_varios_TipoPublicacionId",
                table: "publicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_varios_id_estatus_recurso",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_varios_id_tipo_catalogo",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RecursosPublicaciones_varios_id_tipo_recurso",
                table: "RecursosPublicaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_varios_id_ciudad",
                table: "usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_varios_id_grupo",
                table: "usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_varios_id_profesion",
                table: "usuarios");

            migrationBuilder.DropTable(
                name: "varios");

            migrationBuilder.CreateTable(
                name: "registro_general",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    id_padre = table.Column<int>(type: "int", nullable: true),
                    id_tabla = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registro_general", x => x.id);
                    table.ForeignKey(
                        name: "FK_registro_general_registro_general_id_padre",
                        column: x => x.id_padre,
                        principalTable: "registro_general",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_registro_general_tablas_id_tabla",
                        column: x => x.id_tabla,
                        principalTable: "tablas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_registro_general_usuarios_id_creador",
                        column: x => x.id_creador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_registro_general_usuarios_id_modificador",
                        column: x => x.id_modificador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_registro_general_id_creador",
                table: "registro_general",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_registro_general_id_modificador",
                table: "registro_general",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_registro_general_id_padre",
                table: "registro_general",
                column: "id_padre");

            migrationBuilder.CreateIndex(
                name: "IX_registro_general_id_tabla",
                table: "registro_general",
                column: "id_tabla");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_registro_general_id_estatus_proyecto",
                table: "actividades_proyectos",
                column: "id_estatus_proyecto",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_registro_general_id_estatus_publicacion",
                table: "actividades_proyectos",
                column: "id_estatus_publicacion",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_registro_general_id_ruta_proyecto",
                table: "actividades_proyectos",
                column: "id_ruta_proyecto",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_registro_general_id_tipo_actividad",
                table: "actividades_proyectos",
                column: "id_tipo_actividad",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_rutas_proyectos_registro_general_RutaProyectoId",
                table: "actividades_rutas_proyectos",
                column: "RutaProyectoId",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_administradores_registro_general_id_grupo",
                table: "administradores",
                column: "id_grupo",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_registro_general_id_tipo_bitacora",
                table: "bitacoras_proyectos",
                column: "id_tipo_bitacora",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_registro_general_id_rol",
                table: "personal",
                column: "id_rol",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_registro_general_id_estatus_proyecto",
                table: "proyectos",
                column: "id_estatus_proyecto",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_registro_general_id_estatus_publicacion",
                table: "proyectos",
                column: "id_estatus_publicacion",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_registro_general_id_ruta_proyecto",
                table: "proyectos",
                column: "id_ruta_proyecto",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_registro_general_id_tipo_proyecto",
                table: "proyectos",
                column: "id_tipo_proyecto",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_registro_general_EstatusPublicacionId",
                table: "publicaciones",
                column: "EstatusPublicacionId",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_registro_general_TipoPublicacionId",
                table: "publicaciones",
                column: "TipoPublicacionId",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecursosPublicaciones_registro_general_id_estatus_recurso",
                table: "RecursosPublicaciones",
                column: "id_estatus_recurso",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecursosPublicaciones_registro_general_id_tipo_catalogo",
                table: "RecursosPublicaciones",
                column: "id_tipo_catalogo",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecursosPublicaciones_registro_general_id_tipo_recurso",
                table: "RecursosPublicaciones",
                column: "id_tipo_recurso",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_registro_general_id_ciudad",
                table: "usuarios",
                column: "id_ciudad",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_registro_general_id_grupo",
                table: "usuarios",
                column: "id_grupo",
                principalTable: "registro_general",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_registro_general_id_profesion",
                table: "usuarios",
                column: "id_profesion",
                principalTable: "registro_general",
                principalColumn: "id");
        }
    }
}
