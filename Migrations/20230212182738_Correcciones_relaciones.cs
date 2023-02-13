using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class Correcciones_relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actividades_proyectos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_proyecto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_ruta_proyecto = table.Column<int>(type: "int", nullable: false),
                    secuencia = table.Column<int>(type: "int", nullable: false),
                    id_actividad_ruta = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    fecha_finalizacion = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "null"),
                    id_ejecutor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_revisor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_estatus_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_estatus_proyecto = table.Column<int>(type: "int", nullable: false),
                    id_revisada_por = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    id_tipo_actividad = table.Column<int>(type: "int", nullable: false),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    progreso_estimado = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    evaluacion = table.Column<decimal>(type: "decimal(2,1)", precision: 2, scale: 1, nullable: false, defaultValue: 0m),
                    fecha_disponible = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "null"),
                    total_articulos = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false, defaultValue: 0m),
                    costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    id_moneda_costo_estimado = table.Column<string>(type: "nvarchar(3)", nullable: false, defaultValueSql: "''"),
                    tipo_cambio_costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    id_moneda_costo_real = table.Column<string>(type: "nvarchar(3)", nullable: false, defaultValueSql: "''"),
                    tipo_cambio_costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    ProyectoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actividades_proyectos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "actividades_rutas_proyectos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_ruta_proyecto = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "''"),
                    secuencia = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actividades_rutas_proyectos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    fecha_registro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_grupo = table.Column<int>(type: "int", nullable: true),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, defaultValueSql: "''"),
                    clave = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bitacoras_proyectos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_proyecto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_actividad_proyecto = table.Column<long>(type: "bigint", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_tipo_bitacora = table.Column<int>(type: "int", nullable: false),
                    comentarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bitacoras_proyectos", x => x.id);
                    table.ForeignKey(
                        name: "FK_bitacoras_proyectos_actividades_proyectos_id_actividad_proyecto",
                        column: x => x.id_actividad_proyecto,
                        principalTable: "actividades_proyectos",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "chats",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    id_publicacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, defaultValueSql: "''"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chats", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "comentarios",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    id_chat = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    comentario = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    id_comentario = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comentarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_comentarios_chats_id_chat",
                        column: x => x.id_chat,
                        principalTable: "chats",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_comentarios_comentarios_id_comentario",
                        column: x => x.id_comentario,
                        principalTable: "comentarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "monedas",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tipo_cambio = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false, defaultValue: 0m),
                    es_local = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_monedas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personal",
                columns: table => new
                {
                    id_publicacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_rol = table.Column<int>(type: "int", nullable: false),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "null"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "null"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personal", x => new { x.id_publicacion, x.id_usuario });
                });

            migrationBuilder.CreateTable(
                name: "proyectos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    titulo = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "''"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_gerente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_revisor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    gustan = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    no_gustan = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    id_estatus_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_estatus_proyecto = table.Column<int>(type: "int", nullable: false),
                    id_revisada_por = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_imagen_principal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_tipo_proyecto = table.Column<int>(type: "int", nullable: false),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    progreso_estimado = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    progreso_real = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    evaluacion = table.Column<decimal>(type: "decimal(2,1)", precision: 2, scale: 1, nullable: false, defaultValue: 0m),
                    id_ruta_proyecto = table.Column<int>(type: "int", nullable: false),
                    id_fase_anterior = table.Column<int>(type: "int", nullable: false),
                    id_fase_siguiente = table.Column<int>(type: "int", nullable: false),
                    fecha_disponible = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "null"),
                    total_articulos = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false, defaultValue: 0m),
                    costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    id_moneda_costo_estimado = table.Column<string>(type: "nvarchar(3)", nullable: false, defaultValueSql: "''"),
                    tipo_cambio_costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    id_moneda_costo_real = table.Column<string>(type: "nvarchar(3)", nullable: false, defaultValueSql: "''"),
                    tipo_cambio_costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proyectos", x => x.id);
                    table.ForeignKey(
                        name: "FK_proyectos_monedas_id_moneda_costo_estimado",
                        column: x => x.id_moneda_costo_estimado,
                        principalTable: "monedas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_proyectos_monedas_id_moneda_costo_real",
                        column: x => x.id_moneda_costo_real,
                        principalTable: "monedas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "publicaciones",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    titulo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    consecutivo = table.Column<int>(type: "int", nullable: false),
                    publicador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    gustan = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    no_gustan = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    id_estatus_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_fase_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_tipo_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_clase_publicacion = table.Column<int>(type: "int", nullable: false),
                    revisada_por = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_imagen_principal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    posicionamiento = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    secuencia = table.Column<int>(type: "int", nullable: false),
                    vistas = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    evaluacion = table.Column<decimal>(type: "decimal(2,1)", precision: 2, scale: 1, nullable: false, defaultValue: 0m),
                    direccion_ip_creacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    dispositivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    referencias_direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    fecha_disponible = table.Column<DateTime>(type: "datetime2", nullable: true),
                    total_articulos = table.Column<int>(type: "int", precision: 10, scale: 2, nullable: false, defaultValue: 0),
                    id_proyecto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    id_moneda_costo_estimado = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    tipo_cambio_costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    monto_inversion = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    costo_real_traslado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    id_moneda_costo_real = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    tipo_cambio_costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValue: 0m),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publicaciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_publicaciones_monedas_id_moneda_costo_estimado",
                        column: x => x.id_moneda_costo_estimado,
                        principalTable: "monedas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_publicaciones_monedas_id_moneda_costo_real",
                        column: x => x.id_moneda_costo_real,
                        principalTable: "monedas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_publicaciones_proyectos_id_proyecto",
                        column: x => x.id_proyecto,
                        principalTable: "proyectos",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "rastreo_publicaciones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_publicacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_fase_publicacion = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tiempo_estimado = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    id_fase_anterior = table.Column<int>(type: "int", nullable: false),
                    id_fase_siguiente = table.Column<int>(type: "int", nullable: false),
                    comentarios = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rastreo_publicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rastreo_publicaciones_publicaciones_id_publicacion",
                        column: x => x.id_publicacion,
                        principalTable: "publicaciones",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "RecursosPublicaciones",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    id_tipo_catalogo = table.Column<int>(type: "int", nullable: false),
                    id_catalogo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    secuencia = table.Column<int>(type: "int", nullable: false),
                    id_tipo_recurso = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    orden = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    id_estatus_recurso = table.Column<int>(type: "int", nullable: false),
                    fecha_expiracion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tamano = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecursosPublicaciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "secuencias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prefijo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    serie = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1L),
                    incremento = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_secuencias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tablas",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    segundo_nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    segundo_apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    perfil = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, defaultValueSql: "''"),
                    id_ciudad = table.Column<int>(type: "int", nullable: false),
                    telefono2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    email2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "''"),
                    id_profesion = table.Column<int>(type: "int", nullable: true, defaultValueSql: "null"),
                    max_publicaciones = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    estatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    id_tipo_usuario = table.Column<int>(type: "int", nullable: false),
                    id_rol = table.Column<int>(type: "int", nullable: false),
                    ultima_ip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TipousuarioId = table.Column<int>(type: "int", nullable: true),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "null"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "null"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, defaultValueSql: "''"),
                    clave = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_usuarios_id_modificador",
                        column: x => x.id_modificador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_usuarios_usuarios_IdCreador",
                        column: x => x.IdCreador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "varios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_tabla = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "''"),
                    referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    id_padre = table.Column<int>(type: "int", nullable: true),
                    IdCreador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''")
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
                        name: "FK_varios_usuarios_id_modificador",
                        column: x => x.id_modificador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_varios_usuarios_IdCreador",
                        column: x => x.IdCreador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_varios_varios_id_padre",
                        column: x => x.id_padre,
                        principalTable: "varios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_actividad_ruta",
                table: "actividades_proyectos",
                column: "id_actividad_ruta");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_ejecutor",
                table: "actividades_proyectos",
                column: "id_ejecutor");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_estatus_proyecto",
                table: "actividades_proyectos",
                column: "id_estatus_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_estatus_publicacion",
                table: "actividades_proyectos",
                column: "id_estatus_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_modificador",
                table: "actividades_proyectos",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_moneda_costo_estimado",
                table: "actividades_proyectos",
                column: "id_moneda_costo_estimado");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_moneda_costo_real",
                table: "actividades_proyectos",
                column: "id_moneda_costo_real");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_proyecto",
                table: "actividades_proyectos",
                column: "id_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_revisada_por",
                table: "actividades_proyectos",
                column: "id_revisada_por");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_revisor",
                table: "actividades_proyectos",
                column: "id_revisor");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_ruta_proyecto",
                table: "actividades_proyectos",
                column: "id_ruta_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_tipo_actividad",
                table: "actividades_proyectos",
                column: "id_tipo_actividad");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_IdCreador",
                table: "actividades_proyectos",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_ProyectoId",
                table: "actividades_proyectos",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_rutas_proyectos_descripcion",
                table: "actividades_rutas_proyectos",
                column: "descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_actividades_rutas_proyectos_id_modificador",
                table: "actividades_rutas_proyectos",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_rutas_proyectos_id_ruta_proyecto",
                table: "actividades_rutas_proyectos",
                column: "id_ruta_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_rutas_proyectos_IdCreador",
                table: "actividades_rutas_proyectos",
                column: "IdCreador");

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

            migrationBuilder.CreateIndex(
                name: "IX_bitacoras_proyectos_id_actividad_proyecto",
                table: "bitacoras_proyectos",
                column: "id_actividad_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_bitacoras_proyectos_id_modificador",
                table: "bitacoras_proyectos",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_bitacoras_proyectos_id_proyecto",
                table: "bitacoras_proyectos",
                column: "id_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_bitacoras_proyectos_id_tipo_bitacora",
                table: "bitacoras_proyectos",
                column: "id_tipo_bitacora");

            migrationBuilder.CreateIndex(
                name: "IX_bitacoras_proyectos_id_usuario",
                table: "bitacoras_proyectos",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_bitacoras_proyectos_IdCreador",
                table: "bitacoras_proyectos",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_chats_id_modificador",
                table: "chats",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_chats_id_publicacion",
                table: "chats",
                column: "id_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_chats_IdCreador",
                table: "chats",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_chats_titulo",
                table: "chats",
                column: "titulo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_comentarios_id_chat",
                table: "comentarios",
                column: "id_chat");

            migrationBuilder.CreateIndex(
                name: "IX_comentarios_id_comentario",
                table: "comentarios",
                column: "id_comentario");

            migrationBuilder.CreateIndex(
                name: "IX_comentarios_id_modificador",
                table: "comentarios",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_comentarios_id_usuario",
                table: "comentarios",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_comentarios_IdCreador",
                table: "comentarios",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_monedas_id_modificador",
                table: "monedas",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_monedas_IdCreador",
                table: "monedas",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_monedas_nombre",
                table: "monedas",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personal_id_modificador",
                table: "personal",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_personal_id_publicacion_id_rol",
                table: "personal",
                columns: new[] { "id_publicacion", "id_rol" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personal_id_rol",
                table: "personal",
                column: "id_rol");

            migrationBuilder.CreateIndex(
                name: "IX_personal_id_usuario",
                table: "personal",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_personal_IdCreador",
                table: "personal",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_estatus_proyecto",
                table: "proyectos",
                column: "id_estatus_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_estatus_publicacion",
                table: "proyectos",
                column: "id_estatus_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_fase_anterior",
                table: "proyectos",
                column: "id_fase_anterior");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_fase_siguiente",
                table: "proyectos",
                column: "id_fase_siguiente");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_gerente",
                table: "proyectos",
                column: "id_gerente");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_imagen_principal",
                table: "proyectos",
                column: "id_imagen_principal");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_modificador",
                table: "proyectos",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_moneda_costo_estimado",
                table: "proyectos",
                column: "id_moneda_costo_estimado");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_moneda_costo_real",
                table: "proyectos",
                column: "id_moneda_costo_real");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_revisada_por",
                table: "proyectos",
                column: "id_revisada_por");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_revisor",
                table: "proyectos",
                column: "id_revisor");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_ruta_proyecto",
                table: "proyectos",
                column: "id_ruta_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_id_tipo_proyecto",
                table: "proyectos",
                column: "id_tipo_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_IdCreador",
                table: "proyectos",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_titulo",
                table: "proyectos",
                column: "titulo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_clase_publicacion",
                table: "publicaciones",
                column: "id_clase_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_estatus_publicacion",
                table: "publicaciones",
                column: "id_estatus_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_fase_publicacion",
                table: "publicaciones",
                column: "id_fase_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_modificador",
                table: "publicaciones",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_moneda_costo_estimado",
                table: "publicaciones",
                column: "id_moneda_costo_estimado");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_moneda_costo_real",
                table: "publicaciones",
                column: "id_moneda_costo_real");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_proyecto",
                table: "publicaciones",
                column: "id_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_tipo_publicacion",
                table: "publicaciones",
                column: "id_tipo_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_IdCreador",
                table: "publicaciones",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_publicador",
                table: "publicaciones",
                column: "publicador");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_revisada_por",
                table: "publicaciones",
                column: "revisada_por");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_titulo",
                table: "publicaciones",
                column: "titulo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_rastreo_publicaciones_id_fase_anterior",
                table: "rastreo_publicaciones",
                column: "id_fase_anterior");

            migrationBuilder.CreateIndex(
                name: "IX_rastreo_publicaciones_id_fase_publicacion",
                table: "rastreo_publicaciones",
                column: "id_fase_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_rastreo_publicaciones_id_fase_siguiente",
                table: "rastreo_publicaciones",
                column: "id_fase_siguiente");

            migrationBuilder.CreateIndex(
                name: "IX_rastreo_publicaciones_id_modificador",
                table: "rastreo_publicaciones",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_rastreo_publicaciones_id_publicacion",
                table: "rastreo_publicaciones",
                column: "id_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_rastreo_publicaciones_id_usuario",
                table: "rastreo_publicaciones",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_rastreo_publicaciones_IdCreador",
                table: "rastreo_publicaciones",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosPublicaciones_id_estatus_recurso",
                table: "RecursosPublicaciones",
                column: "id_estatus_recurso");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosPublicaciones_id_modificador",
                table: "RecursosPublicaciones",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosPublicaciones_id_tipo_catalogo",
                table: "RecursosPublicaciones",
                column: "id_tipo_catalogo");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosPublicaciones_id_tipo_recurso",
                table: "RecursosPublicaciones",
                column: "id_tipo_recurso");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosPublicaciones_id_usuario",
                table: "RecursosPublicaciones",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosPublicaciones_IdCreador",
                table: "RecursosPublicaciones",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_secuencias_id_modificador",
                table: "secuencias",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_secuencias_IdCreador",
                table: "secuencias",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_tablas_id_modificador",
                table: "tablas",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_tablas_IdCreador",
                table: "tablas",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_email",
                table: "usuarios",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_ciudad",
                table: "usuarios",
                column: "id_ciudad");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_grupo",
                table: "usuarios",
                column: "id_grupo");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_modificador",
                table: "usuarios",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_profesion",
                table: "usuarios",
                column: "id_profesion");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_rol",
                table: "usuarios",
                column: "id_rol");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_IdCreador",
                table: "usuarios",
                column: "IdCreador");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_nombre_segundo_nombre_apellido_segundo_apellido",
                table: "usuarios",
                columns: new[] { "nombre", "segundo_nombre", "apellido", "segundo_apellido" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_TipousuarioId",
                table: "usuarios",
                column: "TipousuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_varios_id_modificador",
                table: "varios",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_varios_id_padre",
                table: "varios",
                column: "id_padre");

            migrationBuilder.CreateIndex(
                name: "IX_varios_id_tabla_descripcion",
                table: "varios",
                columns: new[] { "id_tabla", "descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_varios_IdCreador",
                table: "varios",
                column: "IdCreador");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_actividades_rutas_proyectos_id_actividad_ruta",
                table: "actividades_proyectos",
                column: "id_actividad_ruta",
                principalTable: "actividades_rutas_proyectos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_monedas_id_moneda_costo_estimado",
                table: "actividades_proyectos",
                column: "id_moneda_costo_estimado",
                principalTable: "monedas",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_monedas_id_moneda_costo_real",
                table: "actividades_proyectos",
                column: "id_moneda_costo_real",
                principalTable: "monedas",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_proyectos_id_proyecto",
                table: "actividades_proyectos",
                column: "id_proyecto",
                principalTable: "proyectos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_proyectos_ProyectoId",
                table: "actividades_proyectos",
                column: "ProyectoId",
                principalTable: "proyectos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_usuarios_id_ejecutor",
                table: "actividades_proyectos",
                column: "id_ejecutor",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_usuarios_id_modificador",
                table: "actividades_proyectos",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_usuarios_id_revisada_por",
                table: "actividades_proyectos",
                column: "id_revisada_por",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_usuarios_id_revisor",
                table: "actividades_proyectos",
                column: "id_revisor",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_proyectos_usuarios_IdCreador",
                table: "actividades_proyectos",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

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
                name: "FK_actividades_rutas_proyectos_usuarios_id_modificador",
                table: "actividades_rutas_proyectos",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_rutas_proyectos_usuarios_IdCreador",
                table: "actividades_rutas_proyectos",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_rutas_proyectos_varios_id_ruta_proyecto",
                table: "actividades_rutas_proyectos",
                column: "id_ruta_proyecto",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_administradores_usuarios_id_modificador",
                table: "administradores",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_administradores_usuarios_IdCreador",
                table: "administradores",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_administradores_varios_id_grupo",
                table: "administradores",
                column: "id_grupo",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_proyectos_id_proyecto",
                table: "bitacoras_proyectos",
                column: "id_proyecto",
                principalTable: "proyectos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_usuarios_id_modificador",
                table: "bitacoras_proyectos",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_usuarios_id_usuario",
                table: "bitacoras_proyectos",
                column: "id_usuario",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_usuarios_IdCreador",
                table: "bitacoras_proyectos",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_varios_id_tipo_bitacora",
                table: "bitacoras_proyectos",
                column: "id_tipo_bitacora",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_chats_publicaciones_id_publicacion",
                table: "chats",
                column: "id_publicacion",
                principalTable: "publicaciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_chats_usuarios_id_modificador",
                table: "chats",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_chats_usuarios_IdCreador",
                table: "chats",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_comentarios_usuarios_id_modificador",
                table: "comentarios",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_comentarios_usuarios_id_usuario",
                table: "comentarios",
                column: "id_usuario",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_comentarios_usuarios_IdCreador",
                table: "comentarios",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_monedas_usuarios_id_modificador",
                table: "monedas",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_monedas_usuarios_IdCreador",
                table: "monedas",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_publicaciones_id_publicacion",
                table: "personal",
                column: "id_publicacion",
                principalTable: "publicaciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_usuarios_id_modificador",
                table: "personal",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_usuarios_id_usuario",
                table: "personal",
                column: "id_usuario",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_usuarios_IdCreador",
                table: "personal",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_varios_id_rol",
                table: "personal",
                column: "id_rol",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_RecursosPublicaciones_id_imagen_principal",
                table: "proyectos",
                column: "id_imagen_principal",
                principalTable: "RecursosPublicaciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_usuarios_id_gerente",
                table: "proyectos",
                column: "id_gerente",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_usuarios_id_modificador",
                table: "proyectos",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_usuarios_id_revisada_por",
                table: "proyectos",
                column: "id_revisada_por",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_usuarios_id_revisor",
                table: "proyectos",
                column: "id_revisor",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_usuarios_IdCreador",
                table: "proyectos",
                column: "IdCreador",
                principalTable: "usuarios",
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
                name: "FK_proyectos_varios_id_fase_anterior",
                table: "proyectos",
                column: "id_fase_anterior",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_varios_id_fase_siguiente",
                table: "proyectos",
                column: "id_fase_siguiente",
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
                name: "FK_publicaciones_usuarios_id_modificador",
                table: "publicaciones",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_usuarios_IdCreador",
                table: "publicaciones",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_usuarios_publicador",
                table: "publicaciones",
                column: "publicador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_usuarios_revisada_por",
                table: "publicaciones",
                column: "revisada_por",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_varios_id_clase_publicacion",
                table: "publicaciones",
                column: "id_clase_publicacion",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_varios_id_estatus_publicacion",
                table: "publicaciones",
                column: "id_estatus_publicacion",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_varios_id_fase_publicacion",
                table: "publicaciones",
                column: "id_fase_publicacion",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_varios_id_tipo_publicacion",
                table: "publicaciones",
                column: "id_tipo_publicacion",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_rastreo_publicaciones_usuarios_id_modificador",
                table: "rastreo_publicaciones",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_rastreo_publicaciones_usuarios_id_usuario",
                table: "rastreo_publicaciones",
                column: "id_usuario",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_rastreo_publicaciones_usuarios_IdCreador",
                table: "rastreo_publicaciones",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_rastreo_publicaciones_varios_id_fase_anterior",
                table: "rastreo_publicaciones",
                column: "id_fase_anterior",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_rastreo_publicaciones_varios_id_fase_publicacion",
                table: "rastreo_publicaciones",
                column: "id_fase_publicacion",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_rastreo_publicaciones_varios_id_fase_siguiente",
                table: "rastreo_publicaciones",
                column: "id_fase_siguiente",
                principalTable: "varios",
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

            migrationBuilder.AddForeignKey(
                name: "FK_secuencias_usuarios_id_modificador",
                table: "secuencias",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_secuencias_usuarios_IdCreador",
                table: "secuencias",
                column: "IdCreador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tablas_usuarios_id_modificador",
                table: "tablas",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tablas_usuarios_IdCreador",
                table: "tablas",
                column: "IdCreador",
                principalTable: "usuarios",
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

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_varios_id_rol",
                table: "usuarios",
                column: "id_rol",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_varios_TipousuarioId",
                table: "usuarios",
                column: "TipousuarioId",
                principalTable: "varios",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tablas_usuarios_id_modificador",
                table: "tablas");

            migrationBuilder.DropForeignKey(
                name: "FK_tablas_usuarios_IdCreador",
                table: "tablas");

            migrationBuilder.DropForeignKey(
                name: "FK_varios_usuarios_id_modificador",
                table: "varios");

            migrationBuilder.DropForeignKey(
                name: "FK_varios_usuarios_IdCreador",
                table: "varios");

            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.DropTable(
                name: "bitacoras_proyectos");

            migrationBuilder.DropTable(
                name: "comentarios");

            migrationBuilder.DropTable(
                name: "personal");

            migrationBuilder.DropTable(
                name: "rastreo_publicaciones");

            migrationBuilder.DropTable(
                name: "secuencias");

            migrationBuilder.DropTable(
                name: "actividades_proyectos");

            migrationBuilder.DropTable(
                name: "chats");

            migrationBuilder.DropTable(
                name: "actividades_rutas_proyectos");

            migrationBuilder.DropTable(
                name: "publicaciones");

            migrationBuilder.DropTable(
                name: "proyectos");

            migrationBuilder.DropTable(
                name: "monedas");

            migrationBuilder.DropTable(
                name: "RecursosPublicaciones");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "varios");

            migrationBuilder.DropTable(
                name: "tablas");
        }
    }
}
