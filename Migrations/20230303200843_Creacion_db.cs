﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reciclapp.db.Migrations
{
    public partial class Creacion_db : Migration
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
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_finalizacion = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "NULL"),
                    id_ejecutor = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    id_revisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    id_estatus_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_estatus_proyecto = table.Column<int>(type: "int", nullable: false),
                    id_revisada_por = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    id_tipo_actividad = table.Column<int>(type: "int", nullable: false),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    progreso_estimado = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    evaluacion = table.Column<decimal>(type: "decimal(2,1)", precision: 2, scale: 1, nullable: false, defaultValueSql: "0.0"),
                    fecha_disponible = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "NULL"),
                    total_articulos = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false, defaultValueSql: "1"),
                    costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    id_moneda_costo_estimado = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    tipo_cambio_costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    id_moneda_costo_real = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    tipo_cambio_costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                    descripcion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "''"),
                    secuencia = table.Column<int>(type: "int", nullable: false, defaultValueSql: "1"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actividades_rutas_proyectos", x => x.id);
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
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                    titulo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                    texto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_cita = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                        name: "FK_comentarios_comentarios_id_cita",
                        column: x => x.id_cita,
                        principalTable: "comentarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "monedas",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tipo_cambio = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false, defaultValueSql: "0.0"),
                    es_local = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "0"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                    titulo = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_gerente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_revisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    gustan = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    no_gustan = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    id_estatus_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_estatus_proyecto = table.Column<int>(type: "int", nullable: false),
                    id_revisada_por = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_imagen_principal = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    id_tipo_proyecto = table.Column<int>(type: "int", nullable: false),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    progreso_estimado = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    progreso_real = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    evaluacion = table.Column<decimal>(type: "decimal(2,1)", precision: 2, scale: 1, nullable: false, defaultValueSql: "0.0"),
                    id_ruta_proyecto = table.Column<int>(type: "int", nullable: false),
                    id_fase_anterior = table.Column<int>(type: "int", nullable: true, defaultValueSql: "NULL"),
                    id_fase_siguiente = table.Column<int>(type: "int", nullable: true, defaultValueSql: "NULL"),
                    fecha_disponible = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "NULL"),
                    total_articulos = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false, defaultValueSql: "1"),
                    costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    id_moneda_costo_estimado = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    tipo_cambio_costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    id_moneda_costo_real = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    tipo_cambio_costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                    titulo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    consecutivo = table.Column<int>(type: "int", nullable: false),
                    id_publicador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    gustan = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    no_gustan = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    id_estatus_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_fase_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_tipo_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_clase_publicacion = table.Column<int>(type: "int", nullable: false),
                    id_revisada_por = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    id_imagen_principal = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    posicionamiento = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    secuencia = table.Column<int>(type: "int", nullable: false),
                    vistas = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    evaluacion = table.Column<decimal>(type: "decimal(2,1)", precision: 2, scale: 1, nullable: false, defaultValueSql: "0.0"),
                    direccion_ip_creacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    dispositivo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    referencias_direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    fecha_disponible = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "NULL"),
                    total_articulos = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    id_proyecto = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    id_moneda_costo_estimado = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    tipo_cambio_costo_estimado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    monto_inversion = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    costo_real_traslado = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    id_moneda_costo_real = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    tipo_cambio_costo_real = table.Column<decimal>(type: "decimal(20,3)", precision: 20, scale: 3, nullable: false, defaultValueSql: "0.0"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_publicacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_fase_publicacion = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tiempo_estimado = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    id_fase_anterior = table.Column<int>(type: "int", nullable: true, defaultValueSql: "NULL"),
                    id_fase_siguiente = table.Column<int>(type: "int", nullable: true, defaultValueSql: "NULL"),
                    comentarios = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rastreo_publicaciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_rastreo_publicaciones_publicaciones_id_publicacion",
                        column: x => x.id_publicacion,
                        principalTable: "publicaciones",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "recursos_publicaciones",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    id_tipo_catalogo = table.Column<int>(type: "int", nullable: false),
                    id_catalogo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    secuencia = table.Column<int>(type: "int", nullable: false),
                    id_tipo_recurso = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    orden = table.Column<int>(type: "int", nullable: false, defaultValueSql: "1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    id_estatus_recurso = table.Column<int>(type: "int", nullable: false),
                    fecha_expiracion = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "NULL"),
                    tamano = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "0"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recursos_publicaciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "secuencias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prefijo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    serie = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    incremento = table.Column<int>(type: "int", nullable: false, defaultValueSql: "1"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    segundo_nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    segundo_apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    perfil = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    id_ciudad = table.Column<int>(type: "int", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    telefono2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    clave = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    email2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "''"),
                    id_profesion = table.Column<int>(type: "int", nullable: true, defaultValueSql: "NULL"),
                    maximo_publicaciones = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    id_grupo = table.Column<int>(type: "int", nullable: true),
                    estatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false, defaultValueSql: "''"),
                    id_tipo_usuario = table.Column<int>(type: "int", nullable: false),
                    id_rol = table.Column<int>(type: "int", nullable: true, defaultValueSql: "NULL"),
                    ultima_ip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_usuarios_id_creador",
                        column: x => x.id_creador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_usuarios_usuarios_id_modificador",
                        column: x => x.id_modificador,
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
                    descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    id_padre = table.Column<int>(type: "int", nullable: true, defaultValueSql: "NULL"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
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

            migrationBuilder.CreateTable(
                name: "versiones_api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    version = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    vigente_desde = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_creador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    id_modificador = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NULL"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "1"),
                    version_api = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_versiones_api", x => x.id);
                    table.ForeignKey(
                        name: "FK_versiones_api_usuarios_id_creador",
                        column: x => x.id_creador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_versiones_api_usuarios_id_modificador",
                        column: x => x.id_modificador,
                        principalTable: "usuarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_actividad_ruta",
                table: "actividades_proyectos",
                column: "id_actividad_ruta");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_proyectos_id_creador",
                table: "actividades_proyectos",
                column: "id_creador");

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
                name: "IX_actividades_rutas_proyectos_descripcion",
                table: "actividades_rutas_proyectos",
                column: "descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_actividades_rutas_proyectos_id_creador",
                table: "actividades_rutas_proyectos",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_rutas_proyectos_id_modificador",
                table: "actividades_rutas_proyectos",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_actividades_rutas_proyectos_id_ruta_proyecto",
                table: "actividades_rutas_proyectos",
                column: "id_ruta_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_bitacoras_proyectos_id_actividad_proyecto",
                table: "bitacoras_proyectos",
                column: "id_actividad_proyecto");

            migrationBuilder.CreateIndex(
                name: "IX_bitacoras_proyectos_id_creador",
                table: "bitacoras_proyectos",
                column: "id_creador");

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
                name: "IX_chats_id_creador",
                table: "chats",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_chats_id_modificador",
                table: "chats",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_chats_id_publicacion",
                table: "chats",
                column: "id_publicacion");

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
                name: "IX_comentarios_id_cita",
                table: "comentarios",
                column: "id_cita");

            migrationBuilder.CreateIndex(
                name: "IX_comentarios_id_creador",
                table: "comentarios",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_comentarios_id_modificador",
                table: "comentarios",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_comentarios_id_usuario",
                table: "comentarios",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_monedas_id_creador",
                table: "monedas",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_monedas_id_modificador",
                table: "monedas",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_monedas_nombre",
                table: "monedas",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personal_id_creador",
                table: "personal",
                column: "id_creador");

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
                name: "IX_proyectos_id_creador",
                table: "proyectos",
                column: "id_creador");

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
                name: "IX_proyectos_titulo",
                table: "proyectos",
                column: "titulo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_clase_publicacion",
                table: "publicaciones",
                column: "id_clase_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_creador",
                table: "publicaciones",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_estatus_publicacion",
                table: "publicaciones",
                column: "id_estatus_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_fase_publicacion",
                table: "publicaciones",
                column: "id_fase_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_imagen_principal",
                table: "publicaciones",
                column: "id_imagen_principal");

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
                name: "IX_publicaciones_id_publicador",
                table: "publicaciones",
                column: "id_publicador");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_revisada_por",
                table: "publicaciones",
                column: "id_revisada_por");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_id_tipo_publicacion",
                table: "publicaciones",
                column: "id_tipo_publicacion");

            migrationBuilder.CreateIndex(
                name: "IX_publicaciones_titulo",
                table: "publicaciones",
                column: "titulo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_rastreo_publicaciones_id_creador",
                table: "rastreo_publicaciones",
                column: "id_creador");

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
                name: "IX_recursos_publicaciones_id_creador",
                table: "recursos_publicaciones",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_recursos_publicaciones_id_estatus_recurso",
                table: "recursos_publicaciones",
                column: "id_estatus_recurso");

            migrationBuilder.CreateIndex(
                name: "IX_recursos_publicaciones_id_modificador",
                table: "recursos_publicaciones",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_recursos_publicaciones_id_tipo_catalogo",
                table: "recursos_publicaciones",
                column: "id_tipo_catalogo");

            migrationBuilder.CreateIndex(
                name: "IX_recursos_publicaciones_id_tipo_recurso",
                table: "recursos_publicaciones",
                column: "id_tipo_recurso");

            migrationBuilder.CreateIndex(
                name: "IX_recursos_publicaciones_id_usuario",
                table: "recursos_publicaciones",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_secuencias_id_creador",
                table: "secuencias",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_secuencias_id_modificador",
                table: "secuencias",
                column: "id_modificador");

            migrationBuilder.CreateIndex(
                name: "IX_secuencias_prefijo",
                table: "secuencias",
                column: "prefijo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tablas_id_creador",
                table: "tablas",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_tablas_id_modificador",
                table: "tablas",
                column: "id_modificador");

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
                name: "IX_usuarios_id_creador",
                table: "usuarios",
                column: "id_creador");

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
                name: "IX_usuarios_id_tipo_usuario",
                table: "usuarios",
                column: "id_tipo_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_nombre_segundo_nombre_apellido_segundo_apellido",
                table: "usuarios",
                columns: new[] { "nombre", "segundo_nombre", "apellido", "segundo_apellido" },
                unique: true);

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
                name: "IX_varios_id_tabla_descripcion",
                table: "varios",
                columns: new[] { "id_tabla", "descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_versiones_api_id_creador",
                table: "versiones_api",
                column: "id_creador");

            migrationBuilder.CreateIndex(
                name: "IX_versiones_api_id_modificador",
                table: "versiones_api",
                column: "id_modificador");

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
                name: "FK_actividades_proyectos_usuarios_id_creador",
                table: "actividades_proyectos",
                column: "id_creador",
                principalTable: "usuarios",
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
                name: "FK_actividades_rutas_proyectos_usuarios_id_creador",
                table: "actividades_rutas_proyectos",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_rutas_proyectos_usuarios_id_modificador",
                table: "actividades_rutas_proyectos",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_rutas_proyectos_varios_id_ruta_proyecto",
                table: "actividades_rutas_proyectos",
                column: "id_ruta_proyecto",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_proyectos_id_proyecto",
                table: "bitacoras_proyectos",
                column: "id_proyecto",
                principalTable: "proyectos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bitacoras_proyectos_usuarios_id_creador",
                table: "bitacoras_proyectos",
                column: "id_creador",
                principalTable: "usuarios",
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
                name: "FK_chats_usuarios_id_creador",
                table: "chats",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_chats_usuarios_id_modificador",
                table: "chats",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_comentarios_usuarios_id_creador",
                table: "comentarios",
                column: "id_creador",
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
                name: "FK_monedas_usuarios_id_creador",
                table: "monedas",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_monedas_usuarios_id_modificador",
                table: "monedas",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_publicaciones_id_publicacion",
                table: "personal",
                column: "id_publicacion",
                principalTable: "publicaciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_personal_usuarios_id_creador",
                table: "personal",
                column: "id_creador",
                principalTable: "usuarios",
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
                name: "FK_personal_varios_id_rol",
                table: "personal",
                column: "id_rol",
                principalTable: "varios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_recursos_publicaciones_id_imagen_principal",
                table: "proyectos",
                column: "id_imagen_principal",
                principalTable: "recursos_publicaciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_usuarios_id_creador",
                table: "proyectos",
                column: "id_creador",
                principalTable: "usuarios",
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
                name: "FK_publicaciones_recursos_publicaciones_id_imagen_principal",
                table: "publicaciones",
                column: "id_imagen_principal",
                principalTable: "recursos_publicaciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_usuarios_id_creador",
                table: "publicaciones",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_usuarios_id_modificador",
                table: "publicaciones",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_usuarios_id_publicador",
                table: "publicaciones",
                column: "id_publicador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_publicaciones_usuarios_id_revisada_por",
                table: "publicaciones",
                column: "id_revisada_por",
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
                name: "FK_rastreo_publicaciones_usuarios_id_creador",
                table: "rastreo_publicaciones",
                column: "id_creador",
                principalTable: "usuarios",
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
                name: "FK_recursos_publicaciones_usuarios_id_creador",
                table: "recursos_publicaciones",
                column: "id_creador",
                principalTable: "usuarios",
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

            migrationBuilder.AddForeignKey(
                name: "FK_secuencias_usuarios_id_creador",
                table: "secuencias",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_secuencias_usuarios_id_modificador",
                table: "secuencias",
                column: "id_modificador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tablas_usuarios_id_creador",
                table: "tablas",
                column: "id_creador",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tablas_usuarios_id_modificador",
                table: "tablas",
                column: "id_modificador",
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
                name: "FK_usuarios_varios_id_tipo_usuario",
                table: "usuarios",
                column: "id_tipo_usuario",
                principalTable: "varios",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tablas_usuarios_id_creador",
                table: "tablas");

            migrationBuilder.DropForeignKey(
                name: "FK_tablas_usuarios_id_modificador",
                table: "tablas");

            migrationBuilder.DropForeignKey(
                name: "FK_varios_usuarios_id_creador",
                table: "varios");

            migrationBuilder.DropForeignKey(
                name: "FK_varios_usuarios_id_modificador",
                table: "varios");

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
                name: "versiones_api");

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
                name: "recursos_publicaciones");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "varios");

            migrationBuilder.DropTable(
                name: "tablas");
        }
    }
}